using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharFrequency
{
    class Program
    {
        static Dictionary<char, int> GetFrequency(string input)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in input.ToLower()) 
            {
                if (c == ' ' || c == ',')
                    continue;

                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }

            return freq;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter 1 or more strings separated by comma: ");
            string input = Console.ReadLine();
            string[] words = input.Split(',');

            foreach (string word in words)
            {
                string trimmedWord = word.Trim(); 
                Dictionary<char, int> frequency = GetFrequency(trimmedWord);

                List<string> parts = new List<string>();
                foreach (var kvp in frequency)
                {
                    parts.Add($"{kvp.Key}={kvp.Value}");
                }

                Console.WriteLine(string.Join(", ", parts));
            }
            Console.ReadKey();
        }
    }
}
