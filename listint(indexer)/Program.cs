using listint_indexer_.Models;

namespace listint_indexer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsarr = new int[] { 1, 2, 3 };  
            ListInt listInt = new ListInt(numsarr);
            listInt.Add(3,4,5);
            listInt.GetArr();
            listInt.Sum();
            Console.WriteLine("Array length : " + listInt.Length);
            Console.WriteLine(listInt.Contains(1));
            Console.WriteLine(listInt.Pop());
            Console.WriteLine(listInt.ToString());
            Console.WriteLine("Enter the index of element : " + listInt[2]);
        }
    }
}