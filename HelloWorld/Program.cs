
namespace HelloWorld
{
    public class Program
    {
        static int MyMethod(int x, int y)
        {
            return x + y;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MyMethod(x, y));
        }
    }
}