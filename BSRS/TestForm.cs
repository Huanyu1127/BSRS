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
	public partial class TestForm : Form
	{
		int loginId;
		public TestForm(int loginId)
		{
			InitializeComponent();
			this.loginId = loginId;
			InitForm();
		}
		private void InitForm()
		{
			categoryIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			List<MethodIndexVM> categories = new MethodServices().GetComboBoxNoAll(loginId).ToList();

			this.categoryIdComboBox.DataSource = categories;
		}

		private void SubmitButton_Click(object sender, EventArgs e)
		{
			//取得各欄位的值
			int categoryId = ((MethodIndexVM)categoryIdComboBox.SelectedItem).id;
			string notes = notesTextBox.Text;

			int ucTestGrade1 = ucTest1.GetValue();
			int ucTestGrade2 = ucTest2.GetValue();
			int ucTestGrade3 = ucTest3.GetValue();
			int ucTestGrade4 = ucTest4.GetValue();
			int ucTestGrade5 = ucTest5.GetValue();
			int ucTestGrade6 = ucTest6.GetValue();

			int[] ucTestTotalGrade = { ucTestGrade1, ucTestGrade2, ucTestGrade3, ucTestGrade4, ucTestGrade5, ucTestGrade6 };

			bool isNull = ucTestTotalGrade.Any(x => x == -1);
			if (isNull)
			{
				MessageBox.Show("您有題目未選填，請再確認一次");
				return;
			}
			string scale = string.Empty;
			string uctest6 = string.Empty;

			int totalGrade = ucTestTotalGrade.Take(5).Sum();

			var frm = new TestGrade(totalGrade, ucTestGrade6);

			DialogResult result = frm.ShowDialog();

			string forTestDetails = frm.GetTestDetails();

			//繫結到ViewModel
			TestVM model = new TestVM
			{
				grade = totalGrade,
				notes = notes,
				categoryId = categoryId,
				userId = this.loginId,
				ucTestGrade1 = ucTestGrade1,
				ucTestGrade2 = ucTestGrade2,
				ucTestGrade3 = ucTestGrade3,
				ucTestGrade4 = ucTestGrade4,
				ucTestGrade5 = ucTestGrade5,
				totalGrade = totalGrade,
				forTestDetails = forTestDetails,
			};

			new TestServices().Create(model);

			this.DialogResult = DialogResult.OK;
		}
	}
}
