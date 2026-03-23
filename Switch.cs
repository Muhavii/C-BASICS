using System;
namespace Origin
{
    class swissCheese
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter any day of the week ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                Console.WriteLine(" This is day 1 ");
                break;

                case "Tuesday":
                Console.WriteLine(" This is day 2 ");
                break;

                case "Wednesday":
                Console.WriteLine(" This is day 3 ");
                break;

                case "Thursday":
                Console.WriteLine(" This is day 4 ");
                break;

                case "Friday":
                Console.WriteLine(" This is day 5 ");
                break;

                case "Saturday":
                Console.WriteLine(" This is day 6 ");
                break;

                case "Sunday":
                Console.WriteLine(" This is day 7 ");
                break;

                default:
                Console.WriteLine(" Please Enter a valid day of the week ");
                break;
            }
        }
    }
}