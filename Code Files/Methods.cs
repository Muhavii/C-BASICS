using System;
namespace Meth
{
    class Meth
    {
        static string Griffins(string nickName, string nickName2) // return type string
        {

            return nickName + nickName2;
        }

        static int Big(int age)
        {
            return age;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("My two nicknames are: " + Griffins("Griffo ", "Haviee"));
            Console.WriteLine("And my Age is: " + Big(21));
        }
    }
}