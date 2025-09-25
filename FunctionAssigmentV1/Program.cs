using System.Xml.Linq;

namespace FunctionAssigmentV1
{
    internal class Program
    {
        /// <summary>
        /// asks user for their name and validates the input
        /// </summary>
        /// <returns>returns valid input</returns>
        static string AskName()
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();
                else
                    Console.WriteLine("Name cannot be empty.");
            }
        }
        /// <summary>
        /// asks user for their age and validates the input
        /// </summary>
        /// <returns>returns valid input</returns>
        static int AskAge()
        {
            while (true)
            {
                Console.WriteLine("enter your age");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int age) && age > 0)
                    return age;

                Console.WriteLine("please enter a positive integer");
            }
        }
        /// <summary>
        /// prints name and age
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static void PrintNameAndAge(string name, int age)
        {
            Console.WriteLine($"your name is {name} and your age is {age}");
        }
        /// <summary>
        /// checks if user is of legal age
        /// </summary>
        /// <param name="age"></param>
        /// <returns> returns legal age</returns>
        static bool TarkistaOnkoTäysiikäinen(int age)
        {
            return age >= 18;
        }
        /// <summary>
        /// compares name to string
        /// </summary>
        /// <param name="name"></param>
        /// <param name="compareTo"></param>
        static void VertaaNimeä(string name, string compareTo)
        {
            if (name.Equals(compareTo, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");
            }
        }
        static void Main(string[] args)
        {
            // Everything is intentionally inside Main before refactoring to functions
            //Your job is to refactor this code to use functions for better readability and reusability.
            //Check learn on how to do this
            string name = AskName();
            int age = AskAge();

            PrintNameAndAge(name, age);
            bool IsFullAge = TarkistaOnkoTäysiikäinen(age);
            
            if (IsFullAge)
            {
                Console.WriteLine("you are an adult");
            }
            else
            {
                Console.WriteLine("you are not an adult");

                VertaaNimeä(name, "matti");
            }

            
        }
    }
}