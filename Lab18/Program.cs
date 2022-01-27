using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку с разными скобками");
            string s = Console.ReadLine();
            //Console.WriteLine(Chek(s));
            Chek(s);
            Console.ReadKey();
        }
        static void Chek(string s)
            
    {
          Stack<char> stk = new Stack<char>();
            Dictionary<char, char> bracket = new Dictionary<char, char> 
            { { '(', ')' }, { '[', ']' }, { '{', '}' } };


            foreach (char b in s)
            {
                if (b == '(' || b == '[' || b == '{')
                    stk.Push(bracket[b]);
                if ((b == ')' || b == ']' || b == '}'))
                {
                    if (stk.Count == 0 || stk.Pop() != b)
                    { 
                        //return false;
                        Console.WriteLine("Ошибка");

                    }
                }

            
            }


                if (stk.Count == 0)

                    //return true; 
                    Console.WriteLine("Всё верно");
                else
                    //return false; 
             Console.WriteLine("Ошибка");
            
        }        
        
        
    }
}
