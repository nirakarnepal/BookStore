using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using TestBookStore.Models;
using TestBookStore.Repository;

namespace TestBookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }
        public ViewResult GetBook(int id)
        {
            //dynamic data = new ExpandoObject();
            //data.book = _bookRepository.GetBookById(id);
            //data.Name = "N Nepal";
            var data = _bookRepository.GetBookById(id);
            return View(data);
        }

        public List<BookModel>  SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
