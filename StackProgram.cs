using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
public class StackProgram
{
    //generic stack program
    List<int> elements = new List<int>();
    public void Push(int item)
    {
        elements.Add(item);
        
    }
        
    public void Pop()
    {
        elements.RemoveAt(elements.Count - 1);  
       
    }
   
	static void Main(string[] args)
    {
        //we can direct right like this

        //Stack<int> stack = new Stack<int>();
        //stack.Push();
        //stack.Push(22);
        //stack.Push(34);
        //stack.Push(90);
        
        //foreach(int i in stack)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("after Poped element");
        //stack.Pop();
        //foreach(int i in stack)
        //{
        //    Console.WriteLine(i);
        //}

        //we ask the user to give input method

        StackProgram program = new StackProgram();
        Stack<int> stack = new Stack<int>();
        for(int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Enter the elements");
            int item = int.Parse(Console.ReadLine());
            stack.Push(item);
           
        }
        Console.WriteLine("pushed elements");
        foreach (var j in stack)
        {
            Console.WriteLine(j);
        }   
        Console.WriteLine("Poped element");
        int popped=stack.Pop();
        Console.WriteLine(popped);
        Console.WriteLine("After popped element");
        foreach (var j in stack)
        {
            Console.WriteLine(j);
        }


    }
}


