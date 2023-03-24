using System;
using System.Windows.Forms;
using System.Linq;

using TMS.Windows.Extension;
namespace TMS.CustomPages.InfoManageremnt.Driver
{
	public partial class AddDriver : UserControl
	{
		public AddDriver()
		{
			InitializeComponent();

			//Load
			Enum.GetNames(typeof(DataClasses.Sex)).ToList().ForEach(t => this.Cmb_Sex.Items.Add(t));
			this.Cmb_Sex.Text = this.Cmb_Sex.Items.Count > 0 ? this.Cmb_Sex.Items[0].ToString() : null;
		}


		//** 增加车辆
		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				TMS.DAT.DataAccess.AddDriver(new LTS.Driver()
				{
					Sex = (int)Enum.Parse(typeof(DataClasses.Sex), this.Cmb_Sex.Text) == 0,
					License = long.Parse(this.License.Text),
					DriverNum = int.Parse(this.DriverNum.Text),
					Register = DateTime.Now,
					Name = this.DName.Text,
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
			this.Parent.ChangeView<DriverList>();
		}
	}
}
