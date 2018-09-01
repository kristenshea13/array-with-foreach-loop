using System;

namespace single_line_array
{
    class Program
    {
        static void Main(string[] args)
        {


            //array with specific values initialized in one line
            int[] numbers = new int[] { 1, 1, 2, 3, 5, 8 };
            
            //loop that goes through and prints out each value in the array above
            foreach (int number in numbers)
            {
                Console.WriteLine($"Value: {number}");
            }

            Console.ReadLine();

        }
    }
}
