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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}
		private void loginButton_Click(object sender, EventArgs e)
		{
			//將表單欄位值繫結到ViewModel
			LoginVM model = new LoginVM()
			{
				Account = accountTextBox.Text,
				Password = pwdTextBox.Text,
			};

			//驗證欄位是否輸入正確
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account",accountTextBox },
				{"Password",pwdTextBox },
			};

			bool isValid = ValidationHelper.Validate(model, errorProvider1, map);
			if (!isValid) return;

			//判斷帳密是否正確
			bool result = new UserService().Authenticate(model);
			if (result == false)
			{
				MessageBox.Show("帳號或密碼錯誤");
				return;
			}

			//登入正確後的UserID
			int loginId = new UserService().AuthenticatedLoginId(model);
			string userName = new UserService().AuthenticatedLoginName(model);
			//若正確就開啟mainForm
			accountTextBox.Text = string.Empty;
			pwdTextBox.Text = string.Empty;

			var frm = new MainForm(loginId, userName);
			frm.Owner = this;

			frm.Show();
			this.Hide();
		}
		private void AddNewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateUserForm();

			frm.Owner = this;
			this.Hide();

			DialogResult result = frm.ShowDialog();
			this.Show();

			//if (result == DialogResult.OK) 
		}
	}
}
