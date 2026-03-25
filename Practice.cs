using System;
namespace Practice
{
    class Practice
    {
        static void Main(string[] args)
        {
            /* Nested Loops

            for (int hour = 0; hour <= 12; ++hour)
            {
                Console.WriteLine(" Hour: " + hour);

                for (int min = 0; min <= 60; ++min)
                {
                    Console.WriteLine(" Minute: " + min);
                }
            } */

            // Using Break and Continue in loops:

            /*

            for ( int x = 0 ; x < 10 ; x ++ )
            {
                if ( x == 4 )
                {
                    continue ; // Executes the loop till x = 3, stops at 4 then continues from x = 5 till x = 10
                    
                    //break ;
                }

                Console.WriteLine( " x = " + x );
            }
            */

            int i = 0 ;
            while ( i < 10 )
            {
                Console.WriteLine(i);
                i ++ ;

                if ( i == 4)
                {
                    break ;
                    // continue ;
                }
            }

        }
    }
}