using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.Windows.Controls
{
	[DefaultEvent("CustomClick")]
	public partial class OkBtn : UserControl
	{
		public delegate void CustomClickHandle(object sender, EventArgs e);

		public event CustomClickHandle CustomClick;



		public OkBtn()
		{
			InitializeComponent();
		}

		private void OkBtn_SizeChanged(object sender, EventArgs e)
		{
			this.label5.Location = new Point(this.btnUpdate.Right + 2, this.btnUpdate.Height / 2 - this.label5.Height / 2);
		}

		[Category("外观"), Description("文本")]
		public string CustomText
		{
			get => this.label5.Text;
			set
			{
				this.label5.Text = value;
				this.Refresh();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (CustomClick != null) CustomClick(sender, e);
		}

		private void label5_Click(object sender, EventArgs e)
		{
			if (CustomClick != null) CustomClick(sender, e);
		}

		private void OkBtn_Load(object sender, EventArgs e)
		{
			OkBtn_SizeChanged(null, null);
		}
	}
}
