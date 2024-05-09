using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lession03_PTD.Controllers
{
    public class PTDStudentController : Controller
    {
        // GET: PTDStudent
        public ActionResult Index()
        {
            // du lieu tu ViewData
            ViewData["msg"] = "ViewData-Pham Thanh Dat";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }
        public ActionResult StudentList()
        {
            // su dung ViewBag
            ViewBag.titleName = " Danh sach hoc vien-Pham Thanh Dat";
            // gia tri la mot tap hop
            string[] names = { "Nguyễn Thanh T", "Nguyễn Văn T", "Hoàng Cửu B" };
            ViewBag.Names = names;
            //gia tri la mot doi tuong
            var obj = new
            {
                ID = 10,
                Name = "Thanh dat",
                Age=20
            };
        ViewBag.student = obj;
            return View();
        }
        public ActionResult Insert ()
        {
            return View();
        }
    }
}