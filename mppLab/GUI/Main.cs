using System;
using System.ComponentModel;
using System.Windows.Forms;
using mppLab.service;
using mppLab.model;

namespace mppLab.GUI
{
	public partial class Main : Form
	{
		MainService service = new MainService();

		public Main()
		{
			InitializeComponent();
			var bindingList = new BindingList<Cursa>(service.GetCurse());
			var source = new BindingSource(bindingList, null);
			var bindingListParticipanti = new BindingList<Participant>(service.GetParticipanti());
			var sourcedatagrid2 = new BindingSource(bindingListParticipanti, null);
			dataGridView1.DataSource = source;
			dataGridView2.DataSource = sourcedatagrid2;

			comboBox1.DataSource = service.GetEchipe();
			comboBox2.DataSource = service.GetCap();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dataGridView2.DataSource = service.GetByEchipa(comboBox1.SelectedItem.ToString());
		}

		private void Save_Click(object sender, EventArgs e)
		{
			int id = service.GetParticipanti().Count + 1;
			service.SavePartcipant(id, textBox1.Text, textBox2.Text, Int32.Parse(comboBox2.SelectedItem.ToString()), 1);
		}
	}
}
