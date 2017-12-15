using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class BookManager
    {
        Book[] _listOfBooks = new Book[MAX_ELEMENTS];
        const int MAX_ELEMENTS = 100;

        public Book[] ListOfBooks
        {
            get
            {
                return _listOfBooks;
            }
        }

        public void AddBook(Book book)
        {
            for (int i = 0; i < _listOfBooks.Length; i++)
            {
                if (_listOfBooks[i] == null)
                {
                    _listOfBooks[i] = book;
                    break;
                }

                else
                {
                    continue;
                }
            }
        }

        public void AddBook(string bookAsString)
        {
            AddBook(new Book(bookAsString));
        }

        public void RemoveBook(Book book)
        {
            for (int i = 0; i < _listOfBooks.Length; i++)
            {
                if (_listOfBooks[i] == book)
                {
                    _listOfBooks[i] = null;
                    break;
                }

                else
                {
                    continue;
                }
            }
        }

        public Book[] FindAllBooks(string bookAsString)
        {
            int findCount = 0;
            Book[] result;
            for (int i = 0; i < _listOfBooks.Length; i++)
            {
                if (_listOfBooks[i].GetAllProperties().Contains(bookAsString))
                {
                    findCount += 1;
                    result = new Book[findCount];
                    result[findCount] = _listOfBooks[i];
                    return result;
                }
                
            }
            return null;
        }
    

    }
}
