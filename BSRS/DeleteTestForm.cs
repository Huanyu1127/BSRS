using BSRS.Models.Services;
using BSRS.Models.ViewModels;
using ISpan.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSRS
{
	public partial class DeleteTestForm : Form
	{
		int id;
		public DeleteTestForm(int id)
		{
			InitializeComponent();
			this.id = id;
		}

		private void BindData(int id)
		{
			string sql = "Select * From Tests T join categories C on T.categoryId = C.id join Users U on U.id = T.Userid where T.id=@id";
			var parameters = new SqlParameterBuilder()
				.AddInt("@id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉，找不到您選取的資料，請再試一次");
				this.DialogResult = DialogResult.OK;

				this.Close();
				return;
			}
			//將找到的一筆資料由DataTable轉換到Proc
			TestVM model = ToVM(data.Rows[0]);

			//再將 viewModel值繫結到各控制項
			dateLabel.Text = model.testDate.ToString();
			gradeLabel.Text = model.grade.ToString();
			categoryLabel.Text = model.categoryName;
			notesTextBox.Text = model.notes;

		}
		private TestVM ToVM(DataRow row)
		{
			return new TestVM
			{
				id = row.Field<int>("id"),
				testDate = row.Field<DateTime>("testDate"),
				grade = row.Field<int>("grade"),
				categoryName = row.Field<string>("categoryName"),
				notes=row.Field<string>("notes"),
			};
		}

		private void DeleteTestForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}
		private void deleteButton_Click(object sender, EventArgs e)
		{
			TestVM model = new TestVM
			{
				id = id,
			};
			new TestServices().Delete(model);
			this.DialogResult = DialogResult.OK;
		}
	}
}
