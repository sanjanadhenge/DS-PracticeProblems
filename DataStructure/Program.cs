using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            //GenericLinkedList<int> list = new GenericLinkedList<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Display();
            GenericStack<int> stack = new GenericStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Display();
            stack.Pop();
        }


    }
}
