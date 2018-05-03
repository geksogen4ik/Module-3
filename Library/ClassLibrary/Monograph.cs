using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Monograph : Books
    {
        public void Limit()
        {
            todayDate = DateTime.Today;
            term = todayDate.AddDays(60.0);
            Console.WriteLine($"You should return Monograph on {term}");
        }
    }
}
