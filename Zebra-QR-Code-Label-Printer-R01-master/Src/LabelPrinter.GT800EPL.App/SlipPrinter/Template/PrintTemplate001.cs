using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FontStyle = System.Drawing.FontStyle;

namespace SlipPrinter.Template
{
    public class PrintTemplate001 : IPrintTemplate
    {
        public override void Print(System.Drawing.Rectangle bound, System.Drawing.Graphics g)
        {
            bound.Width = 200;

            var logoWidth = 70;
            var logoHeight = 70;
            var logoLeftMargin = 0;
            var logoTopMargin = 0;

            //g.DrawImage(Bitmap.FromFile(string.Format(@"C:\QR\{0}.jpg", Data.CodeText)), logoLeftMargin, logoTopMargin, logoWidth, logoHeight);
            g.DrawImage(Bitmap.FromFile(string.Format(@"C:\QR\{0}.jpg", Data.MacAddr)), logoLeftMargin, logoTopMargin, logoWidth, logoHeight);

            // Create string to draw.
            String drawString = Data.ItemNo.Substring(0, Data.ItemNo.Length - 4);

            // Create font and brush.
            Font drawFont = new Font("Arial", 10, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            float x = 80.0F;
            float y = 2;

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DisplayFormatControl;

            // Draw string to screen. ItemNo Print
            g.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);


            //ItemNo4 Print
           // Font drawFontB = new Font("Arial", 14, FontStyle.Bold);
            Font drawFontB = new Font("Arial", 10, FontStyle.Bold);
            drawString = Data.ItemNo4;
            x = 90.0F; ;
            y = 22.0F;
            // Draw string to screen. 
            g.DrawString(drawString, drawFontB, drawBrush, x, y, drawFormat);

            //PrintDate Print
            Font drawFontC = new Font("Arial", 6);
            drawString = Data.PrintDate;
            x = 80.0F;
            y = 45.0F;
            // Draw string to screen. 
            g.DrawString(drawString, drawFontC, drawBrush, x, y, drawFormat);

            //MacAddr Print
            Font drawFontD = new Font("Arial", 7, FontStyle.Bold);
            drawString = Data.MacAddr;
            x = 80.0F;
            y = 55.0F;
            // Draw string to screen. 
            g.DrawString(drawString, drawFontD, drawBrush, x, y, drawFormat);

        }
    }
}
