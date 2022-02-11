using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string color;
            string animal;
            string band;
            int num1 = 4;
            int num2 = 7;
            
            

            
            Console.Write("What is your name?: ");
            name = Console.ReadLine();
            Console.Write($"Hi {name} what is your favorite color?: ");
            color = Console.ReadLine();
            Console.Write("What is your favorite animal?: ");
            animal = Console.ReadLine();
            Console.Write("What is your favorite band?: ");
            band = Console.ReadLine();
            
            Console.WriteLine($"My name is {name}, my favorite color is {color}, my favorite animal is a {animal}, and my favorite band is {band}. ");

            Sum(6,4);
            Subtract(4, 3);
            Multiply(12, 3);
            Divide(36, 12);
            
            
        }


        public static int Sum(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
            return num1 / num2;
        }
    }
}
