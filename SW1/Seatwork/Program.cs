using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeAndCurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers separated by space: ");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            Console.WriteLine();
            for (int i = 0; i < parts.Length; i++)
            {
                int num = int.Parse(parts[i]);
                bool prime = IsPrime(num);

                Console.WriteLine($"{i + 1}.  {num}\t\t{(prime ? "Prime" : "Composite")}");
            }

            Console.WriteLine();

            Console.Write("Enter currency in ($) separated by comma: ");
            string dollarInput = Console.ReadLine();

            string[] dollarParts = dollarInput.Split(',');

            Console.WriteLine();
            Console.WriteLine("Dollar($)\tPhil Peso(P)\tJpn Yen (Y)");
            
            foreach (string d in dollarParts)
            {
                double dollars = double.Parse(d.Trim()); 
                (double peso, double yen) = ConvertCurrency(dollars);

                Console.WriteLine($"{dollars}\t\t{peso:F2}\t\t{yen:F2}");
             
            }
            Console.ReadKey();
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        static (double, double) ConvertCurrency(double dollars)
        {
            double peso = dollars * 57.17;
            double yen = dollars * 146.67;
            return (peso, yen);
        }
    }
}
