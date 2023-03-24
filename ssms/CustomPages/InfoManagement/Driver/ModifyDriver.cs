using System;
using System.Windows.Forms;
using System.Linq;

using TMS.Windows.Extension;
namespace TMS.CustomPages.InfoManageremnt.Driver
{
	public partial class ModifyDriver : UserControl
	{
		public long DriverID { get; set; }

		public ModifyDriver(LTS.Driver Driver)
		{
			InitializeComponent();

			//Load
			Enum.GetNames(typeof(DataClasses.Sex)).ToList().ForEach(t => this.Cmb_Sex.Items.Add(t));
			this.Cmb_Sex.Text = this.Cmb_Sex.Items.Count > 0 ? this.Cmb_Sex.Items[0].ToString() : null;


			this.License.Text = Driver.License.ToString();
			this.DriverNum.Text = Driver.DriverNum.ToString();
			this.DName.Text = Driver.Name;
			this.DriverID = Driver.DriverID;
		}


		//** 增加司机
		private void button5_Click(object sender, EventArgs e)
		{
			label11.Visible = false;


			if (!int.TryParse(this.DriverNum.Text, out int DNum))
			{
				label11.Visible = true;
			}




			if (label11.Visible) return;



			try
			{
				TMS.DAT.DataAccess.UpdateDriver(new LTS.Driver()
				{
					DriverID = DriverID,
					Sex = (int)Enum.Parse(typeof(DataClasses.Sex), this.Cmb_Sex.Text) == 0,
					License = long.Parse(this.License.Text),
					DriverNum = DNum,
					Register = DateTime.Now,
					Name = this.DName.Text,
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
			this.Parent.ChangeView<DriverList>();
		}
	}
}
