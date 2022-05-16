namespace Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 4, 6, 8, 2, 3 };
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nMax " + array.Max());
            Console.WriteLine("Min " + array.Min());
            System.Array.Sort(array);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}