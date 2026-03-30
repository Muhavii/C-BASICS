using System;
namespace Calculator 
{
    class Calc
    {
        static void Main(string[] args)
        {
            double result = 0;

            Console.WriteLine("Enter Your First Value: ");
            int firstValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your arithmetic operator (+,-,*,/,%): ");
            char operatorChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("Enter Your Second Value: ");
            int secondValue = Convert.ToInt32(Console.ReadLine());

            switch (operatorChoice)
            {
                case '+':
                result = firstValue + secondValue;
                Console.WriteLine(" The Sum of " + firstValue +  " and " + secondValue + " is equal to: " + result);
                break;

                case '-':
                result = firstValue - secondValue;
                Console.WriteLine(" The subtraction of " + firstValue + " and " + secondValue + " is equal to: " + result);
                break;

                case '/':
                 if (secondValue == 0)
                {
                    Console.WriteLine(" Error: Cannot divide by zero ");
                    break;
                }
                result = firstValue / secondValue;
                Console.WriteLine(" The division of " + firstValue + " and " + secondValue + " is equal to: " + result);
                break;

                case '*':
                result = firstValue * secondValue;
                Console.WriteLine(" The multiplication of " + firstValue + " and " + secondValue + " is equal to: " + result);
                break;

                case '%':
                if (secondValue == 0)
                {
                    Console.WriteLine(" Error: Cannot Modulo by zero ");
                    break;
                }
                result = firstValue % secondValue;
                Console.WriteLine(" The modulo of " + firstValue + " and " + secondValue + " is equal to: " + result);
                break;

                default:
                Console.WriteLine(" Syntax Error! ");
                break;
            }

    }
    }
}