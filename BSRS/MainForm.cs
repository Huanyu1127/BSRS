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
	public partial class MainForm : Form
	{
		int loginId;
		string userName;
		public MainForm(int loginId,string userName)
		{
			InitializeComponent();
			this.loginId = loginId;
			this.userName = userName;
			userNameLabel.Text = userName;
		}

		private void testButton_Click(object sender, EventArgs e)
		{
			var frm = new TestForm(loginId);
			frm.ShowDialog();
		}

		private void recordButton_Click(object sender, EventArgs e)
		{
			var frm = new RecordForm(loginId,userName);
			frm.ShowDialog();
		}

		private void 方法心情札記ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new MethodForm(loginId);
			frm.ShowDialog();
		}

		private void 歷史紀錄ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new RecordForm(loginId, userName);
			frm.ShowDialog();
		}

		private void 開始測驗ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new TestForm(loginId);
			frm.ShowDialog();
		}
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您確定要登出嗎？", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void 量表分數細覽ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new TestDetailsForm(loginId);
			frm.ShowDialog(); 
		}
	}
}
