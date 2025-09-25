using System.Security.Cryptography;

namespace calculator
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int laskutoimitus = AskCalculation();

            double firstNumber = AskNumberDouble("Syötä ensimmäinen luku:");
            double secondNumber = AskNumberDouble("Syötä toinen luku:");

            double? result = Calculate(laskutoimitus, firstNumber, secondNumber);

            if (result != null)
            {
                Console.WriteLine($"tulos: {result}");
            }

        }
        /// <summary>
        /// kysyy käyttäjältä mitä laskutoimitusta käyttäjä haluaa käyttää
        /// </summary>
        /// <returns>palauttaa minkä numeron käyttäjä on valinnut 1-4</returns>
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
        /// <summary>
        /// kysyy numeron käyttäjältä ja tarkistaa että se on validi
        /// </summary>
        /// <param name="question"></param>
        /// <returns>palauttaa millä numeroilla käyttäjä haluaa laskea</returns>
        static double AskNumberDouble(string question)
        {
            while (true)
            {
                Console.Write(question + " ");
                string? input = Console.ReadLine();
                if (double.TryParse(input, out double number))
                {
                    return number;
                }
                Console.WriteLine("Virheellinen syöte, yritä uudelleen");
            }

        }
        /// <summary>
        /// valitsee millä laskimella laskee ja tarkistaa että ei yritetä jakaa nollalla
        /// </summary>
        /// <param name="laskutoimitus"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>vastaukesen käyttäjälle</returns>

        static double? Calculate(double laskutoimitus, double a, double b)
        {
            switch (laskutoimitus)
            {
                case 1: return Add(a, b);
                case 2: return Subtract(a, b);
                case 3: return Multiply(a, b);
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("Nollalla ei voi jakaa");
                        b = AskNumberDouble("syötä toinen luku");
                    }
                    return Divide(a, b);
                default:
                    Console.WriteLine("Tuntematon laskutoimitus");
                    return null;
                    
            }

        }
        /// <summary>
        /// laskimet 
        /// </summary>       
        /// <returns>laskee vastauksen Calculate funktiolle</returns>
        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide (double a , double b) => a / b;


    }
}
