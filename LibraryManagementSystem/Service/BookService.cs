using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryManagementSystem.DAO;
using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.Service
{
    class BookService
    {
        private BookDAO BookDAO = new BookDAO();

        public BOOK getBookById(int BookId)
        {
            return BookDAO.getBookById(BookId);
        }

        public List<BOOK> getAllBooks()
        {
            return BookDAO.getAllBooks();
        }

        public int addBook(string Isbn, string Title, string Description, string Type, string Publisher, string Author, string Category, decimal Price)
        {
            BOOK Book = new BOOK();
            Book.ISBN = Isbn;
            Book.TITLE = Title;
            Book.DESCRIPTION = Description;
            Book.TYPE = Type;
            Book.PUBLISHER = Publisher;
            Book.AUTHOR = Author;
            Book.CATEGORY = Category;
            Book.PRICE = Price;

            List<BOOK> Books = BookDAO.getAllBooks();
            Book.ID = !Books.Any() ? 1001 : Books.Last().ID + 1;

            return BookDAO.addBook(Book);
            
        }
        public void updateBook(int Id, string Isbn, string Title, string Description, string Type, string Publisher, string Author, string Category, decimal Price)
        {
            BookDAO.updateBook(Id, Isbn, Title, Description, Type, Publisher, Author, Category, Price);
        }
    }
}
