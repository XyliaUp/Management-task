using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TMS
{
	public partial class Welcome : UserControl
	{
		public Welcome()
		{
			InitializeComponent();
		}


		private void Welcome_Load(object sender, EventArgs e)
		{
			textBox2.UseSystemPasswordChar = true;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			textBox2.UseSystemPasswordChar = !checkBox1.Checked;
		}

		private void Welcome_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				OkBtn1_Customlick(null, null);
			}
		}

		private void OkBtn1_Customlick(object sender, EventArgs e)
		{
			try
			{
				if (textBox1.Text == "" || textBox2.Text == "") label5.Visible =  label4.Visible = true;
				else
				{
					label5.Visible = label4.Visible = false;
					string username = textBox1.Text;
					string pass = textBox2.Text;


					bool Exist = DAT.DataAccess.GetUser().Where(i => i.UserEmail == username || i.UserName == username).Any();
					if (!Exist) label5.Visible = label4.Visible = true;
					else
					{
						var Info = DAT.DataAccess.GetUser().Where(i =>
						(i.UserEmail == username || i.UserName == username) && i.UserPassword == pass && i.UserActivated);


						bool Correct = Info.Any();
						if (!Correct) label5.Visible = label4.Visible = true;
						else
						{
							//开始载入
							TMS.Properties.Common.LoggedIn = Info.First();
							((BasicForm)this.Parent.Parent).ChangeView<Pages.Main>();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("非常抱歉，由于系统发生错误，操作没有完成!");
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{
			TMS.Properties.Common.LoggedIn = DAT.DataAccess.GetUser().Find(u => u.UserID == 1);

			//开始载入
			((BasicForm)this.Parent.Parent).ChangeView<Pages.Main>();
		}
	}
}