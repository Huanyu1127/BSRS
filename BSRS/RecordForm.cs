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
	public partial class RecordForm : Form
	{
		int loginId;
		string userName;
		private TestsIndexVM[] test = null;
		public RecordForm(int loginId, string userName)
		{
			InitializeComponent();
			this.userName = userName;
			this.loginId = loginId;
			userNameLabel.Text = userName;
			DisPlayTests();
		}
		private void DisPlayTests()
		{
			test = new TestServices().GetAll(loginId).ToArray();
			BindData(test);
		}

		private void BindData(TestsIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;

			if (rowIndex < 0) return; //選取欄=>沒資料

			TestsIndexVM row = this.test[rowIndex]; //使用者點到的那筆紀錄

			int id = row.id; 

			var frm = new DeleteTestForm(id);

			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK) DisPlayTests();
		}
	}
}
