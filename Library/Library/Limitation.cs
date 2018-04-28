using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Limitation
    {
        public DateTime term;
        public DateTime todayDate;

        public void DateTerm()
        {
            Console.WriteLine("If you want to find out how long can you store your book, please select type of book:");
            Console.WriteLine("'Book', select - [1]");
            Console.WriteLine("'Periodical', select - [2]");
            Console.WriteLine("'MultivolumeEdition', select - [3]");
            Console.WriteLine("'Magazine', select - [4]");
            Console.WriteLine("'Monograph', select - [5]");
            Console.WriteLine("'Manuscript', select - [6]");

            int choice = 0;
            Int32.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    todayDate = DateTime.Today;
                    term = todayDate.AddDays(30.0);
                    Console.WriteLine($"You should return Book on {term}");
                    break;

                case 2:
                    todayDate = DateTime.Today;
                    term = todayDate.AddDays(15.0);
                    Console.WriteLine($"You should return Periodical on {term}");
                    break;
                case 3:
                    todayDate = DateTime.Today;
                    term = todayDate.AddDays(90.0);
                    Console.WriteLine($"You should return MultivolumeEdition on {term}");
                    break;
                case 4:
                    todayDate = DateTime.Today;
                    term = todayDate.AddDays(20.0);
                    
                    Console.WriteLine($"You should return Magazine on {term}");
                    break;
                case 5:
                    todayDate = DateTime.Today;
                    term = todayDate.AddDays(60.0);
                    Console.WriteLine($"You should return Monograph on {term}");
                    break;
                case 6:
                    todayDate = DateTime.Today;
                    term = todayDate.AddDays(30.0);
                    Console.WriteLine($"You should return Manuscript {term}");
                    break;
            }
        }
    }
}
