namespace Factorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} sayısının faktöriyeli = {1} ",number,Factorial(number));
        }

        public static int Factorial(int number)
        {
            int fac = 1;
            for (int i = number; i > 0; i--)
            {
                fac *= i;
            }
            return fac;
        }
    }
}