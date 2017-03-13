using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab2
{
    class Program
    {
        static void F1()
        {
            while (true)
            {
                Console.WriteLine(new string(' ',10)+"Salut");
            }
        }
        static void Main()
        {
            ThreadStart F12 = new ThreadStart(F1);
            Thread thread = new Thread(F1);
            thread.Start();

            while(true)
            {
                Console.WriteLine("Roman");
            }

            Console.ReadKey();
        }
    }
}
