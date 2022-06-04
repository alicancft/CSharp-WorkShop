namespace Sum
{
        public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci sayı giriniz = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayı giriniz = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Toplam(x,y));
        }
        public static int Toplam(int a, int b)
        {
            int toplam = 0;
            toplam = a + b;
            return toplam;
        }
    }
}