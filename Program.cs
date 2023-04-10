using System;

namespace Methods_Hutton_Riley
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user to enter 2 whole numbers 
            Console.WriteLine("Please enter a whole number!");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another whole number!");
            int y = Convert.ToInt32(Console.ReadLine());

            //Multiplies the users numbers
            Console.WriteLine(Multiply(x,y));

            //Asks the user their name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            WelcomeUser(name);

            Goodbye();
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username}! It is nice to meet you!");
        }
        /// <summary>
        /// Prints a goodbye message to the console
        /// </summary>
        static void Goodbye()
        {
            Console.WriteLine("Have a fantastic day!");
        }

    }
}
