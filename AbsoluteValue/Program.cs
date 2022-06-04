namespace AbsoluteValue
{
    public class Program
    {
       static void Main(string[] args)
        {
            Console.Write("Enter a number = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs(x));
        }
    }
}