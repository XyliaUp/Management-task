using System;
using System.Windows.Forms;

namespace TMS.Pages
{
	public partial class Main : UserControl
	{
		public Main()
		{
			InitializeComponent();
		}

		public void ChangeView<T>() where T : Control, new()
		{
			try
			{
				panel2.Controls.Clear();
				T find = new T();
				find.Parent = panel2;
				find.Dock = DockStyle.Fill;
				find.BringToFront();
			}
			catch (Exception e)
			{

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("此功能未完成");
		}


		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (((BasicForm)this.Parent.Parent).scan != true)
			{
				if (!TMS.Properties.Common.LoggedIn.UserAdmin) MessageBox.Show("您没有此用户组的管理权限。");
				else ChangeView<Users>();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (((BasicForm)this.Parent.Parent).scan != true)
			{
				ChangeView<MyAccount>();
			}

		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (((BasicForm)this.Parent.Parent).scan != true)
			{
				if (MessageBox.Show("你是否要退出本管理系统?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					TMS.Properties.Common.LoggedIn = null;
					((BasicForm)this.Parent.Parent).ChangeView<Welcome>();
				}
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			ChangeView<TMS.CustomPages.OrderManageremnt.Track>();
		}

		private void Btn_InfoManagement_Click(object sender, EventArgs e)
		{
			ChangeView<TMS.CustomPages.InfoManageremnt.MainPage>();
		}
	}
}
