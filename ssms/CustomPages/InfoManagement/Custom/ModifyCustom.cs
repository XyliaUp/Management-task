using System;
using System.Windows.Forms;
using System.Linq;

using TMS.Windows.Extension;
namespace TMS.CustomPages.InfoManageremnt.Custom
{
	public partial class ModifyCustom : UserControl
	{
		public int CustomID { get; set; }

		public ModifyCustom(LTS.Custom Custom)
		{
			InitializeComponent();

			//Load
			this.textBox1.Text = Custom.Name.ToString();
			this.Phone.Text = Custom.Phone.ToString();
		}


		//** 增加司机
		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				 DAT.DataAccess.UpdateCustom(new LTS.Custom()
				 {
					CustomID = CustomID,
					Register = DateTime.Now,
					Name = this.textBox1.Text,
					Phone = long.Parse(this.Phone.Text)
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
