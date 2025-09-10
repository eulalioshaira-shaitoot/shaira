using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List");
            Console.WriteLine();

            Console.Write("Enter row: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter col: ");
            int cols = int.Parse(Console.ReadLine());

            List<List<double>> matrix = new List<List<double>>();

            for (int i = 0; i < rows; i++)
            {
                matrix.Add(new List<double>());
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Row {i + 1}");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter number {j + 1}: ");
                    double number = double.Parse(Console.ReadLine());
                    matrix[i].Add(number);
                }
            }

            Console.WriteLine();
            Console.WriteLine("The numbers are:");

            double sum = 0;
            int totalElements = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                    sum += matrix[i][j];
                    totalElements++;
                }
                Console.WriteLine();
            }

            double average = sum / totalElements;

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum} ; Average: {average:F2}");

            Console.WriteLine();
         
            Console.ReadKey();
        }
    }
}
