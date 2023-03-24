using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;

using TMS.Windows.Extension;


namespace TMS.CustomPages.InfoManageremnt.Driver
{
	public partial class DriverList : UserControl
	{
		/// <summary>
		/// 车辆信息列表
		/// </summary>
		Dictionary<int, LTS.Driver> Drivers { get; set; } = new Dictionary<int, LTS.Driver>();


		public DriverList()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Parent.ChangeView<AddDriver>();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedCells.Count >= 1)
			{
				int RowIndex = this.dataGridView1.SelectedCells[0].RowIndex;
				if (Drivers.ContainsKey(RowIndex))
				{
					this.Parent.ChangeView(new ModifyDriver(Drivers[RowIndex]));
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			SaveFileDialog SaveFile = new SaveFileDialog();
			SaveFile.Filter = "PDF文件|*.pdf";

			if (SaveFile.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string what = "";
					if (radioButton1.Checked == true)
					{
						what = "All";
					}

					iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8);
					string folderPath = SaveFile.FileName;

					//Creating iTextSharp Table from the DataTable data
					Document pdfDoc = new Document(PageSize.A4);

					PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
					pdfTable.DefaultCell.Padding = dataGridView1.DefaultCellStyle.Padding.All;

					pdfTable.WidthPercentage = 100;
					pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
					pdfTable.DefaultCell.BorderWidth = 0;

					//Adding Header row
					foreach (DataGridViewColumn column in dataGridView1.Columns)
					{
						PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
						cell.BackgroundColor = new BaseColor(255, 255, 255);
						cell.HorizontalAlignment = Element.ALIGN_CENTER;
						pdfTable.AddCell(cell);
					}



					//Adding DataRow
					foreach (DataGridViewRow row in dataGridView1.Rows)
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							// pdfTable.AddCell(cell.Value.ToString());
							PdfPCell cellRows = new PdfPCell(new Phrase(cell.Value?.ToString(), font));
							int R = cell.Style.BackColor.R;
							int G = cell.Style.BackColor.G;
							int B = cell.Style.BackColor.B;
							if (R == 0 && G == 0 && B == 0)
							{
								R = 255;
								G = 255;
								B = 255;
							}

							cellRows.BackgroundColor = new BaseColor(R, G, B);
							cellRows.HorizontalAlignment = Element.ALIGN_CENTER;
							pdfTable.AddCell(cellRows);

						}
					}

					Paragraph writing = new Paragraph("道路运输管理信息系统 (TMS)" + Environment.NewLine + "信息" + what + "                " + DateTime.Now.ToString() + Environment.NewLine + Environment.NewLine);
					using (FileStream stream = new FileStream(folderPath, FileMode.Create))
					{
						PdfWriter.GetInstance(pdfDoc, stream);
						pdfDoc.Open();
						pdfDoc.Add(writing);
						pdfDoc.Add(pdfTable);
						pdfDoc.Close();
						stream.Close();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(Util.ErrorCode.Common.ErrorCodes.Find(EC => EC.Code == 100).Info);
				}
			}
		}


		private void VehicleList_Load(object sender, EventArgs e)
		{
			try
			{
				if (radioButton1.Checked)
				{
					List<LTS.Driver> i = new List<LTS.Driver>();

					//从数据库中加载信息
					i = DAT.DataAccess.GetDriver();
					List<LTS.Driver> ivList = new List<LTS.Driver>();

					for (int x = 0; x < i.Count; x++)
					{
						//填充信息到元素
						LTS.Driver id = new LTS.Driver()
						{
							DriverID = i[x].DriverID,
							Name = i[x].Name,
							Register = i[x].Register,
							DriverNum = i[x].DriverNum,
							License = i[x].License,
							Sex = i[x].Sex,
						};


						ivList.Add(id);
						var Row = dataGridView1.Rows.Add(id.DriverNum, id.Name, (DataClasses.Sex)((bool)id.Sex ? 0 : 1), id.License, id.Register);
						Drivers.Add(Row, id);
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
