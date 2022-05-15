using System.Security.Cryptography.X509Certificates;

namespace PrimeNumber
{
    public class Program
    {
        public static bool IsPrime(int n)
        {
            for (int i = 2; i<n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void PrimeUpToTheEnteredNumber(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i+ " ");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number =");
            int n = Convert.ToInt32(Console.ReadLine());
            PrimeUpToTheEnteredNumber(n);
        }
    }
}