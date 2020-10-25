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
     
        public ViewResult Index()
        {
            var allBooks =  _BookRepository.GetAllBooks();
            return View(allBooks);
        }

        public ViewResult GetBook(int id)
        {
            var book =  _BookRepository.GetBookById(id);
            return View();
        }

        public ViewResult SearchBook(string title, string author)
        {
            var result =  _BookRepository.SearchBook(title, author);
            return View();
        }
    }
}
