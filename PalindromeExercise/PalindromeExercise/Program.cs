using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var pali = new WordSmith();

            Console.WriteLine("Please enter a palindrome:");
            var userPali = Console.ReadLine();

            var result = pali.IsAPalindrome(userPali);

            Console.WriteLine(result ? $"{userPali} is a palindrome!" : $"{userPali} is not a palindrome, try again!");



        }
    }
}
