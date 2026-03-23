using System;
namespace Practice
{
    class Prac
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 12; ++hour)
            {
                Console.WriteLine(" Hour: " + hour);

                for (int min = 0; min <= 60; ++min)
                {
                    Console.WriteLine(" Minute: " + min);
                }
            }
        }
    }
}