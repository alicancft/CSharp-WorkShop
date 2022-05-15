using System.Security.Cryptography.X509Certificates;

namespace PrimeNumber
{
    internal class Program
    {
        public static bool IsPrime(int n)
        {
            if (n == 2)
                return true;
            for (int i = 2; i<=n/2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number =");
                int n = Convert.ToInt32(Console.ReadLine());
                if (IsPrime(n))
                {
                    Console.WriteLine("Your number is a prime number.");
                }
                else
                {
                    Console.WriteLine("Your number is not a prime number.");
                }

        }
    }
}