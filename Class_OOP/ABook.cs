using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Class_OOP
{
    abstract class ABook
    {
        private string name;
        private Author author;
        private double originalPrice;
        private double discountPercent; // %
        private readonly int pageNumbers;
        public ABook()
        {
            WriteLine("Abook default constructor");
        }
        public ABook(string bookName = "Unknown", Author bookAuthor = null, double initPrice = 1000, double initDiscount = 0, int initPages = 50)
        {
            name = bookName;
            author = bookAuthor;
            originalPrice = initPrice;
            discountPercent = initDiscount;
            pageNumbers = initPages;
            WriteLine("Abook constructor with parameters");
        }
        public string Name { get => name; set => name = value; }
        public double OriginalPrice { get => originalPrice; set => originalPrice = value; }
        public double DiscountPercent
        { get => discountPercent;
          set
            {
                try
                {
                    if (value >= 0 && value <= 100)
                        discountPercent = value;
                    else
                        throw new ArgumentException("Discount percent is invalid. Please provide another value for it: ");
                }
                catch(ArgumentException argExcep)
                {
                    WriteLine(argExcep.Message);
                    discountPercent = 0;
                }
            }
        }
        public int PageNumbers { get => pageNumbers; }
        internal Author Author { get => author; set => author = value; }

        public abstract double SalePrice();



    }
}
