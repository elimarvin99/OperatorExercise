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

            const double pi = 3.14;
            double radius;
            bool repeat = false;
            do
            {
                Console.WriteLine("What is the radius of your circle?");
                repeat = double.TryParse(Console.ReadLine(), out radius);
            } while (!repeat);

            double area = pi * (radius * radius); //radius * radius is in paranteses because of order of operations
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");
            
        }
    }
}
