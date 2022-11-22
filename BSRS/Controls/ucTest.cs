using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSRS.Controls
{
	public partial class ucTest : UserControl
	{
		public ucTest()
		{
			InitializeComponent();
		}
		public int GetValue()
		{
			RadioButton[] controls = { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5 };

			int value = -1;

			foreach (RadioButton item in controls)
			{
				if (item.Checked)
				{
					value = Convert.ToInt32(item.Tag);
					break;
				}
			}
			return value;
		}
	}
}
