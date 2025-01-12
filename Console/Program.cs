﻿using System;

namespace GithubActionsLab
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Quick Calculator");
            var loop = true;
            while (loop)
            {
                try
                {
                    Func<string, string, double> operation = null;
                    Console.WriteLine("1) Add (x+y)");
                    Console.WriteLine("2) Subtract (x-y)");
                    Console.WriteLine("3) Multiply (x*y)");
                    Console.WriteLine("4) Divide (x/y)");
                    Console.WriteLine("5) Power (x^y)");
                    Console.WriteLine("6) Quit");
                    var operationSelection = GetInput("Select your operation: ");
                    switch (operationSelection)
                    {
                        case "1":
                            operation = Add;
                            break;
                        case "2":
                            operation = Subtract;
                            break;
                        case "3":
                            operation = Multiply;
                            break;
                        case "4":
                            operation = Divide;
                            break;
                        case "5":
                            operation = Power;
                            break;
                        case "6":
                            loop = false;
                            continue;
                        default:
                            throw new ArgumentException("You did not select a valid option!");
                    }

                    var x = GetInput("Enter x: ");
                    var y = GetInput("Enter y: ");
                    var result = operation(x, y);
                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().Trim();
        }

        public static double Add(string x, string y)
        {
            return double.Parse(x) + double.Parse(y);
        }

        public static double Subtract(string x, string y)
        {
            return double.Parse(x) - double.Parse(y);
        }
        public static double Multiply(string x, string y)
        {
            return double.Parse(x) * double.Parse(y);
        }
        public static double Divide(string x, string y)
        {
            return double.Parse(x) / double.Parse(y);
        }

        public static double Power(string num1, string num2)
		{
			double n1, n2;

			if (double.TryParse(num1, out n1) && double.TryParse(num2, out n2))
		{
			return Math.Pow(n1, n2);
		}

			return 0;
		}
		public static int Addition(string a, string b)
		{
			int x = int.Parse(a);
			int y = int.Parse(b);
			return x + y;
		}

		public static int Subtraction(string a, string b)
		{
			int x = int.Parse(a);
			int y = int.Parse(b);
			return x - y;
		}

		public static int Multiplication(string a, string b)
		{
			int x = int.Parse(a);
			int y = int.Parse(b);
			return x * y;
		}

		public static int Division(string a, string b)
		{
			int x = int.Parse(a);
			int y = int.Parse(b);
			return x / y;
		}

		public static int Modulo(string a, string b)
		{
			int x = int.Parse(a);
			int y = int.Parse(b);
			return x % y;
		}
    }
}
