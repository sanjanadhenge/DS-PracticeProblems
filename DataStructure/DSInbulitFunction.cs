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
    }
}
