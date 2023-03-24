using System;
using System.Windows.Forms;

using TMS.CustomPages.OrderManageremnt;
using TMS.Pages;

namespace TMS
{
	public partial class BasicForm : Form
	{
		public bool scan = false;
		public BasicForm()
		{
			Application.EnableVisualStyles();

			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ChangeView<Welcome>();
			ChangeView<ExploreRoute>();
		}


		public void ChangeView<T>() where T : Control, new()
		{
			try
			{
				panel.Controls.Clear();
				T find = new T();
				find.Parent = panel;
				find.Dock = DockStyle.Fill;
				find.BringToFront();
			}
			catch
			{

			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (scan != true)
			{
				if (MessageBox.Show("你确定要退出本系统吗？", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
				{
					e.Cancel = true;
				}
			}
			else
			{
				e.Cancel = true;
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{
			if (TMS.Properties.Common.LoggedIn != null) ChangeView<Main>();
		}
	}
}