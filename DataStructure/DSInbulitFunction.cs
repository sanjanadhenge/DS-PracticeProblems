using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class DSInbulitFunction
    {
        public void LinkedList()
        {
            //CURD operations 
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(10);
            list.AddFirst(20);
            list.AddFirst(30);
            foreach(var item in  list)
            {
                Console.WriteLine(item);
            }
            list.Remove(20);
            Console.WriteLine("After removing element from linked List");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Top element of the stack => "+stack.Peek());
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
