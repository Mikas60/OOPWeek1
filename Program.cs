using System;
using System.Windows;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                int TotalCount = 0;
                string[] response = new string[10];

                for (int i = 0; i < 10; i++)
                {
                    response[i] = Question();
                }

                Console.WriteLine();

                foreach (string i in response)
                {
                    int OptA = 0;
                    int OptB = 0;
                    int OptC = 0;

                    if (i == "A" || "a")
                    {
                        OptA++;
                    }
                    else if (i == "B" || "b")
                    {
                        OptB++;
                    }
                    else if (i == "C" || "c")
                    {
                        OptC++;
                    }
                }

                Console.WriteLine("Number of people who want Vanilla: " + OptA);
                Console.WriteLine("Number of people who want Strawberry: " + OptB);
                Console.WriteLine("Number of people who want Chocolate: " + OptC);
                TotalCount++;

            } while (TotalCount <= 10 || OptA == 10 || OptB == 10 || OptC == 10);

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
