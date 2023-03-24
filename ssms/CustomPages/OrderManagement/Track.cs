using System;
using System.Drawing;
using System.Windows.Forms;

using TMS.Windows.Extension;
namespace TMS.CustomPages.OrderManageremnt
{
	public partial class Track : UserControl
	{
		public Track()
		{
			InitializeComponent();
		}

		//Margo
		private void Track_Load(object sender, EventArgs e)
		{
			int Num = 0;

			DAT.DataAccess.GetVehicle().ForEach(Vehicle =>
			{
				Button VehicleBtn = new Button();

				VehicleBtn.BackColor = Color.LightSeaGreen;
				VehicleBtn.BackgroundImageLayout = ImageLayout.None;
				VehicleBtn.FlatAppearance.BorderColor = Color.White;
				VehicleBtn.FlatStyle = FlatStyle.Flat;
				VehicleBtn.Font = new Font("微软雅黑", 8.60F);
				VehicleBtn.ForeColor = Color.White;
				VehicleBtn.ImageAlign = ContentAlignment.MiddleRight;
				VehicleBtn.Size = new Size(145, 45);
				VehicleBtn.UseVisualStyleBackColor = false;

				VehicleBtn.Text = (Vehicle.Name ?? $"车辆{ Num + 1 }") + $" [{ Vehicle.Platenum }]";
				VehicleBtn.Click += new EventHandler((o, s) =>
				{
					//获得数据
					var VehicleSchedule = DAT.DataAccess.GetVehicleSchedule()
									.Find(Schedule => Schedule.Vehicle == Vehicle.VehicleID &&
										  Schedule.StartTime <= DateTime.Now &&
										  Schedule.EndTime >= DateTime.Now);


					VehicleAddress.Text = $"车辆位置  { this.map1.Address = Vehicle.Address }";

					if (VehicleSchedule?.Driver is null) VehicleDriver.Text = $"负责司机  当前无安排";
					else
					{
						VehicleDriver.Text = $"负责司机  { DAT.DataAccess.GetDriver().Find(d => d.DriverID == VehicleSchedule.Driver).Name }\n\n" +
											 $"{ VehicleSchedule.StartTime:yyyy年MM月dd日 HH时mm分ss秒} ~ \n{ VehicleSchedule.EndTime:yyyy年MM月dd日 HH时mm分ss秒}";
					}
				});

				this.panel1.Controls.Add(VehicleBtn);
				VehicleBtn.Location = new Point(0, 2 + Num++ * 46);
			});
		}

		private void MainPage_SizeChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Parent.ChangeView<Dispatch.AddDispatch>();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Parent.ChangeView<ExploreRoute>();
		}
	}
}
