using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hw1

{
    class PalindromeChecker
    {
        static void Main()
        {
            List<string> originalStrings = new List<string>();
            List<string> reversedStrings = new List<string>();
            List<bool> palindromeResults = new List<bool>();

            Console.WriteLine("PALINDROME CHECKER");
            Console.WriteLine("Enter strings to check for palindromes.");
            Console.WriteLine("Type '*' to stop and see results.\n");

            string input;

       
            while (true)
            {
                Console.Write("Enter a string: ");
                input = Console.ReadLine();

           
                if (input == "*")
                {
                    break;
                }

           
                originalStrings.Add(input);

           
                string reversed = ReverseString(input);
                reversedStrings.Add(reversed);

               
                bool isPalindrome = IsPalindrome(input);
                palindromeResults.Add(isPalindrome);
            }

         
            Console.WriteLine("\n=== RESULTS ===");
            Console.WriteLine("Original String\t\tReversed String\t\tPalindrome?");
           

            for (int i = 0; i < originalStrings.Count; i++)
            {
                string original = originalStrings[i];
                string reversed = reversedStrings[i];
                string result = palindromeResults[i] ? "YES" : "NO";

                Console.WriteLine($"{original,-20}\t{reversed,-20}\t{result}");
            }

            Console.WriteLine("\nProgram terminated. Press any key to exit...");
            Console.ReadKey();
        }


        static string ReverseString(string str)
        {
            string reversed = "";

        
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            return reversed;
        }

     
        static bool IsPalindrome(string str)
        {
            string lowerStr = str.ToLower();

            int left = 0;
            int right = lowerStr.Length - 1;

            while (left < right)
            {
                if (lowerStr[left] != lowerStr[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }



    }
}
