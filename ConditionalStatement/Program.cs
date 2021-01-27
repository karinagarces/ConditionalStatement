using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade will you get?");
            String userInput = Console.ReadLine(); // Get Input
            int grade = int.Parse(userInput); // Convert to integer value
            if (grade >= 98 )
            {
                Console.WriteLine("A+");
            }
            else if (grade >=92&& grade <98)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 90 && grade < 92)
            {
                Console.WriteLine("A-");
            }
            else if (grade >= 88 && grade < 90)
            {
                Console.WriteLine("B+");
            }
            else if (grade >= 82 && grade < 88)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 80 && grade < 82)
            {
                Console.WriteLine("B-");
            }
            else if (grade >= 78 && grade < 80)
            {
                Console.WriteLine("C+");
            }
            else if (grade >= 72 && grade < 78)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 70 && grade < 72)
            {
                Console.WriteLine("C-");
            }
            else if (grade >= 68 && grade < 70)
            {
                Console.WriteLine("D+");
            }
            else if (grade >= 62 && grade < 68)
            {
                Console.WriteLine("D");
            }
            else if (grade >= 60 && grade < 62)
            {
                Console.WriteLine("D-");
            }
            else
            {
                Console.WriteLine("F");
            }
            Console.ReadKey(true);

        }
    }
}
