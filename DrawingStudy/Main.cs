using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawingStudy
{
    public class Main
    {
        public static Bitmap FlipVertical(Image img)
        {
            Bitmap bmp = new Bitmap(img);

            int x = img.Width / 2;

            if (x % 2 == 0) x--;

            for (; x >= 0; x--)
            {
                int y = img.Height / 2;

                if (y % 2 == 0) y--;

                for (; y >= 0; y--)
                {
                    int x1, y1, x2, y2;

                    x1 = x;
                    y1 = y;
                    x2 = img.Width - x - 1;
                    y2 = img.Height - y - 1;


                    var pixel1 = bmp.GetPixel(x1, y1);
                    var pixel2 = bmp.GetPixel(x1, y2);
                    var pixel3 = bmp.GetPixel(x2, y1);
                    var pixel4 = bmp.GetPixel(x2, y2);
                    bmp.SetPixel(x1, y1, pixel2);
                    bmp.SetPixel(x1, y2, pixel1);
                    bmp.SetPixel(x2, y1, pixel4);
                    bmp.SetPixel(x2, y2, pixel3);
                }
            }

            return bmp;
        }

        public static Bitmap FlipHorizontal(Image img)
        {
            Bitmap bmp = new Bitmap(img);

            int x = img.Width / 2;

            if (x % 2 == 0) x--;

            for (; x >= 0; x--)
            {
                int y = img.Height / 2;
                
                if (y % 2 == 0) y--;

                for (; y >= 0; y--)
                {
                    int x1, y1, x2, y2;

                    x1 = x;
                    y1 = y;
                    x2 = img.Width - x - 1;
                    y2 = img.Height - y - 1;


                    var pixel1 = bmp.GetPixel(x1, y1);
                    var pixel2 = bmp.GetPixel(x2, y1);
                    var pixel3 = bmp.GetPixel(x1, y2);
                    var pixel4 = bmp.GetPixel(x2, y2);
                    bmp.SetPixel(x1, y1, pixel2);
                    bmp.SetPixel(x2, y1, pixel1);
                    bmp.SetPixel(x1, y2, pixel4);
                    bmp.SetPixel(x2, y2, pixel3);
                }
            }

            return bmp;
        }
    }
}
