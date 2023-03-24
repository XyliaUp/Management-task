using System;
using System.Threading;
using System.Windows.Forms;
namespace TMS.MapView
{
	public partial class Map : UserControl
	{
		string m_Address { get; set; }
		double LocX { get; set; } = 120.03169;
		double LocY { get; set; } = 30.22612;



		public string Address
		{
			get => this.m_Address;
			set
			{	
				try
				{
					var GeoCoder = MapHelper.GeoCoder(this.m_Address = value);

					if (GeoCoder is null)
					{
						MessageBox.Show("请检查网络连接，否则无法获取定位信息。");
						return;
					}

					if (GeoCoder.result != null)
					{
						this.LocX = GeoCoder.result?.location.lng ?? 0;
						this.LocY = GeoCoder.result?.location.lat ?? 0;
					}

					this.webBrowser1.DocumentText = TMS.Properties.Resources.Test
					  .Replace("$SizeX", this.Width.ToString()).Replace("$SizeY", this.Height.ToString())
					  .Replace("$MyLocX", this.LocX.ToString()).Replace("$MyLocY", this.LocY.ToString());
				}
				catch
				{

				}
			}
		}




		public Map()
		{
			InitializeComponent();
		}

		public Map(string Address) : this()
		{
			this.Address = Address;
		}

		private void Map_Load(object sender, EventArgs e)
		{
			
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			this.Text = $"地图查看 (位置:{ this.Address }     经度:{ this.LocX:0.0000°}，维度:{ this.LocY:0.0000°})";
		}
	}
}
