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


            Console.Write("What is your name?: ");
            name = Console.ReadLine();
            Console.Write($"Hi {name} what is your favorite color?: ");
            color = Console.ReadLine();
            Console.Write("What is your favorite animal?: ");
            animal = Console.ReadLine();
            Console.Write("What is your favorite band?: ");
            band = Console.ReadLine();


            Console.Write($"My name is {name}, my favorite color is {color}, my favorite animal is {animal}, and my favorite band is {band}. ");
        }
    }
}
