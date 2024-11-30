using System;
using System.Windows.Forms;

namespace Курсова_
{
	public partial class Form1_Vhid : Form
	{
		public Form1_Vhid()
		{
			InitializeComponent();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Form2_Tovar f1 = new Form2_Tovar();
			f1.Show();
			this.Hide();
		}

		private void guna2Button2_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Form1_Vhid_Load(object sender, EventArgs e)
		{

		}
	}
}
