// See https://aka.ms/new-console-template for more information
using System;
namespace stackAndqueue
{
    class program
    {
        public static void Main(String[] args)
        {
            while (true)
            {
                Console.WriteLine("select no\n1)stack\n2)queue\n");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        Console.WriteLine("Welcome to stack And Queue programmimg!");
                        CreatingAstack_ s1 = new CreatingAstack_();

                        s1.push(70);
                        s1.push(30);
                        s1.push(56);

                        Console.WriteLine(s1.pop() + " popped from stack");
                        Console.WriteLine(s1.pop() + " popped from stack");
                        Console.WriteLine(s1.pop() + " popped from stack");
                        Console.WriteLine("Top element is " + s1.peek());
                        break;
                    case 2:
                        Queue q=new Queue();
                        Console.WriteLine("elements in queue");

                        q.enqueue(56);
                        q.enqueue(30);
                        q.enqueue(70);
                        q.Display();
                        Console.WriteLine("first element is remove");
                        q.dequeue();
                        Console.WriteLine("second element is remove");
                        q.dequeue();
                        Console.WriteLine("Queue Front : " + q.front.key);
                        Console.WriteLine("Queue Rear : " + q.rear.key);

                        break;
                }
            }
        }
    }
}




