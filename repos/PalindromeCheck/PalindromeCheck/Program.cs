using System;

namespace PalindromeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to check palindrome: ");
            string input = Console.ReadLine();
            string reverse = string.Empty;
            for (int i = input.Length-1; i >= 0; i--)
            {
                reverse += input[i];
            }
            if (input == reverse)
            {
                Console.WriteLine("Palindrome"); 
            }
            else
            {
                Console.WriteLine("Not a Plaindrome");
            }
        }
    }
}