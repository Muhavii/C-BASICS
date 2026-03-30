using System;
namespace Prac
{
    class Prac
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Enter a valid score within the parameter!");
            }

            if (marks >= 70)
            {
                Console.WriteLine("Congrats! You got an A! ");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("This is good! you got a B! ");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("You got a C ");
            }
            else if (marks >= 40)
            {
                Console.WriteLine("You got a D ");
            }
        }
    }
}
