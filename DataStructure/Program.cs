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
            //DSInbulitFunction data = new DSInbulitFunction();
            //data.Queue();
            GenericLinkedList<int> list = new GenericLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Display();
            list.Sort();
            list.Display();
        }


    }
}
