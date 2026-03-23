using System;
namespace loops
{
    class Loop
    {
        static void Main(string[] args)
        {
            /* while loop 
            int i = 0 ; 
            while ( i < 5 )
            {
                Console.WriteLine(i);
                i ++;
            } */

            /* do while loop

            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } 
            while ( i <= 5 );
               } */
            

            /* For Loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            } */

            /* Outer and Inner Nested Loops
            for (int i = 0; i <= 12; ++i)
            {
                Console.WriteLine(" Hour: " + i);

                //inner loop
                for (int j = 0; j <= 60; j++)
                {
                    Console.WriteLine(" Minute: " + j);
                }
                */

                // Breaking and Continuing Loops

                /*
                for ( int i = 0; i < 10; i++)
            {
                if ( i == 4 )
                {
                    break;
                }

                Console.WriteLine(i);
            } */

            /*

            for ( int i = 0; i < 10; i++)
            {
                if ( i == 4 )
                {
                    continue;
                }
                Console.WriteLine(i);
            } */

            

            }
        }
    }
