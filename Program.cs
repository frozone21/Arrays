using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
                {
            //Handle errors 
            try
            {
                //To declare and intialize the array 
                int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
                        14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

                //Loop iteratres through the array 
                foreach (int i in numbers)
                {
                    //Display message with array value 
                    Console.WriteLine("The element value is: " + i);
                }
                Console.WriteLine("____________________________");
                // Display message after element values have been displayed 
                Console.WriteLine();
                Console.WriteLine("Press any key to exit the program...");

                //Pause the program and wait for the user to end 
                Console.ReadKey(true);
            }
            catch
            {
                Console.ReadKey(true);
            }
        }
    }
}
