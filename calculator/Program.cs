using System.Security.Cryptography;

namespace calculator
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int laskutoimitus = AskCalculation();

            int firstNumber = AskNumber("Syötä ensimmäinen luku:");
            int secondNumber = AskNumber("Syötä toinen luku:");


        }
        static int AskCalculation()
        {
            while (true)
            {
                Console.WriteLine("Valitse laskutoimius (1: yhteenlasku, 2: vähennyslasku, 3: kertolasku, 4: jakolasku):");
                string? input = Console.ReadLine();
                int.TryParse(input, out int Method);
                if (Method == 1)
                {
                    return Method;
                }
                else if (Method == 2)
                {
                    return Method;
                }
                else if (Method == 3)
                {
                    return Method;
                }
                else if (Method == 4)
                {
                    return Method;
                }
                else
                {
                    Console.WriteLine("syötä yksi numero 1-4 välillä");
                }

            }
        }
        static int AskNumber(string question)
        {
            while (true)
            {
                Console.Write(question + " ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                Console.WriteLine("Virheellinen syöte, yritä uudelleen");
            }

        }


    }
}
