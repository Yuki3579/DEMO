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
	public partial class InputData : Form
	{
		public InputData()
		{
			InitializeComponent();
		}

		public void submit_Click(object sender, EventArgs e)
		{
			InputData inputdata = new InputData();
			inputdata.Show();
		}

		public string TextBoxMsg
		{
			set
			{
				weight.Text = value;
				weight.Text = value;
				weight.Text = value;
				weight.Text = value;
			}
			get
			{
				return weight.Text;
				return weight.Text;
				return weight.Text;
				return weight.Text;
			}
		}
	}
}