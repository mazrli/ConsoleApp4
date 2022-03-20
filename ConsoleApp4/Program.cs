using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeigtCalcuator weigtCalcuator = new WeigtCalcuator
            {
                Height = 180,
                Sex = 'm'

            };

            double weight = weigtCalcuator.GetIdealBodyWeight();

            Console.WriteLine($"Ditt ideal Body Weight is: {weight}");

            if (weight == 72.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tests succeed");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tests failed!!!");
            }






            weigtCalcuator.Sex = 'W';
            weight = weigtCalcuator.GetIdealBodyWeight();

            if (weight == 72.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tests succeed");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tests failed!!!");
            }

            Console.ReadKey();




        }
    }
}
