using System;
using System.Windows.Forms;
using System.Linq;

using TMS.Windows.Extension;
namespace TMS.CustomPages.InfoManageremnt.Vehicle
{
	public partial class AddVehicle : UserControl
	{
		public AddVehicle()
		{
			InitializeComponent();

			//Load
			Enum.GetNames(typeof(DataClasses.VehicleType)).ToList().ForEach(t => this.comboBox2.Items.Add(t));
			this.comboBox2.Text = this.comboBox2.Items.Count > 0 ? this.comboBox2.Items[0].ToString() : null;
		}


		//** 增加车辆
		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				TMS.DAT.DataAccess.AddVehicle(new LTS.Vehicle()
				{
					Capacity = float.Parse(this.textBox3.Text),
					Platenum = this.textBox1.Text,
					Type = (int)Enum.Parse(typeof(DataClasses.VehicleType), this.comboBox2.Text),
					Register = DateTime.Now,
					Name = VName.Text
				});

				this.button1_Click(null, null);
			}
			catch(Exception ex)
			{
				MessageBox.Show(Util.ErrorCode.Common.ErrorCodes.Find(EC => EC.Code == 100).Info);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Parent.ChangeView<VehicleList>();
		}
	}
}
