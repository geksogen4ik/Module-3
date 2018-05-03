using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Book : Books
    {
        public void Limit()
        {
            todayDate = DateTime.Today;
            term = todayDate.AddDays(30.0);
            Console.WriteLine($"You should return Book on {term}");
        }
    }
}
