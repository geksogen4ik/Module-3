using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MultivolumeEdition : Books
    {
        public DateTime Limit(DateTime todayDate)
        {
            todayDate = DateTime.Today;
            term = todayDate.AddDays(90.0);
            Console.WriteLine($"You should return MultivolumeEdition on {term}");
            return term;
        }
    }
}
