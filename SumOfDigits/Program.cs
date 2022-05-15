namespace SumOfDigits
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number = ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of Digits = "+SumOfDigit(number));
        }

        public static int SumOfDigit(int n)
        {
            int sum = 0;
            while (n > 10)
            {
                sum += n % 10;
                n /= 10;
            }

            sum += n;
            return sum;
        }
    }
}