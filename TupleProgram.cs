namespace ConsoleApp61
//Tuple to disctionary Conversion
{
    public class TupleProgram
    {
        static void Main(string[] args)
        {
            var tuple = Tuple.Create<string,int>;
            var dictionary= new Dictionary<string,int>();
            dictionary.Add("abhi", 1);
            dictionary.Add("Anu", 2);
            dictionary.Add("Jashu", 3);
            foreach (var item in dictionary)
            {
                Console.WriteLine("[key,value] : "+item);    
            }

            
        }
    }
}
