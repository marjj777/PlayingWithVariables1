using System;

namespace PlayingWithVariables1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            string myAge = Console.ReadLine();

            Console.WriteLine($"There was an extraordinary man named {userName}. He was {myAge} years old!");

            Console.WriteLine(" Give me a number to multiply");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine(" to the first");
            int Y = int.Parse(Console.ReadLine());

            int multiply  = Multiply(X, Y);
            Console.WriteLine($"The answer is {multiply}");
        }

        public static int Sum(params.int[])
        {
        int sum = num1 + num2;
           return sum;

            //OR return num1 + num2
        }

        public static int Multiply(int X, int Y)
        {
            return X * Y;
        }
    }
}
