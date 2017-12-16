using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class Book
    {
        string _isbn = "";
        string _title = "";
        string _author = "";
        DateTime _publishingDate;
        double _grossPrice;
        int _vat;

        public Book(string isbn, string title, string author)
        {
            _isbn = isbn;
            _title = title;
            _author = author;
        }

        public Book(string bookAsString)
        {
            string[] properties = bookAsString.Split(';');

            _isbn = properties[0];
            _title = properties[1];
            _author = properties[2];
            _publishingDate = Convert.ToDateTime(properties[3]);
            _grossPrice = Convert.ToDouble(properties[4]);
            _vat = Convert.ToInt32(properties[5]);

        }

        public string Isbn
        {
            get
            {
                return _isbn;
            }

            set
            {
                _isbn = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
            }
        }

        public DateTime PublishingDate
        {
            get
            {
                return _publishingDate;
            }

            set
            {
                _publishingDate = value;
            }
        }

        public double GrossPrice
        {
            get
            {
                return _grossPrice;
            }

            set
            {
                _grossPrice = value;
            }
        }

        public int Vat
        {
            get
            {
                return _vat;
            }

            set
            {
                _vat = value;
            }
        }

        public double NetPrice
        {
            get
            {
                double netPrice = GrossPrice * (1 + Vat / 100);
                return netPrice;
            }
        }
        
        public string GetAllProperties()
        {
            return Isbn + ";" + Title + ";" + Author + ";" + PublishingDate.ToString("MMMM dd, yyyy") + ";" + GrossPrice + ";" + Vat;
        }

    }
}
