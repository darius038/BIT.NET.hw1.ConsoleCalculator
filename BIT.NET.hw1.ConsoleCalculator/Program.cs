using System;

namespace BIT.NET.hw1.ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Please enter operation, for eg.: 2 * 2");
                Console.WriteLine("Available operands: + - * / ^");
                Console.WriteLine("--------------------------------------");

                var input = Console.ReadLine();
                string[] inputArray = input.Split(' ');
                double answer;

                var num1 = Double.Parse(inputArray[0]);
                var num2 = Double.Parse(inputArray[2]);


                switch (inputArray[1])
                {
                    case "+":
                        answer = num1 + num2;
                        break;
                    case "-":
                        answer = num1 - num2;
                        break;
                    case "/":
                        answer = num2 == 0 ? 0 : num1 / num2;
                        break;
                    case "*":
                        answer = num1 * num2;
                        break;
                    case "^":
                        answer = Math.Pow(num1, num2);
                        break;
                    default:
                        answer = 0;
                        break;
                }

                Console.WriteLine(num1.ToString() + " " + inputArray[1] + " " + num2.ToString() + " = " + answer.ToString("0.00"));
                Console.WriteLine("\n Do You Want To Break (Y/y)");
                var status = Console.ReadKey();

                if (status.Key == ConsoleKey.Y)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
