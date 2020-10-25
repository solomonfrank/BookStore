using BookStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(book => book.Id == id).FirstOrDefault();

        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();

        }

        private List<BookModel> DataSource()
        {
           return new List<BookModel>()
           {
               new BookModel(){ Id = 1, Author ="William ShakeSpear", Title ="Tempest", Description ="interest book, worth reading"},
               new BookModel(){ Id = 2, Author ="William ShakeSpear", Title ="King Oliver",  Description ="interest book, worth reading"},
                new BookModel(){ Id = 2, Author ="Larry Frank", Title ="King Oliver",  Description ="interest book, worth reading by Lary"},
           };
        }
    }
}
