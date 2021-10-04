using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditonals3
{
    class Program
    {
        static bool alive = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals 3");

            if (alive == true)
            {
                Console.WriteLine("You are alive! :)");
            }
            else
            {
                Console.WriteLine("You are dead. :(");
            }




            Console.ReadKey(true);
        }

    }
}
