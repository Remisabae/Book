using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class BookManager
    {
        #region instance variables
        
        Book[] _listOfBooks = new Book[MAX_ELEMENTS];
        const int MAX_ELEMENTS = 100;

        #endregion

        #region properties
        
        public Book[] ListOfBooks
        {
            get
            {
                return _listOfBooks;
            }
        }

        #endregion

        #region public methods

        
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

        /*'   public Book[] FindAllBooks(string bookAsString)
           {
               int findCount = 0;
               Book[] result;
               for (int i = 0; i < _listOfBooks.Length; i++)
               {
                       if (_listOfBooks[i].GetAllProperties().Contains(bookAsString))
                       {
                           findCount += 1;
                           result = new Book[findCount];

                           return result;
                       }
               }
               return null;
           }
           */ //Did not Succeed to finish the method 

        public Book FindAllBooks(string bookAsString) // New Method 
        {
            for (int i = 0; i < _listOfBooks.Length; i++)
            {
                if (_listOfBooks[i].GetAllProperties().Contains(bookAsString))
                {
                    return _listOfBooks[i];

                }
            }
            return null; 
        }

        #endregion
    }
}
