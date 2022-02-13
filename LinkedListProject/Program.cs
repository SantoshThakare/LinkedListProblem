using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Problem");
           
            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            Console.WriteLine("Provided LinkedList :");
            list.Display();

            list.Add(60);
            list.AddInReverseOrder(1);
            list.RemoveFirstNode();
            list.RemoveLastNode();
            list.Search(20);
            int Requiredposition = list.Search(20);
            list.DeleteNodeAtPerticularPosition(Requiredposition);
            Console.WriteLine("The updated LinkedList :");
            list.Size();

        }
    }
}
