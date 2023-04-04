using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 10:
                    Console.WriteLine("The number is 10.");
                    break;
                case 20:
                    Console.WriteLine("The number is 20");
                    break;
                case 30:
                    Console.WriteLine("The number is 30");
                    break;
                default:
                    Console.WriteLine("The number is unknown.");
                    break;       
            }
            */
            
            //calculator
            
            Console.WriteLine("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation: ");
            char op = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            double sonuc;
            
            switch (op)
            {
                case '*':
                    sonuc = num1 * num2;
                    Console.WriteLine("The result is {0}", sonuc);
                    break;
                case '/':
                    sonuc = num1 / num2;
                    Console.WriteLine("The result is {0}", sonuc);
                    break;
                case '+':
                    sonuc = num1 + num2;
                    Console.WriteLine("The result is {0}", sonuc);
                    break;
                case '-':
                    sonuc = num1 - num2;
                    Console.WriteLine("The result is {0}", sonuc);
                    break;
                default:
                    Console.WriteLine("Operator is unknown.");
                    break;
            }
        }
    }
}