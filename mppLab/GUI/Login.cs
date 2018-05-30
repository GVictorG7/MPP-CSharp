using System;
using System.Windows.Forms;
using mppLab.service;
using mppLab.GUI;

namespace mppLab
{
	public partial class Form1 : Form
	{
		private OperatorService service = new OperatorService();

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			if (service.UserExists(tbUser.Text) & service.GetPass(tbUser.Text).Equals(tbPass.Text))
			{
				Hide();
				Main main = new Main();
				main.Show();
			}
		}
	}
}
