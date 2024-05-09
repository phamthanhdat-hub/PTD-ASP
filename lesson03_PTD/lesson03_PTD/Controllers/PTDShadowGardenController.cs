using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson03_PTD.Controllers
{
    public ActionResult Index()
    {

        // Truyền dữ liệu từ Controllers Lên View
        ViewBag.fullname = "Pham Thanh Dat";
        ViewData["Ngày sinh"] = "16/09/2004";
        TempData["Email"] = "thanhdat160924@gmail.com";

        return View();
    }

    public ActionResult Details()
    {
        string ptdStr = "";
        ptdStr += "<h3>Họ Và Tên: Pham Thanh Dat/h3>";
        ptdStr += "<p> Mã Sinh Viên : 2210900007";
        ptdStr += "<p> Địa Chỉ Email : thanhdat160924@gmail.com";
        ViewBag.Details = ptdStr;

        return View("ChiTiet");
    }

    public ActionResult LangugeRazor()
    {
        string[] names = { "Pham Thanh V", "Nguyễn Thanh T", "Nguyễn Văn T", "Hoàng Cửu B" };
        ViewBag.Names = names;
        return View();
    }


    public ActionResult AddnewStudent()
    {
        return View();
    }
    [HttpPost]
    public ActionResult AddnewStudent(FormCollection form)
    {
        // lấy dữ liệu trên form 
        string fullname = form["FullName"];
        string Masv = form["Mã Sinh Viên"];
        string TaiKhoan = form["Account"];
        string PassWord = form["PassWord"];
        string EnterThePassword = form["Password"];

        string ptdStr = "<h3>" + fullname + "</h3>";
        ptdStr += "<p>" + Masv;
        ptdStr += "<p>" + TaiKhoan;
        ptdStr += "<p>" + PassWord;
        ptdStr += "<p>" + EnterThePassword;

        ViewBag.info = ptdStr;

        return View("KetQua");
    }
}
}