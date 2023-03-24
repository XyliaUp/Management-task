using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.Windows.Extension;
namespace TMS.CustomPages.InfoManageremnt
{
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			InitializeComponent();
		}

		//Margo
		private void MyAccount_Load(object sender, EventArgs e)
		{

		}

		

		private void MainPage_SizeChanged(object sender, EventArgs e)
		{
			this.panel2.Height = this.Height - Btn_Custom.Bottom - 10;
		}





		private void Btn_Custom_Click(object sender, EventArgs e)
		{
			this.panel2.ChangeView<Custom.CustomList>();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.panel2.ChangeView<Driver.DriverList>();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.panel2.ChangeView<Vehicle.VehicleList>();
		}
	}
}
