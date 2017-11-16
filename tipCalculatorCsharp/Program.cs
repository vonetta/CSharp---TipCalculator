using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipCalculatorCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            do
            {
                Console.WriteLine("Enter Bill Amount");
                var input = Convert.ToInt32(Console.ReadLine()); //store user input

                //double bill = double.Parse(input); //convery to a number

                for (double i = 10; i <= 20; i++)
                {
                    //  Console.WriteLine( i + "% of $" + input + " = " + (input * (i/100)));
                    Console.WriteLine("{0} % of {1:c} = {2:c}", i, input, (input * (i / 100)));
                }
                Console.Write("Continue? y/n");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "y");
           Console.ReadLine();
        }
    }
}
