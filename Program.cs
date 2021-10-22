using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;

            int remainder = a % b;

            Console.WriteLine($"{a} / {b} = {quotient} remainder {remainder}");

            // area of circle 

            const decimal pi = 3.1415m;
            Console.WriteLine("What is the radius of your circle?");
            var radius = decimal.Parse(Console.ReadLine());
            decimal area = pi * radius * radius;
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");
            
        }
    }
}
