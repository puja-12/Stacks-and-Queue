// See https://aka.ms/new-console-template for more information
using System;
namespace stackAndqueue
{
    class program
    {
        public static void Main(String[] args)
        {
            
                        Console.WriteLine("Welcome to stack And Queue programmimg!");
                        CreatingAstack_ s1 = new CreatingAstack_();
                        
                        s1.push(70);
                        s1.push(30);
                        s1.push(56);

                        Console.WriteLine(s1.pop() + " popped from stack");
                        Console.WriteLine(s1.pop() + " popped from stack");
                        Console.WriteLine(s1.pop() + " popped from stack");
                        Console.WriteLine("Top element is " + s1.peek());
                        
                }
            }
        }
    




