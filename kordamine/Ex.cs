using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
    class Ex
    {
        public static void Main(string[] args)
        {
            /*int mult = 1;
             int sum = 0;
            for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine("Number");
                  int set = Convert.ToInt32(Console.ReadLine());
                  sum += set;
                  mult = set + mult;
            }
             double avg = sum / 5;
              Console.WriteLine($"Nums AVG = {avg}\nNums SUM = {sum}\nNums multipiled = {mult}");
              */
            Console.WriteLine("---------------------------------");
            string text;
            do

            {

                Console.WriteLine("Osta elevant ära!");

                text = Console.ReadLine();

            } while (text != "elevant");
            Console.WriteLine("Elevant");

            Console.WriteLine("---------------------------------");

            Random rand = new Random();
            int a = rand.Next(1, 10);

            int r = 0;
            int quet;
            do
            {
                Console.Write("Write the number");
                quet = Convert.ToInt32(Console.ReadLine());
                if (r==5)
                {
                    break;
                }
            } while (quet != a);

  

            Console.ReadLine();
        }
    }
}
