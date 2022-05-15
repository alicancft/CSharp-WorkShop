namespace SumTwoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number = ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number = ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of numbers = " + (first+second));
        }
    }
}