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
using static System.Net.Mime.MediaTypeNames;

namespace BSRS
{
	public partial class TestDetailsForm : Form
	{
		int loginId;
		private TestsIndexVM[] test = null;
		public TestDetailsForm(int loginId)
		{
			InitializeComponent();
			this.loginId = loginId;
			DisPlayTests();
		}
		private void DisPlayTests()
		{
			test = new TestServices().GetGradeDetails(loginId).ToArray();
			BindData(test);
		}

		private void BindData(TestsIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}
	}
}
