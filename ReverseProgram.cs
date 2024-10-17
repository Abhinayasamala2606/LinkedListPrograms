namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>(); 
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");
            list.AddLast("f");
            list.AddLast("g");
            list.AddLast("h");
            list.AddLast("i");
            string res = "";
            foreach (string item in list)
            {
                res=res+item;
            }
            Console.WriteLine(res);
            Console.WriteLine("Reversed string");
            list.Reverse();
            string rev = "";
            foreach (var item in list.Reverse())
            {
                rev=rev+item;
            }
            Console.WriteLine(rev);
            
        }
    }
}
