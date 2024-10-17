using System;
//Swapping Elements
namespace ConsoleApp62
{
    class SwappingProgram
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Elements after swapping");
            int temp;
            int index1 = 0;
            int index2 = list.Count() - 1;
            while (index1 < index2)
            {
                temp = list[index1];
                list[index1] = list[index2];
                list[index2] = temp;
                index1++;
                index2--;
            }
            foreach (int s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
