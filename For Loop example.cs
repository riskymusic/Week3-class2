using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
            //Name: Tama Owens 
            //Task: For Loop
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("******For Loop Example*******");
            Console.WriteLine("*****************************");

            int limit = 10;

            /*Statement 1 - Create or initialise the counter*/
            /*Statement 2 - Set the conditions for how long the counter will run*/
            /*Statement 3 - increment or decrement the counter at the end of each loop*/

            for (int counter = 1; counter <= limit; counter++)
            {
                Console.WriteLine("loop " + counter);
            }
            Console.ReadLine();

        }
    }
}
