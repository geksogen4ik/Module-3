using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Periodical : Books
    {
        public DateTime Limit(DateTime todayDate)
        {
            todayDate = DateTime.Today;
            term = todayDate.AddDays(15.0);
            Console.WriteLine($"You should return Periodical on {term}");
            return term;
        }
    }
}
