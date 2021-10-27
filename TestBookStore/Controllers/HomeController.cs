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
        [ViewData]
        public string Title { get; set; }

        [ViewData]
        public  BookModel Book { get; set; }
        public ViewResult Index()
        {
            //ViewBag.Title = "NEP";
            //dynamic data = new ExpandoObject();
            //data.Id = 1;
            //data.Name = "NN";
            //ViewBag.Data = data;

            //ViewBag.Type = new BookModel() {Id=5, Author="Author" };

            //ViewData["property1"] = "N Nepal";
            //ViewData["book"] = new BookModel() { Author = "N Nepal", Id = 1111 };
            Title = "Home";
            Book = new BookModel() { Id = 112, Title = "This Is VIew Data" };
            return View();
        }
        public ViewResult AboutUs()
        {
            Title = "AboutUs";
            return View();
        }

        public ViewResult ContactUs()
        {
            Title = "ContactUs";
            return View();
        }
    }
}
