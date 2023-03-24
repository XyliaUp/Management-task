using System;
using System.Windows.Forms;
using System.Linq;

using TMS.Windows.Extension;
namespace TMS.CustomPages.InfoManageremnt.Custom
{
	public partial class AddCustom : UserControl
	{
		public AddCustom()
		{
			InitializeComponent();
		}


		//** 增加客户
		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				TMS.DAT.DataAccess.AddCustom(new LTS.Custom()
				{
					Register = DateTime.Now,
					Name = this.DName.Text,
					Phone = long.Parse(this.Phone.Text),
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
			this.Parent.ChangeView<CustomList>();
		}
	}
}
