using System;
namespace Work
{
    class Work
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your hours worked: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            if (hours <= 0 || hours > 12)
            {
                Console.WriteLine("You entered an invalid amount of work hours, please try again. ");
            }

            else if (hours >= 8)
            {
                Console.WriteLine("Your salary for today is: 3500");
            }

            else if (hours >= 6)
            {
                Console.WriteLine("Your Salary for today is: 2500");
            }

            else if (hours >= 4)
            {
                Console.WriteLine("Your Salary for today is: 1500");
            }

            else if (hours >= 2)
            {
                Console.WriteLine("Your Salary for today is: 500");
            }
        }
    }
}