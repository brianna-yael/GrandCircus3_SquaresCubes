using System;

namespace labThree
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Learn your squares and cubes! Enter an integer:");
                int input = int.Parse(Console.ReadLine());

                for (int i = 0; i <= input; i++)
                {
                    Console.WriteLine(string.Format("{0,-10} {1,-10} {2}", "Number", "Squared", "Cubed"));
                    Console.WriteLine(string.Format("{0,-10} {1,-10} {2}", i, (i * i), (i * i * i)));
                }
                run = Continue();
            }

        }
        public static bool Continue()
        {
            Console.WriteLine("Do you wish to Continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }

            return goOn;
        }
    }
}
