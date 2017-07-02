using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 美女養成大作戰
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_Enter_Click(object sender, EventArgs e)
		{
			SelectGoal selectgoal = new SelectGoal();
			selectgoal.Show();
		}
	}
}