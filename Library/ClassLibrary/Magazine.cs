using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Magazine : Books
    {
        public DateTime Limit(DateTime todayDate)
        {
            todayDate = DateTime.Today;
            term = todayDate.AddDays(20.0);
            Console.WriteLine($"You should return Magazine on {term}");
            return term;
        }
       
    }
}
