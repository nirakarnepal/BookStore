﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBookStore.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All books";
        }
        public string GetBook(int id)
        {
            return $"book with id = {id}";
        }

        public string SearchBooks(string bookName, string authorName)
        {
            return $"Book with name = {bookName} & Author = {authorName}";
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
