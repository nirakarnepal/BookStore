using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using TestBookStore.Models;

namespace TestBookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "NEP";
            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "NN";
            ViewBag.Data = data;

            ViewBag.Type = new BookModel() {Id=5, Author="Author" };

            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
