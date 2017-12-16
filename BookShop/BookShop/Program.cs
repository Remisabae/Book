using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager manager = new BookManager();

            Book HarryPotter = new Book("42454", "Harry Potter", "Marko");
            HarryPotter.PublishingDate = Convert.ToDateTime("20.1.2017");
            HarryPotter.GrossPrice = 4.20;
            HarryPotter.Vat = 20;
            manager.AddBook(HarryPotter);

            Book JohnnySins = new Book("42454", "Johnny Sins", "Stefan");
            JohnnySins.PublishingDate = Convert.ToDateTime("10.10.2003");
            JohnnySins.GrossPrice = 4.69;
            JohnnySins.Vat = 69;
            manager.AddBook(JohnnySins.GetAllProperties());

            for (int i = 0; i < manager.ListOfBooks.Length; i++)
            {
                if (manager.ListOfBooks[i] != null)
                {
                    Console.WriteLine(manager.ListOfBooks[i].GetAllProperties());
                }
                else
                {
                    break;
                }
            }

            Console.ReadLine();

            Book[] result = manager.FindAllBooks("Harry Potter");
            for (int i = 0; i < manager.ListOfBooks.Length; i++)
            {
                Console.WriteLine(result[i].GetAllProperties());
            }
            Console.ReadLine();
        }
    }
}
