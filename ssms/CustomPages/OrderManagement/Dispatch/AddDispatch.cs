using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TMS.Windows.Extension;
namespace TMS.CustomPages.OrderManageremnt.Dispatch
{
	public partial class AddDispatch : UserControl
	{
		Dictionary<string, LTS.Vehicle> Vehicles { get; set; } = new Dictionary<string, LTS.Vehicle>();

		Dictionary<string, LTS.Driver> Drivers { get; set; } = new Dictionary<string, LTS.Driver>();



		public AddDispatch()
		{
			InitializeComponent();
		}

		private void AddDispatch_Load(object sender, EventArgs e)
		{
			DAT.DataAccess.GetVehicle().ForEach(Vehicle =>
			{
				string Key = $"[{ Vehicle.VehicleID }] { Vehicle.Name }";
				this.Vehicles.Add(Key, Vehicle);
				this.comboBox2.Items.Add(Key);
			});

			DAT.DataAccess.GetDriver().ForEach(Driver =>
			{
				string Key = $"[{ Driver.DriverID }] { Driver.Name }";
				this.Drivers.Add(Key, Driver);
				this.comboBox1.Items.Add(Key);
			});
		}




		//** 增加车辆
		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				TMS.DAT.DataAccess.AddVehicleSchedule(new LTS.VehicleSchedule()
				{
					StartTime = dateTimePicker1.Value,
					EndTime = dateTimePicker2.Value,

					Vehicle = this.Vehicles[this.comboBox2.Text].VehicleID,
					Driver = this.Drivers[this.comboBox1.Text].DriverID,

					User = TMS.Properties.Common.LoggedIn.UserID,
				}) ;

				this.button1_Click(null, null);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				MessageBox.Show(Util.ErrorCode.Common.ErrorCodes.Find(EC => EC.Code == 100).Info);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Parent.ChangeView<Track>();
		}
	}
}
