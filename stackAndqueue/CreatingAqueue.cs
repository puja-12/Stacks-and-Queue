using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackAndqueue
{
    public class QNode
    {
        public int key;
        public QNode next;

        // constructor to create
        // a new linked list node
        public QNode(int key)
        {
            this.key = key;
            this.next = null;
        }
    }

    // A class to represent a queue The queue,
    // front stores the front node of LL and
    // rear stores the last node of LL
    public class Queue
    {
        public QNode front, rear;

        public Queue()
        {
            this.front = this.rear = null;
        }

        // Method to add an key to the queue.
        public void enqueue(int key)
        {

            // Create a new LL node
            QNode temp = new QNode(key);

            // If queue is empty, then new
            // node is front and rear both
            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }

            // Add the new node at the
            // end of queue and change rear
            this.rear.next = temp;
            this.rear = temp;
        }
        public void dequeue()
        {
            // If queue is empty, return NULL.
            if (this.front == null)
                return;

            // Store previous front and
            // move front one node ahead
            QNode temp = this.front;
            this.front = this.front.next;

            // If front becomes NULL,
            // then change rear also as NULL
            if (this.front == null)
                this.rear = null;
        }
            internal void Display()
        {
            QNode temp = this.front;
            if (temp == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.key + "");
                temp = temp.next;

            }
        }

    }
}


  
    
