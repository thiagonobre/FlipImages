using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawingStudy
{
    public static class Main
    {
        public static Bitmap FlipVertical(this Bitmap bmp)
        {
            if (bmp == null)
            {
                return null;
            }

            int x, y, i, j;

            for (i = 0, x = (int)Math.Ceiling((double)bmp.Width / 2); i < x; i++)
            {

                for (j = 0, y = (int)Math.Ceiling((double)bmp.Height / 2); j < y; j++)
                {
                    int x1, y1, x2, y2;

                    x1 = i;
                    y1 = j;
                    x2 = bmp.Width - i - 1;
                    y2 = bmp.Height - j - 1;


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

        public static Bitmap FlipHorizontal(this Bitmap bmp)
        {
            if (bmp == null)
            {
                return null;
            }

            int x, y, i, j;

            for (i = 0, x = (int)Math.Ceiling((double)bmp.Width / 2); i < x; i++)
            {
                for (j = 0, y = (int)Math.Ceiling((double)bmp.Height / 2); j < y; j++)
                {
                    int x1, y1, x2, y2;

                    x1 = i;
                    y1 = j;
                    x2 = bmp.Width - i - 1;
                    y2 = bmp.Height - j - 1;


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
