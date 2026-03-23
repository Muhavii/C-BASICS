using System;
namespace condition
{
    class Cond
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Your Day of the week: ");
            string day = Console.ReadLine();

            if (day == "Monday")
            {
                Console.WriteLine(" This is day 1 ");
            }
            
            else if (day == "Tuesday")
            {
                Console.WriteLine(" This is day 2 ");
            }

            else if (day == "Wedneday")
            {
                Console.WriteLine(" This is day 3 ");
            }

            else if (day == "Thursday")
            {
                Console.WriteLine(" This is day 4 ");
            }

            else if (day == "Friday")
            {
                Console.WriteLine(" This is day 5 ");
            }

            else if (day == "Saturday")
            {
                Console.WriteLine(" This is the weekend ");
            }

            else if (day == "Sunday")
            {
                Console.WriteLine(" This is day 7 ");
            }

            else
            {
                Console.WriteLine(" Error, please input the valid day of the week ");
            }
        }
    }
}