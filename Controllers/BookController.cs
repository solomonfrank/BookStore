using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Model;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _BookRepository;

        public BookController()
        {
            _BookRepository = new BookRepository();
        }
     
        public List<BookModel> Index()
        {
            return _BookRepository.GetAllBooks();
        }

        public BookModel GetBook(int id)
        {
            return _BookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return _BookRepository.SearchBook(title, author);
        }
    }
}
