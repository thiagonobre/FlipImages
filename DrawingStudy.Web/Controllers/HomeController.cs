using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace DrawingStudy.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            using (Image img = Image.FromFile(Server.MapPath("~/img/img.jpg")))
            {
                var ms = new MemoryStream();
                img.Save(ms, ImageFormat.Jpeg);
                ms.Position = 0;
                return File(ms, "image/jpeg");
            }
        }

        public ActionResult FlipVertical()
        {
            using (Image img = Image.FromFile(Server.MapPath("~/img/img.jpg")))
            using (Bitmap bmp = Main.FlipVertical(img))
            {
                var ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Jpeg);
                ms.Position = 0;
                return File(ms, "image/jpeg");
            }
        }

        public ActionResult FlipHorizontal()
        {
            using (Image img = Image.FromFile(Server.MapPath("~/img/img.jpg")))
            using (Bitmap bmp = Main.FlipHorizontal(img))
            {
                var ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Jpeg);
                ms.Position = 0;
                return File(ms, "image/jpeg");
            }
        }

    }
}
