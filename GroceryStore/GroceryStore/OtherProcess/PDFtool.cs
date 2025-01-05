using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.OtherProcess
{
    internal class PDFtool
    {
        public static void SavePanelAsPdf(Panel pnl, string filePath)
            {
            // Chụp nội dung Panel thành hình ảnh
            Bitmap bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, pnl.Width, pnl.Height));

            // Tạo tài liệu PDF
            PdfDocument pdf = new PdfDocument();
            PdfPage page = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Điều chỉnh kích thước trang PDF theo hình ảnh
            page.Width = XUnit.FromPoint(bmp.Width);
            page.Height = XUnit.FromPoint(bmp.Height);

            // Chuyển đổi Bitmap sang XImage
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                XImage img = XImage.FromStream(ms);

                // Vẽ hình ảnh lên PDF
                gfx.DrawImage(img, 0, 0, bmp.Width, bmp.Height);
            }

            // Lưu file PDF
            pdf.Save(filePath);
            MessageBox.Show($"Panel đã được lưu dưới dạng PDF tại: {filePath}");
        }


    }
}
