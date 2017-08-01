using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Class_OOP
{
    class ITBook : ABook
    {
        private WroxBookTopic topic;
        public ITBook() : base()
        {
            WriteLine("ITBook default constructor");
        }
        public ITBook(string bookName, Author bookAuthor, double initPrice, double initDiscount, int initPages, WroxBookTopic bookTopic)
            : base(bookName, bookAuthor, initPrice, initDiscount, initPages)
        {
            topic = bookTopic;
            WriteLine("ITBook constructor with parameters");
        }
        public override double SalePrice()
        {
            return OriginalPrice - OriginalPrice * DiscountPercent;
        }
    }
}
