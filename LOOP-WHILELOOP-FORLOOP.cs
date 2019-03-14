using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        //Name : Tama Owens 
        //Exercise Task 1
        static void Main(string[] args)
        {
            int start = 3;
            int finish = 20;
            Console.WriteLine(">>>FOR LOOP<<<");
            Console.WriteLine(" N\t\tN*10\t\tN*100\t\tN*1000");
            for (int i = start; i <= finish; i++)
            {
                Console.WriteLine($" {i}\t\t{i * 10}\t\t{i * 100}\t\t{i * 1000}");
            }
            Console.WriteLine("End of loop......");

            int counter = 1;
            finish = 7;
            while (counter <= finish)

            {



                Console.WriteLine($" {counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}");
                counter++;


            }
            Console.WriteLine("End of the while loop");
            counter = 3;
            do
            {
                Console.WriteLine($" {counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}");
                counter++;
            } while (counter <= finish);
            Console.ReadLine();

            //Time Table
            {
                start = 1;
                finish = 12;
                Console.WriteLine(">>>>For Loop<<<<");
                for (int t = start; t <= finish; t++)
                {
                    Console.WriteLine($" {t} x 7 = {t*7}");
                }
                Console.ReadLine();
            }

        







        }
    }
}
