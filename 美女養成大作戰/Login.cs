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
			SelectGoal goal = new SelectGoal();//產生SelectGoal的物件

			this.Visible = false;//將Login隱藏
			goal.Visible = true;//顯示第二個視窗
		}
	}
}