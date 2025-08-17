using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Stack
{
    // Problem: Given a string s containing just the character '(', ')',
    // '[', ']', '{', '}', determine if the input string is valid.

    // An input string is valid if:
    // 1. Open brackets must be closed by the same type of brackets.
    // 2. Open brackets must be closed in the correct order.
    // 3. Every close bracket has a corresponding open bracket of the same type.

    // Example 1:
    // Input: s = "()"
    // Output: true

    // Example 2:
    // Input: s = "()[]{}"
    // Output: true

    // Example 3:
    // Input: s = "(]"
    // Output: false

    // Example 4:
    // Input: s = "([])"
    // Output: true

    // Example 5:
    // Input: s = "([)]"
    // Output: false
    public class ValidParentheses
    {
       // Time Complexity: O(N)
       // Space Complexity: O(N)
        public bool IsValidParentheses(string s)
        {
            if(s.Length % 2 != 0) return false;

            Stack<char> stack = new Stack<char>();

            foreach(char c in s.ToCharArray())
            {
                if(c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if(c == ')' && stack.Count != 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if(c == ']' && stack.Count != 0 && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if(c == '}' && stack.Count != 0 && stack.Peek() == '}')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }
    }
}
