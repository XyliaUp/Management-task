using System;
using System.Windows.Forms;
using System.Linq;

using TMS.Windows.Extension;
namespace TMS.CustomPages.InfoManageremnt.Vehicle
{
	public partial class ModifyVehicle : UserControl
	{
		public long VehicleID { get; set; }

		public ModifyVehicle(LTS.Vehicle Vehicle)
		{
			InitializeComponent();

			//Load
			Enum.GetNames(typeof(DataClasses.VehicleType)).ToList().ForEach(t => this.comboBox2.Items.Add(t));
			this.comboBox2.Text = this.comboBox2.Items.Count > 0 ? this.comboBox2.Items[0].ToString() : null;


			this.VehicleID = Vehicle.VehicleID;
			this.VName.Text = Vehicle.Name;
			this.textBox1.Text = Vehicle.Platenum.ToString();
			this.textBox3.Text = Vehicle.Capacity.ToString();
			this.VehicleAddress.Text = Vehicle.Address;
		}


		//** 增加车辆
		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				TMS.DAT.DataAccess.UpdateVehicle(new LTS.Vehicle()
				{
					Capacity = float.Parse(this.textBox3.Text),
					Platenum = this.textBox1.Text,
					Type = (int)Enum.Parse(typeof(DataClasses.VehicleType), this.comboBox2.Text),
					Register = DateTime.Now,
					VehicleID = VehicleID,
					Name = this.VName.Text,
					Address  = this.VehicleAddress.Text,
				});

				this.button1_Click(null, null);
			}
			catch (Exception ex)
			{
				MessageBox.Show(Util.ErrorCode.Common.ErrorCodes.Find(EC => EC.Code == 100).Info);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Parent.ChangeView<VehicleList>();
		}

		private void ModifyVehicle_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(this.VehicleAddress.Text)) new TMS.MapView.Map(this.VehicleAddress.Text).Show();
			else MessageBox.Show(Util.ErrorCode.Common.ErrorCodes.Find(EC => EC.Code == 501).Info);
		}
	}
}
