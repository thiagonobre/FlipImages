using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using DrawingStudy;

namespace DrawingStudy.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            using (Bitmap bmp = (Bitmap)Bitmap.FromFile(Server.MapPath("~/img/img.jpg")))
            {
                var ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Jpeg);
                ms.Position = 0;
                return File(ms, "image/jpeg");
            }
        }

        public ActionResult FlipVertical()
        {
            using (Bitmap bmp = (Bitmap)Bitmap.FromFile(Server.MapPath("~/img/img.jpg")))
            {
                bmp.FlipVertical();
                var ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Jpeg);
                ms.Position = 0;
                return File(ms, "image/jpeg");
            }
        }

        public ActionResult FlipHorizontal()
        {
            using (Bitmap bmp = (Bitmap)Bitmap.FromFile(Server.MapPath("~/img/img.jpg")))
            {
                bmp.FlipHorizontal();
                var ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Jpeg);
                ms.Position = 0;
                return File(ms, "image/jpeg");
            }
        }

        public ActionResult FlipBoth()
        {
            using (Bitmap bmp = (Bitmap)Bitmap.FromFile(Server.MapPath("~/img/img.jpg")))
            {
                bmp.FlipHorizontal().FlipVertical();
                var ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Jpeg);
                ms.Position = 0;
                return File(ms, "image/jpeg");
            }
        }

    }
}
