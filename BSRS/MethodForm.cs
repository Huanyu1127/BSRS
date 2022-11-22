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
using static System.Net.Mime.MediaTypeNames;

namespace BSRS
{
	public partial class MethodForm : Form
	{
		int loginId;
		private MethodIndexVM[] category = null;
		public MethodForm(int loginId)
		{
			this.loginId = loginId;
			InitializeComponent();
			InitForm();
			DisPlayCategories();
		}
		private void InitForm()
		{
			categoryIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			List<MethodIndexVM> categories = new MethodServices().GetComboBox(loginId).ToList();

			this.categoryIdComboBox.DataSource = categories;
		}
		private void DisPlayCategories()
		{
			category = new MethodServices().GetAll(categoryIdComboBox, loginId).ToArray();
			BindData(category);
		}

		private void BindData(MethodIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}
		private void searchButton_Click(object sender, EventArgs e)
		{
			DisPlayCategories();
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;

			if (rowIndex < 0) return; //選取欄=>沒資料

			MethodIndexVM row = this.category[rowIndex]; //使用者點到的那筆紀錄

			int id = row.id;

			var frm = new EditCategoryForm(id, loginId);

			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK) DisPlayCategories();
		}
	}
}
