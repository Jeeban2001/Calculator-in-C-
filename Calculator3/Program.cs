using System;

namespace calc1
{
    class Program
    {

        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            Console.WriteLine("\t\t\t----------------------");
            Console.WriteLine("\t\t\tCALCULATOR BY JJN");
            Console.WriteLine("\t\t\t----------------------");
            Console.WriteLine("\t\t\tEnter first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t\t\tEnter second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t\t\t1.+:ADDITION");
            Console.WriteLine("\t\t\t2.-:SUBSTRACTION");
            Console.WriteLine("\t\t\t3.*:MULTIPLICATION");
            Console.WriteLine("\t\t\t4./:DIVISION");

            switch (Console.ReadLine())
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"\t\t\tAddition is:{num1}+{num2}=" + result);
                    break;
                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"Substraction is:{num1}-{num2}=" + result);
                    break;
                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"Multiplication is:{num1}*{num2}=" + result);
                    break;
                case "4":
                    result = num1 / num2;
                    Console.WriteLine($"Division is:{num1}/{num2}=" + result);
                    break;
                default:
                    Console.WriteLine("Invalid value choosen!!");
                    Console.WriteLine("Try again.");
                    break;
            }
            Console.WriteLine("Thanks for using us.");
            Console.ReadKey();

        }
    }
}
