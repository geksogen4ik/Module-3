using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many guys do you want to add? ");
            try
            {
                int amount = int.Parse(Console.ReadLine());
                Dictionary<int, string> dic = Dictionary.MyDictionary(amount);

                // Получаем коллекцию ключей
                ICollection <int> keys = dic.Keys;


                Console.WriteLine("Collection conteins: ");
                foreach (int items in keys)
                  Console.WriteLine("ID: {0}  Name: {1}", items, dic[items]);
                

                Dictionary<int, string> dic1 = Dictionary.Delete(amount);

                ICollection<int> keys1 = dic1.Keys;
                foreach (int items in keys1)
                    Console.WriteLine("ID: {0}  Name: {1}", items, dic1[items]);

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input");
            }

            Console.ReadLine();
        }
    }
}
        