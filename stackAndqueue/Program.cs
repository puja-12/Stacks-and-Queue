// See https://aka.ms/new-console-template for more information
using System;
namespace stackAndqueue
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to stack And Queue programmimg!");
            CreatingAstack_ sll = new CreatingAstack_();

            sll.push(70);
            sll.push(30);
            sll.push(56);

            Console.WriteLine("Top element is " + sll.peek());
        }
    }
}




