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
	public partial class EditCategoryForm : Form
	{
		int id;
		int loginId;
		public EditCategoryForm(int id,int loginId)
		{
			InitializeComponent();
			this.id = id;
			this.loginId = loginId;
			InitForm();
		}

		private void EditCategoryForm_Load(object sender, EventArgs e)
		{
			BindData(id, loginId);
		}
		private void BindData(int id,int loginId)
		{
			string sql = "Select * From Tests T join categories C on T.categoryId = C.id join Users U on U.id = T.Userid where T.id=@id and userId=@userId";
			var parameters = new SqlParameterBuilder()
				.AddInt("@id", id)
				.AddInt("@userId", loginId)
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
			categoryIdComboBox.Text = model.categoryName;
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
				notes = row.Field<string>("notes"),
			};
		}
		private void InitForm()
		{
			categoryIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			List<MethodIndexVM> categories = new MethodServices().GetComboBoxNoAll(loginId).ToList();

			this.categoryIdComboBox.DataSource = categories;
		}
		private void updateButton_Click(object sender, EventArgs e)
		{
			string notes = notesTextBox.Text;
			int categoryId = ((MethodIndexVM)categoryIdComboBox.SelectedItem).id;

			TestVM model = new TestVM
			{
				notes = notes,
				categoryId = categoryId,
				id=this.id,
			};
			new TestServices().Update(model);
			this.DialogResult = DialogResult.OK;
			//MessageBox.Show("新增失敗，原因: " + ex.Message);
		}
	}
}
