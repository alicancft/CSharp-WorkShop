namespace SingleCouple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz = ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0 )
            {
                Console.WriteLine("Girdiğiniz {0} sayısı çifttir.",sayi);
            }
            else
            {
                Console.WriteLine("Girdiğiniz {0} sayısı tektir.",sayi);
            }
        }
    }
}