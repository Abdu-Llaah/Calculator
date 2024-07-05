using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num;
            float num1;
            float result;

            string answer;
            Console.WriteLine("Hello Welcome To The calculator Program");
            Console.WriteLine("Please enter you first number");

            num = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("What kind of operation will you like to do?");
            Console.WriteLine("Please enter a for addition, s for subtraction, d for division, m for multiplication");

            answer = Console.ReadLine().ToLower();

            

            if (answer == "a")
            {
                result = num + num1;
            }
            else if (answer == "s")
            {
                result = num - num1;
            }
            else if (answer == "d")
            {
                result = num1 == 0 ? float.NaN: num / num1;
            }
            else
            {
                result = num * num1;
            }

            if (float.IsNaN(result))
            {
                Console.WriteLine("Can not divide by Zero!");
            }
            else
            {
                Console.WriteLine("The result is:" + result);
            }



            
            
            Console.WriteLine("Thank You for using this calculator!");




                    Console.ReadKey();//To make the app pause before closing 
            Console.Beep();
        }

    }
}
