using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statues
{
    class Program
    {
        static void Main(string[] args)
        {
            int stats = 0;
            int[] statues = { 2, 4, 7, 6 };
            Array.Sort(statues);

            Console.WriteLine("statues[0] = " + statues[0]);
            Console.WriteLine("statues[1] = " + statues[1]);

            for (int i = 0; i < statues.Length - 1; i++)
            {
                for (int a= statues[i]; statues[i + 1] - a != 1; a++)
                {
                    stats += 1;
                }
            }
            Console.WriteLine("stats = " + stats);
            Console.ReadKey();
        }

        /*int makeArrayConsecutive2(int[] statues)
        {
            int stats = 0;
            Array.Sort(statues);

            for (int i = 0; i < statues.Length - 1; i++)
            {
                for (int a = statues[i]; statues[i + 1] - a != 1; a++)
                {
                    stats += 1;
                }
            }
            return stats;
        }*/
    }
}
