using System.Security.Cryptography.X509Certificates;

namespace Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 11, 12, 6, 3 };
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nMax " + array.Max());
            Console.WriteLine("Min " + array.Min());
            var average = array.Average();
            Console.Write(average);
            System.Array.Sort(array);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("StandardDeviation = "+StandardDeviation(array));
        }

        public static double StandardDeviation(int[] n)
        {
            double standardDeviation=0;
            double totalSquare = 0;
            var average = n.Average();
            for (int i = 0; i < n.Length; i++)
            {
                totalSquare += Math.Pow(n[i],2);
            }
            standardDeviation = ((1d / n.Length) * (totalSquare - (n.Length * Math.Pow(average, 2))));
            return Math.Sqrt(standardDeviation);
        }
    }
}