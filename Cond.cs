using System;
namespace Conditions
{
    class myConditions
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hello, Welcome to this mini game ");
            Console.WriteLine(" To start, please type 'Start' ");
            string input = Console.ReadLine();

            if (input == "Start")
            {
                Console.WriteLine("Okay, Perfect! Let's Begin");
            }
        }
    }
}