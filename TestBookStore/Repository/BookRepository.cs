using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBookStore.Models;

namespace TestBookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title = "MVC", Author = "Kar", Description="You Can Learn MVC", Category="Design", Language="English"},
                new BookModel(){Id=2, Title = "C#", Author = "Nepal", Description="You Can Learn C#", Category="Programming", Language="English"},
                new BookModel(){Id=3, Title = "ASP", Author = "Amap", Description="You Can Learn ASP", Category="Programming", Language="French"},
                new BookModel(){Id=4, Title = ".net", Author = "John", Description="You Can Learn .NET", Category="Coding", Language="English"},
                new BookModel(){Id=5, Title = "identity", Author = "Adap", Description="You Can Learn Identity", Category="Framework", Language="Spanish"}
            };
        }


    }
}
