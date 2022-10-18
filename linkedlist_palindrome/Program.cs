using System;
using System.Collections.Generic;

namespace linkedlist_palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var list_a = new LinkedList<int>();
            list_a.AddLast(1);
            list_a.AddLast(2);
            list_a.AddLast(3);
            list_a.AddLast(2);
            list_a.AddLast(1);

            LinkedListPalindromeSum.Test(list_a);
            LinkedListPalindromeStack.Test(list_a);


            var list = new LinkedList<int>();
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(6);
            list.AddLast(5);
            list.AddLast(4);

            LinkedListPalindromeSum.Test(list);
            LinkedListPalindromeStack.Test(list);
        }
    }

    class LinkedListPalindromeSum {

        public static void Test(LinkedList<int> list) 
        {
            var sum = 0;
            var current = 0;
            var mid = 0;

            foreach (var i in list)
            {
                if (i > current)
                {
                    current = i;
                    sum += i;

                } else if (i == current) {
                    mid += current;
                } else {

                    if (mid == 0) {
                        mid = current;
                    }

                    current = i;
                    sum -= i;
                }
            }

            sum -= mid;

            if (sum == 0)
                Console.WriteLine("IsPalindrome by sum method");
        }
    }

    class LinkedListPalindromeStack
    {
        public static void Test(LinkedList<int> list)
        {
            var stack = new Stack<int>();

            foreach (var i in list)
            {
                stack.Push(i);
            }

            foreach (var i in list)
            {
                if (stack.Pop() != i)
                    return;
            }

            Console.WriteLine("IsPalindrome by stack method");
        }
    }
}
