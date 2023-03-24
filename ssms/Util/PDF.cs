using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;

using TMS.Windows.Extension;

namespace TMS.Util
{
	public class PDF
	{
		public static void SaveAs(DataGridView View)
		{
			SaveFileDialog SaveFile = new SaveFileDialog();
			SaveFile.Filter = "PDF文件|*.pdf";

			if (SaveFile.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string what = "";

					iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8);
					string folderPath = SaveFile.FileName;

					//Creating iTextSharp Table from the DataTable data
					Document pdfDoc = new Document(PageSize.A4);

					PdfPTable pdfTable = new PdfPTable(View.ColumnCount);
					pdfTable.DefaultCell.Padding = View.DefaultCellStyle.Padding.All;

					pdfTable.WidthPercentage = 100;
					pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
					pdfTable.DefaultCell.BorderWidth = 0;

					//Adding Header row
					foreach (DataGridViewColumn column in View.Columns)
					{
						PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
						cell.BackgroundColor = new BaseColor(255, 255, 255);
						cell.HorizontalAlignment = Element.ALIGN_CENTER;
						pdfTable.AddCell(cell);
					}

					//Adding DataRow
					foreach (DataGridViewRow row in View.Rows)
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
	}
}
