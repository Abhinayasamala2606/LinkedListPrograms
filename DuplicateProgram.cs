using System;
using System.Collections.Generic;
using System.Linq;
//Removing duplicate program
class DuplicateProgram
{
    public static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>();

        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(7);
        list.AddLast(4);
        list.AddLast(5);
        list.AddLast(6);
        list.AddLast(1);
        list.AddLast(7);
        Console.WriteLine("Before removing duplicate values");
        foreach (int i in list.Order())
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("After removing duplicate values :");
        HashSet<int> set = new HashSet<int>();
        foreach(int i in list.Order())
        {
            set.Add(i);
        }
        foreach(int i in set)
        {
            Console.WriteLine(i);   
        }
        
        
    }

   
}