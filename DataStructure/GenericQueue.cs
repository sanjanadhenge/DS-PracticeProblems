using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class GenericQueue<T>
    {
        private Node<T> head;

        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is enqueued to Queue", node.data);
        }
        public int Size()
        {
            Node<T> temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("Oueue is Empty");
                return -1;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + "");
                    temp = temp.next;
                    count++;
                }

            }
            return count;
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Oueue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty,Deletion is not possible");
                return;
            }
            else
            {
                Console.WriteLine("Value Dequeued is {0}", this.head.data);
                this.head = this.head.next;
            }
        }
    }
}
