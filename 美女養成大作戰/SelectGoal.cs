﻿using System;
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
	public partial class SelectGoal : Form
	{
		public SelectGoal()
		{
			InitializeComponent();
		}

		private void goalSubmit_Click(object sender, EventArgs e)
		{
			InputData inputdata = new InputData();
			inputdata.Show();
		}
	}
}