using BSRS.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace BSRS
{
	public partial class TestGrade : Form
	{
		string forTestDetails;
		public TestGrade(int totalGrade, int ucTestGrade6)
		{
			InitializeComponent();
			string scale = string.Empty;
			string ucTestGradeLabel6 = string.Empty;
			ucTest6.Text=string.Empty;
			this.forTestDetails = string.Empty;
			
			if (totalGrade <= 5)
			{
				scale = "0-5分，一般正常範圍";
				forTestDetails = "一般正常範圍";
			}
			else if (totalGrade <= 9)
			{
				scale = "6-9分，輕度情緒困擾，\r\n建議找親友談談，抒發情緒。";
				forTestDetails = "輕度情緒困擾";
			}
			else if (totalGrade <= 14)
			{
				scale = "11-14分，中度情緒困擾，\r\n建議尋求心理衛生或精神醫療專業諮詢。";
				forTestDetails = "中度情緒困擾";
			}
			else if (totalGrade >= 15)
			{
				scale = "15分以上，重度情緒困擾，\r\n建議尋求精神醫療專業諮詢。";
				forTestDetails = "重度情緒困擾";
			}

			if (ucTestGrade6 >= 2)
			{
				ucTestGradeLabel6 = $"有自殺的想法{ucTestGrade6}分，\r\n為2分以上(中等程度)建議尋求精神醫療專業諮詢。";
			}

			TestGradeLabel.Text = (totalGrade.ToString());
			TestGradeScale.Text= ($"得分範圍是{scale}");
			ucTest6.Text = ($"{ucTestGradeLabel6}");

		}

		private void okButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Yes;
		}
		public string GetTestDetails()
		{
			return forTestDetails;
		}

	}
}
