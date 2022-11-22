using BSRS.Infra;
using BSRS.Models.Services;
using BSRS.Models.ViewModels;
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
	public partial class CreateUserForm : Form
	{
		public CreateUserForm()
		{
			InitializeComponent();
		}
		private void saveButton_Click(object sender, EventArgs e)
		{
			//取得各欄位的值
			string account = accountTextBox.Text;
			string pwd = pwdTextBox.Text;
			string name = NameTextBox.Text;

			//繫結到ViewModel
			UserVM model = new UserVM
			{
				Account = account,
				Password = pwd,
				Name = name,
			};

			//針對ViewModel進行驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account",accountTextBox },
				{"Password",pwdTextBox },
				{"Name",NameTextBox }
			};
			bool isValid = ValidationHelper.Validate(model, errorProvider1, map);
			if (!isValid) return;

			//若通過驗證就新增紀錄
			try
			{
				new UserService().Create(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗，原因: " + ex.Message);
			}
		}
	}
}
