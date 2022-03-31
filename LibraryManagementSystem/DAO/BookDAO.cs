using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.DAO
{
    class BookDAO
    {
        private LMSEntities context = new LMSEntities();

        public BOOK getBookById(int id)
        {
            return context.BOOKs.Where(b => b.ID == id).FirstOrDefault();
        }

        public List<BOOK> getAllBooks()
        {
            return context.BOOKs.ToList<BOOK>();
        }

        public int addBook(BOOK Book)
        {
            BOOK BookEntity = context.BOOKs.Add(Book);
            context.SaveChanges();
            return BookEntity.ID;
        }

        public void updateBook(int Id, string Isbn, string Title, string Description, string Type, string Publisher, string Author, string Category, decimal Price)
        {
            BOOK Book = context.BOOKs.SingleOrDefault(b => b.ID == Id);
            if(Book != null)
            {
                Book.ISBN = Isbn;
                Book.TITLE = Title;
                Book.DESCRIPTION = Description;
                Book.TYPE = Type;
                Book.PUBLISHER = Publisher;
                Book.AUTHOR = Author;
                Book.CATEGORY = Category;
                Book.PRICE = Price;

                context.SaveChanges();
            }
        }
        public void deleteBook(int id)
        {

        }

    }
}
