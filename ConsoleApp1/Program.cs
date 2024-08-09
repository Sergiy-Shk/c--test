using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static long FaktorialCalc(int num)
        {
            long result = 1;
            for (int i = 1; i < num + 1; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie die Zahl für die Fakultatsberechnung ein: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine($"Die Fakultät der eingegebenen Zahl ´{number}´ ist: {FaktorialCalc(number)}\n");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
            }


        }
    }
}
