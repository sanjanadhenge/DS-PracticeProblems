using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class GenericStack<T>
    {
        private Node<T> top;
        public GenericStack()
        {
            this.top = null;
        }
        internal void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} is pushed to stack", value);
        }
        internal void Display()
        {
            Node<T> temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is Empty");
                return;
            }
            Console.WriteLine("{0} is in the TOP of the stack", this.top);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is Empty");
                return;
            }
            Console.WriteLine("Value popped is {0}", this.top.data);
            this.top = this.top.next;
        }
    }
}

