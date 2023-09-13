using System;
using System.Collections.Generic;

namespace BalancedBracketsNS
{
    
   
        public static class BalancedBrackets
        {
            public static bool HasBalancedBrackets(string input)
            {
                if (string.IsNullOrEmpty(input))
                {
                    return true; // An empty string is considered balanced.
                }

                Stack<Char> stack = new Stack<Char>();

                foreach (Char character in input)
                {
                    if (character == '[')
                    {
                        stack.Push(character);
                    }
                    else if (character == ']')
                    {
                        if (stack.Count == 0 || stack.Pop() != '[')
                        {
                            return false; // Mismatched or unmatched closing bracket
                        }
                    }
                    // Ignore non-bracket characters
                }

                return stack.Count == 0; // All brackets are matched.
            }
        }
    }
