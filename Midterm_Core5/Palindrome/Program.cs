using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your string");
            string rawInput = Console.ReadLine();
            string cleanInput = "";
            foreach (char c in rawInput)
                if (Char.IsLetter(c))
                {
                    cleanInput = cleanInput + c;
                }
            cleanInput = cleanInput.ToLower();
            Console.WriteLine(cleanInput);
            if (IsPalindrome(cleanInput) == true)
                Console.WriteLine(rawInput + " is a palindrome.");
            else
                Console.WriteLine(rawInput + " is not a palindrome.");


        }

        static bool IsPalindrome(string userIn)
        {
            string dequeuedWord = "";
            string unstackedWord = "";
            Stack<char> wordStack = new Stack<char>();
            Queue<char> wordQueue = new Queue<char>();
            foreach (char c in userIn)
            {
                wordStack.Push(c);
                wordQueue.Enqueue(c);
            }

            foreach (char c in userIn)
            {
                unstackedWord = unstackedWord + wordStack.Pop();
                dequeuedWord = dequeuedWord + wordQueue.Dequeue();
            }
            if (unstackedWord == dequeuedWord)
                return true;
            else
                return false;
            

            
        }

        
    }


}
