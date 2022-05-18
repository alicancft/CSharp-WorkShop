namespace Factorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} sayısının faktöriyeli = {1} ",number,Aralikli(number));
        }

        public static int Aralikli(int number)
        {
            int factop = 0;
            for (int i = 2; i <=number; i++)
            {
                factop+=Factorial(i);
            }
            return factop/(number-1);
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