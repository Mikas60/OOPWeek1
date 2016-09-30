using System;
using System.Windows;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] response = new string[10];

            for(int i = 0; i < 10; i++)
            {
                response[i] = Question();
            }

            Console.WriteLine();

            foreach(string i in response)
            {
                Console.WriteLine(i);
            }
        }

        public static string Question()
        {
            string response = "";

            Console.WriteLine("Please enter A, B or C to select from the following flavores:");
            Console.WriteLine("A - Vanilla");
            Console.WriteLine("B - Strawberry");
            Console.WriteLine("C - Chocolate");
            response = Console.ReadLine();
            return response;
        }
    }
}
