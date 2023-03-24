using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.MapView
{
	public partial class MapRoute : Form
	{
		public string RouteStep
		{
			set => this.label1.Text = value;
		}


		public MapRoute()
		{
			InitializeComponent();
		}

		private void MapRoute_Load(object sender, EventArgs e)
		{

		}
	}
}
