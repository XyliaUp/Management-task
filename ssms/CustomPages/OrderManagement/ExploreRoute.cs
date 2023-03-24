using System;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

using TMS.Windows.Extension;

namespace TMS.CustomPages.OrderManageremnt
{
	public partial class ExploreRoute : UserControl
	{
		public ExploreRoute()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
		}

		//Margo
		private void Track_Load(object sender, EventArgs e)
		{
			int Num = 0;

			//DAT.DataAccess.GetVehicle().ForEach(Vehicle =>
			//{
			//	Button VehicleBtn = new Button();

			//	VehicleBtn.BackColor = Color.LightSeaGreen;
			//	VehicleBtn.BackgroundImageLayout = ImageLayout.None;
			//	VehicleBtn.FlatAppearance.BorderColor = Color.White;
			//	VehicleBtn.FlatStyle = FlatStyle.Flat;
			//	VehicleBtn.Font = new Font("微软雅黑", 12F);
			//	VehicleBtn.ForeColor = Color.White;
			//	VehicleBtn.ImageAlign = ContentAlignment.MiddleRight;
			//	VehicleBtn.Size = new Size(112, 45);
			//	VehicleBtn.UseVisualStyleBackColor = false;

			//	VehicleBtn.Text = Vehicle.Name ?? $"车辆{ Num + 1 }";


			//	VehicleBtn.Click += new EventHandler((o, s) =>
			//	{
			//		//获得数据
			//		var VehicleSchedule = DAT.DataAccess.GetVehicleSchedule()
			//						.Find(Schedule => Schedule.Vehicle == Vehicle.VehicleID &&
			//							  Schedule.StartTime <= DateTime.Now &&
			//							  Schedule.EndTime >= DateTime.Now);



			//		VehicleAddress.Text = $"车辆位置  { this.map1.Address = Vehicle.Address }";


			//		if (VehicleSchedule?.Driver is null) VehicleDriver.Text = $"负责司机  当前无安排";
			//		else
			//		{
			//			VehicleDriver.Text = $"负责司机  { DAT.DataAccess.GetDriver().Find(d => d.DriverID == VehicleSchedule.Driver).Name }\n\n" +
			//								 $"{ VehicleSchedule.StartTime:yyyy年MM月dd日 HH时mm分ss秒} ~ \n{ VehicleSchedule.EndTime:yyyy年MM月dd日 HH时mm分ss秒}";
			//		}
			//	});



			//	this.panel1.Controls.Add(VehicleBtn);
			//	VehicleBtn.Location = new Point(0, 2 + Num++ * 46);
			//});
		}

		private void MainPage_SizeChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(() =>
			{
				var Route = MapView.MapHelper.Route(this.VName.Text, this.textBox1.Text);

				label3.Text = "路线规划 " + Route.steps;
				label4.Text = $"路线信息 距离:{ Route.distance }米，时间:{ Route.runTime }分钟";
			});

			thread.SetApartmentState(ApartmentState.MTA);
			thread.Start();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Parent.ChangeView<Track>();
		}
	}
}