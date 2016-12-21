using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            list.Add(4);
            list.Add(4);
            list.Add(5);
            list.Add(4);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 5)
                {
                    list.Add(6);
                }

                Console.WriteLine(list[i]);
            }

            Console.ReadKey();
        }
    }
}
