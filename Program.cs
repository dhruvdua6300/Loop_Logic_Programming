using System;

namespace Loop_Logic_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience do you have in professional programming?");

            try
            {
                int value_of_input = int.Parse(Console.ReadLine());
                for (int i = 1; i <= value_of_input; i++) 
                {
                    Console.WriteLine("You have {0} years of experience",value_of_input);

                }
                Console.ReadKey(true);
            }

            catch
            {
                Console.WriteLine("only integers");
                Console.ReadKey(true);
            }
        }
    }
}
