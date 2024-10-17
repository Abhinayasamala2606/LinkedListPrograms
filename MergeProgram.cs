using System.Reflection;
using System.Xml.Linq;

namespace ConsoleApp58
{
    internal class MergeProgram
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("3");
            list.AddLast("2");
            list.AddLast("1");
            list.AddLast("4");
            list.AddLast("6");
            list.AddLast("5");
            list.AddLast("9");
            list.AddLast("7");
            list.AddLast("9");
            list.AddLast("8");
            LinkedList<string> list2 = new LinkedList<string>();
            list2.AddLast("a");
            list2.AddLast("h");
            list2.AddLast("f");
            list2.AddLast("s");
            list2.AddLast("g");
            list2.AddLast("e");
            list2.AddLast("b");
            list2.AddLast("d");
            list2.AddLast("c");
            list2.AddLast("p");

            //program for merge program

            LinkedList<string> l = new LinkedList<string>();
            foreach(string s in list)
            {
                l.AddLast(s);
            }
            foreach (string s in list2)
            {
                l.AddLast(s);
            } 
            foreach(string s in l.Order())
            {
                Console.WriteLine(s);   
            }

            //middle element program logic

            Console.WriteLine("Middle element");
            l.Count();
            Console.WriteLine(l.Count() / 2);
            Console.WriteLine("Element at middle:" + l.ElementAt(l.Count() / 2));
            
           

                
            
            




        }
    }
}
