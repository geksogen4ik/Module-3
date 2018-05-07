using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Monograph : Books
    {
        public DateTime Limit(DateTime todayDate)
        {
            todayDate = DateTime.Today;
            term = todayDate.AddDays(60.0);
            Console.WriteLine($"You should return Monograph on {term}");
            return term;
        }
    }
}
