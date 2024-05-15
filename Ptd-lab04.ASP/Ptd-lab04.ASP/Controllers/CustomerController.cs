using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ptd_lab04.ASP.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /Customer/CustomerDetail (action returns detailed information of a customer for the CustomerDetail view)
        public ActionResult CustomerDetail()
        {
            // Create a Customer object
            Customer cus = new Customer()
            {
                CustomerId = "KH001",
                FullName = "Pham Thanh Dat",
                Address = "Nam Dinh",
                Email = "thanhdat160924@gmail.com",
                Phone = "0378.630.848",
                Balance = 15200000
            };

            // Passing data to the view using a model
            return View(cus);
        }

        // GET: /Customer/CustomerList (action returns a list of customers for the CustomerList view)
        public ActionResult CustomerList()
        {
            // Create a list of customers
            List<Customer> listcustomer = new List<Customer>()
            {
                new Customer()
                {
                    CustomerId = "KH001",
                    FullName = "Pham Thanh Dat",
                    Address = "Nam Dinh",
                    Email = "thanhdat160924@gmail.com",
                    Phone = "0378.630.848",
                    Balance = 15200000
                },
                new Customer()
                {
                    CustomerId = "KH002",
                    FullName = "Đỗ Thị Cúc",
                    Address = "Hà Nội",
                    Email = "cucdt@gmail.com",
                    Phone = "0986.767.444",
                    Balance = 2200000
                },
                new Customer()
                {
                    CustomerId = "KH003",
                    FullName = "Nguyễn Tuấn Thắng",
                    Address = "Nam Định",
                    Email = "thangnt@gmail.com",
                    Phone = "0924.656.542",
                    Balance = 1200000
                },
                new Customer()
                {
                    CustomerId = "KH004",
                    FullName = "Lê Ngọc Hải",
                    Address = "Hà Nội",
                    Email = "hailn@gmail.com",
                    Phone = "0996.555.267",
                    Balance = 6200000
                }
            };

            // Passing data to the view using ViewBag
            ViewBag.listcustomer = listcustomer;
            return View();
        }
    }
}