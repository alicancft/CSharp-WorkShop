namespace SumOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number = ");
            int number = Convert.ToInt32(Console.ReadLine());
            SumOfNumbers(number);
        }

        public static void SumOfNumbers(int n)
        {
            int odd=0,even=0;
            for (int i = 1; i <= n; i++)
            {
                if (i%2==0)
                {
                    even += i;
                }
                else
                {
                    odd += i;
                }
            }
            Console.WriteLine("Sum of all numbers = "+ (odd+even));
            Console.WriteLine("Sum of odd numbers = " + odd);
            Console.WriteLine("Sum of even numbers = " + even);

        }
    }
}