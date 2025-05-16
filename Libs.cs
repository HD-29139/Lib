using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib
{
    public class Libs
    {
        private List<Book> books = new List<Book>();

        public void BookAdd(Book book)
        {
            books.Add(book);
        }

        public List<Book> BookList()
        {
            return books;
        }

        public List<Book> SearchByGender(BookGenre genre)
        {
            List<Book> result = new List<Book>();

            foreach (Book book in books)
            {
                if (book.Genre == genre)
                {
                    result.Add(book);
                }
            }
            return result;
        }

        public Book SearchByTitle(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title.ToLower() == title.ToLower())
                {
                    return book;
                }
            }

            return null;
        }
        
    }
}