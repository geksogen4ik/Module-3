using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Dictionary
    {

        public static Dictionary<int, string> MyDictionary(int amount)
        {

            Dictionary<int, string> dic = new Dictionary<int, string>();
            Console.WriteLine("Enter the name: \n");
            string name;
            for (int i = 0; i < amount; i++)
            {
                Console.Write("Name:", i);
                name = Console.ReadLine();
                dic.Add(i, name);
                Console.Clear();
            }
            return dic;
        }
        public static Dictionary<int, string> Delete(int amount)
        {

            Dictionary<int, string> dic = new Dictionary<int, string>();

            while (amount <= 3)
            {
                for (int i = 0; i < amount; i++)
                {
                    if (i % 3 == 0)
                    {
                        dic.Remove(i);
                        Console.WriteLine($"ID{i}is removed");
                        amount--;
                    }

                }

                Dictionary<int, string> newShortDic = new Dictionary<int, string>();
                newShortDic = dic;


                ICollection<int> keys = newShortDic.Keys;
                ICollection<string> names = newShortDic.Values;

                foreach (var item in keys)
                {
                    Console.WriteLine("Upon deliting collection conteins: ID: {0}  Name: {1}", item, newShortDic[item]);
                    if (newShortDic.Values == dic.Values)
                    {
                        Console.WriteLine(dic.Keys);
                    }
                }
            }


            return dic;


        }

    }
}


