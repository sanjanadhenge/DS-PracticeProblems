using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class GenericLinkedList<T> where T : IComparable
    {
        internal Node<T> head;
        internal void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                this.head = node;
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
            Console.WriteLine("{0} inserted into Linked List", node.data);
        }
        public void AddReverse(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "  ");
                temp = temp.next;
            }

        }
        public void Insert(int Position, T data)
        {
            Node<T> node1 = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node1;
            }
            if (Position == 0)
            {
                node1.next = this.head;
                this.head = node1;
                return;
            }
            Node<T> prev = null;
            Node<T> current = this.head;
            int count = 0;
            while (current != null && count < Position)
            {
                prev = current;
                current = current.next;
                count++;

            }
            node1.next = prev.next;
            prev.next = node1;
        }
        public void RemoveFirstElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is Empty");
            }

            this.head = this.head.next;
        }
        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            Node<T> node2 = head;
            if (head.next == null)
            {
                this.head = null;
            }
            while (node2.next.next != null)
            {
                node2 = node2.next;
            }
            node2.next = null;
        }
        public int Search(T value)
        {
            Node<T> node = this.head;
            int count = 0;
            while (node.next != null)
            {
                if (node.data.Equals(value))
                {
                    Console.WriteLine(count);
                }
                else
                {
                    return -1;
                }
                node = node.next;
                count++;

            }
            return count;


        }
        public void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node<T> temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node<T> next = temp.next.next;
            temp.next = next;
            Size();
        }
        public int Size()
        {
            int count = 0;
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("Size is " + count);
            return count;
        }
        public void Sort()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            int size = Size();
            Node<T> current = this.head;
            Node<T> index = null;
            T temp ;
            while (current != null)
            {
                index = current.next;
                while (index != null)
                {
                    T a = current.data;
                    T b = index.data;
                    if (a.CompareTo(b)<0)
                    {
                        temp = a;
                        a = b;
                        b = temp;
                    }
                    current.data = a;
                    index.data = b;
                    index = index.next;
                    current = current.next;
                }

            }
        }

    }
}
