using System;
using System.Linq;
namespace myProgram
{
    class Program
    {
        static void Main(string[] args )
        {
            // Arrays are used to store multiple values in a single variable e.g. string[] cars;
            // to insert values into an array, we use an array literal

            string[] cars = { "Volvo " , "BMW" , "Mercedes" };
            int[] numbers = { 6 , 7 , 8 , 9, 10 };

            // changing values in an array: cars[0] = "Opel";
            // accessing values in arrays 

            Console.WriteLine(" My Favourite Car is: " + cars[0]);
            Console.WriteLine(" And my favourite number is: " + numbers[0] + numbers[1]);

            cars[0] = "Opel";
            Console.WriteLine(" And now my favourite car is: " + cars[0]);

            Console.WriteLine(" The Length of the cars array is: " + cars.Length);

            // Create an array of four elements, and add values later:
            // string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            // string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

            // Create an array of four elements without specifying the size 
            // string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

            //  Create an array of four elements, omitting the new keyword, and without specifying the size
            // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"}; (easier to read)


            // Looping through arrays:

            for ( int i = 0; i < cars.Length; i ++) // requires a counter (cars.Length)
            {
                Console.WriteLine(cars[i]);
            }

            // looping using foreach which is better to loop through arrays
            foreach (string i in cars) // foreach string element called i as in index in cars, print out the value of i
            {
                Console.WriteLine( "This loops through the array " + i);
            }

            // Sorting Arrays
            Array.Sort( cars );
            foreach (string i in cars)
            {
                Console.WriteLine("This sorts the names of the cars alphabetically " + i);
            }

            Array.Sort( numbers );
            foreach (int i in numbers)
            {
                Console.WriteLine("This sorts the numbers in an ascending order " + i);
            }

            Console.WriteLine("This is the largest value in the numbers array: " + numbers.Max()); // this returns the largest value
            Console.WriteLine("This is the Smallest value in the numbers array: " + numbers.Min()); // this returns the smallest value
            Console.WriteLine("This is the sum of the values in the numbers array: " + numbers.Sum()); // this returns the sum of the elements

            // Mutidimensional arrays are used to store data in a tabular format with rows and columns
            // Simply put, Multidimensional arrays are arrays of arrays

            // 2D arrays:

            int[,] myNumbers = { {1, 4 ,2} , {3, 6, 8} };

            // accessing elements of a 2D array
            // we must specify the row and column of the element we want to access

            Console.WriteLine("This is the Value of the element in the first row(ROW 0) and the third column(column 2) = " + myNumbers[0, 2]);

            // changing elements of a 2D array:

            myNumbers[0, 0] = 5;
            Console.WriteLine("Changing the first value of the array to:  " + myNumbers[0, 0]);

            // Looping through an array
            foreach (int i in myNumbers)
            {
                Console.WriteLine( "This is a Loop of the numbers in the 2d array :" + i);
            }

            // using for loop to loop through the numbers in the array:

            for (int i = 0; i < myNumbers.GetLength(0); i ++)
            {
                for (int j = 0; j < myNumbers.GetLength(1); j ++)
                {
                    Console.WriteLine(myNumbers[i, j]);
                }
            }
        }
    }
}