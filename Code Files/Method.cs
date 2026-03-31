using System;
namespace Meth
{
    public class Meth
    {
        static void MyMethod(string fname, string lname , int age) //parameter
        {
            Console.WriteLine(fname + lname + " is " + age);
        }
        static int Mary(int x, int y) //Method with a return type
        {
            return x + y;
        }

        static string Justin(string wname, string hname)
        {
            return wname + hname;
        }

        // Naming Arguments

        static void Mehtod2(string friend1, string friend2, string friend3)
        {
            Console.WriteLine("My BestFriend is: " + friend3);
        }

        // Overloading Methods

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            MyMethod("Griffins" , " Muhavi", 21); //arguments
            MyMethod("Jefferey" , " Misigo" , 22);
            MyMethod("Callistus" , " Chepchumba" , 25);

            Console.WriteLine("The addition of 6 + 6 is: " + Mary(6, 6));
            Console.WriteLine("My colleague's name is: " + Justin("John", " Doe"));

            Mehtod2(friend3: "Jaqueline" , friend1: "Brian", friend2: "Bruce");

            // storing the result of the int and double in variables so that its easier to read
            
            int myNum1 = PlusMethod(6, 7);
            double myNum2 = PlusMethod(2.23, 23.23);

            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }

    }
}