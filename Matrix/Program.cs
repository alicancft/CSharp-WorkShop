namespace Matrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            string[,] matrix = MatrisOlustur(i,j); 
            MatrisYazdir(matrix);
        }
        public static string[,] MatrisOlustur(int a,int b)
        {
            string[,] matris= new string[a,b];
            for (int k = 0; k < a; k++)
            {
                for (int l = 0; l < b; l++)
                {
                    matris[k, l] = k + "," + l;
                }
            }
            return matris;
        }
        public static void MatrisYazdir(string[,] matriss)
        {
            for (int i = 0; i < matriss.GetLength(0); i++)
            {
                for (int j = 0; j < matriss.GetLength(1); j++)
                {
                    Console.Write(matriss[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        public static void MatrisYazdir(int[,] matriss)
        {
            for (int i = 0; i < matriss.GetLength(0); i++)
            {
                for (int j = 0; j < matriss.GetLength(1); j++)
                {
                    Console.Write(matriss[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}