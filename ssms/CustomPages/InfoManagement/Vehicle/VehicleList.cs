using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;

using TMS.Windows.Extension;


namespace TMS.CustomPages.InfoManageremnt.Vehicle
{
	public partial class VehicleList : UserControl
	{
		/// <summary>
		/// 车辆信息列表
		/// </summary>
		Dictionary<int, LTS.Vehicle> Vehicles { get; set; } = new Dictionary<int, LTS.Vehicle>();


		public VehicleList()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Parent.ChangeView<AddVehicle>();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedCells.Count >= 1)
			{
				int RowIndex = this.dataGridView1.SelectedCells[0].RowIndex;
				if (Vehicles.ContainsKey(RowIndex))
				{
					this.Parent.ChangeView(new ModifyVehicle(Vehicles[RowIndex]));
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			TMS.Util.PDF.SaveAs(dataGridView1);
		}

		private void VehicleList_Load(object sender, EventArgs e)
		{
			try
			{
				if (radioButton1.Checked)
				{
					List<LTS.Vehicle> i = new List<LTS.Vehicle>();

					//从数据库中加载信息
					i = DAT.DataAccess.GetVehicle();
					List<LTS.Vehicle> ivList = new List<LTS.Vehicle>();

					for (int x = 0; x < i.Count; x++)
					{
						//填充信息到元素
						LTS.Vehicle iv = new LTS.Vehicle()
						{
							VehicleID = i[x].VehicleID,
							Name = i[x].Name,
							Capacity = i[x].Capacity,
							Platenum = i[x].Platenum,
							Register = i[x].Register,
							Type = i[x].Type,
							Address = i[x].Address,
						};


						ivList.Add(iv);
						var Row = dataGridView1.Rows.Add(iv.VehicleID, iv.Name, iv.Platenum, (DataClasses.VehicleType)iv.Type, ((double)iv.Capacity).ToString("0.00"), iv.Address, iv.Register);
						Vehicles.Add(Row, iv);
					}
				}

				dataGridView1.ClearSelection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(TMS.Util.ErrorCode.Common.ErrorCodes.Find(EC => EC.Code == 100).Info);
			}
		}
	}
}
