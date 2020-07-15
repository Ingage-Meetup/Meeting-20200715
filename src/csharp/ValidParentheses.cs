using System;

namespace ValidParentheses
{
    public class Challenge
    {
        //     Write a function, valid_parentheses(), that takes a string of parentheses, and determines if the order of the parentheses is valid.
        //         This function should return true if the string is valid, and false if it's invalid.        //         
        //
        //         Specification
        //         bool valid_parentheses(braces)
        //         // Checks if the parentheses order is valid
        //
        //     Parameters
        //         braces: string - A string representation of an order of parentheses
        //         // assume input string contains only open and/or closed parentheses
        //
        //         Return Value
        //         bool - Returns true if order of parentheses are valid, false otherwise
        //
        //         Examples:
        //     Input Output
        //     "()“			true
        //     ")(()))“		false
        //     "(“			false
        //     "(())((()())())“	true 
        //
        //
        //     Variations:
        //
        //     1. Using a loop and switch.
        //     2. Using a stack
        //     3. Using recursion

        public static bool ValidParentheses(string braces)
        {
            int left = 0, right = 0;
            bool valid = true;
            for (int i = 0; i < braces.Length; i++)
            {
                switch (braces[i])
                {
                    case '(':
                        left++;
                        break;
                    case ')':
                        right++;
                        break;
                    default:
                        System.Console.WriteLine($"Invalid input string: {braces}");
                        break;
                }
                if (right > left)
                {
                    valid = false;
                    break;
                }
            }
            if (left != right)
            {
                valid = false;
            }
            return valid;
        }
    }
}
