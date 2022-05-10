using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your string");
        }

        static void IsPalindrome(string userIn)
        {
            Stack<char> wordStack = new Stack<char>();
            Queue<char> wordQueue = new Queue<char>();
            foreach (char c in userIn)
            {
                wordStack.Push(c);
                wordQueue.Enqueue(c);
            }

            foreach (char c in userIn)
            {
                string dequeuedWord = "";
                string unstackedWord = "";
                unstackedWord = unstackedWord + wordStack.Pop();
                dequeuedWord = dequeuedWord + wordQueue.Dequeue();
                if (unstackedWord == dequeuedWord)
                    return true;
                else
                    return false;
            }
            

            
        }

        
    }


}
