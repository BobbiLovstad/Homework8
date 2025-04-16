using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Written By Bobbi Lovstad
// 4/14/25

namespace Homework_8
{
    public class valid
    {
        public static bool IsValid(string s)
        {
            // Early exit for odd- length strings 

            if (s.Length % 2 != 0) return false;

            char[] stack = new char[s.Length];
            int top = -1; // simulate the top of the stack

            for ( int i =0; i < s.Length; i++)
            {
                char c = s[i];

                // if its an opening bracket, push onto the stack 
                if ( c== '('|| c == '{' || c== '[' )
                {
                    top++;
                    stack[top] = c;
                }
                else
                {
                    // if there is no matching openeing bracket
                    if (top == -1) return false;

                    // check the top of the stack 

                    char open = stack[top];

                    if ((c == ')' && open != '(') ||
                       ((c == '}' && open != '{') ||
                       ((c == ']' && open != '[')
                        {
                        return false;
                    }
                    // pop from the stack

                    top--;
                }
            }
            // if the stack is empty, its valid 
            return top == -1;

        }
    }


  
    

