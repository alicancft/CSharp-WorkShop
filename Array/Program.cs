using System.Security.Cryptography.X509Certificates;

namespace Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* int[] array = { 5, 2, 11, 12, 6, 3 };
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
             Console.WriteLine("StandardDeviation = "+StandardDeviation(array));*/
            int[] array = { 1, 4, 5, 8, 20, 65, 48, 92, 35, 7, 13, 2 };
            OddOrEven(array);
        }

        public static void OddOrEven(int[] controlArray)
        {
            int[] odd=new int[controlArray.Length];
            int oddIndex = 0;
            int[] even=new int[controlArray.Length];
            int evenIndex = 0;
            for (int i = 0; i < controlArray.Length; i++)
            {
                if (controlArray[i]%2==0)
                {
                    even[evenIndex] = controlArray[i];
                    evenIndex++;
                }
                else
                {
                    odd[oddIndex] = controlArray[i];
                    oddIndex++;
                }
            }
            System.Array.Sort(even);
            foreach (var n in even)
            {
                if (n!=0)
                {
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine();
            System.Array.Sort(odd);
            foreach (var n in odd)
            {
                if (n != 0)
                {
                    Console.Write(n + " ");
                }
            }
        }


        public static double StandardDeviation(int[] n)
        {
            double standardDeviation = 0;
            double totalSquare = 0;
            var average = n.Average();
            for (int i = 0; i < n.Length; i++)
            {
                totalSquare += Math.Pow(n[i], 2);
            }
            standardDeviation = ((1d / n.Length) * (totalSquare - (n.Length * Math.Pow(average, 2))));
            return Math.Sqrt(standardDeviation);
        }
    }
}
