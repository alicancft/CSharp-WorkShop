namespace BinaryToDesimal
{
    public class Program
    {
        static void Main(string[] args)
        {
            string ikilikSayi = Console.ReadLine();
            int n = ikilikSayi.Length;
            int toplam = 0;
            for (int i = 0; i < n; i++)
            {
                toplam += Convert.ToInt32(ikilikSayi[n - i - 1].ToString()) * (int)(Math.Pow(2, i));
            }
            Console.WriteLine(toplam);
        }
    }
}