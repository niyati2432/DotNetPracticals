using System;
using System.Collections.Generic;

namespace Practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter infix string:");
            String infix=Console.ReadLine().ToString();
            String postfix= InfixToPostfix(infix);
            Console.WriteLine("Infix string is: "+ infix);
            Console.WriteLine("Postfix string is: " + postfix);
            Console.Read();
        }
        public static string InfixToPostfix(string exp)
        {
        String result = "";
         
        Stack<char> stack = new Stack<char>();
         
        for (int i = 0; i<exp.Length; ++i)
        {
            char c = exp[i];
             
            if (Char.IsLetterOrDigit(c))
                result += c;
              
            else if (c == '(')
                stack.Push(c);
            else if (c == ')')
            {
                while (stack.Count!=0 && stack.Peek() != '(')
                    result += stack.Pop();
                 
                if (stack.Count!=0 && stack.Peek() != '(')
                    return "Invalid Expression"; // invalid expression                
                else
                    stack.Pop();
            }
            else // an operator is encountered
            {
                while (stack.Count!=0  && Prec(c) <= Prec(stack.Peek()))
                    result += stack.Pop();
                stack.Push(c);
            }
      
        }
      
        // pop all the operators from the stack
        while (stack.Count!=0 )
            result += stack.Pop();
      
        return result;
    }
	
    public static int Prec(char ch)
    {
        switch (ch)
        {
        case '+':
        case '-':
            return 1;
      
        case '*':
        case '/':
            return 2;
      
        case '^':
            return 3;
        }
        return -1;
    }
    }  
    }
