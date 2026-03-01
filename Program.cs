namespace SonyConsoleApplication
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Addition: " + Add(firstNumber, secondNumber));
            // Console.WriteLine("Subtraction: " + Subtract(firstNumber, secondNumber));
            // Console.WriteLine("Multiplication: " + Multiply(firstNumber, secondNumber));
            Console.WriteLine("Division: " + Divide(firstNumber, secondNumber));
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0; 
            }
            return a / b;
        }

    }
}