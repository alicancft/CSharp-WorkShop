namespace Matrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] kullaniciMatrix = MatrisOlustur();
            MatrisYazdir(kullaniciMatrix);
            GetDiagonalArray(kullaniciMatrix);
            //IsDiagonal(kullaniciMatrix);
            //IsScaler(kullaniciMatrix);
            //IsIdentity(kullaniciMatrix);

            //int i = Convert.ToInt32(Console.ReadLine());
            //int j = Convert.ToInt32(Console.ReadLine());
            //int deger = Convert.ToInt32(Console.ReadLine());
            // int[,] degerMatrix = MatrisOlustur(i, j, deger);
            //MatrisYazdir(degerMatrix);
            // string[,] matrix = MatrisOlustur(i,j); 
            //  MatrisYazdir(matrix);
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
        public static int[,] MatrisOlustur(int a, int b,int girilenDeger)
        {
            int[,] matris = new int[a, b];
            for (int k = 0; k < a; k++)
            {
                for (int l = 0; l < b; l++)
                {
                    matris[k, l] = girilenDeger;
                }
            }
            return matris;
        }

        public static int[,] MatrisOlustur()
        {
            Console.Write("Satır sayısı= ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun sayısı= ");
            int j = Convert.ToInt32(Console.ReadLine());

            int[,] matris = new int[i, j];
            for (int k = 0; k < i; k++)
            {
                for (int l = 0; l < j; l++)
                {
                    Console.Write("Matrisin {0},{1} elemanı= ",k,l);
                    matris[k, l] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matris;
        }

        public static void IsDiagonal(int[,] isDiagonal)
        {
            string sonuc = "Diagonal matristir.";
            for (int i = 0; i < isDiagonal.GetLength(0); i++)
            {
                for (int j = 0; j < isDiagonal.GetLength(1); j++)
                {
                    if ((i==j && isDiagonal[i,j]==0) || (i != j && isDiagonal[i, j] != 0))
                    {
                        sonuc = "Diagonal matris değidir.";
                        break;
                    }
                }
            }
            Console.WriteLine(sonuc);
        }
        public static void IsScaler(int[,] isScaler)
        {
            string sonuc = "Scaler matristir.";
            int kontrol = isScaler[0, 0];
            for (int i = 0; i < isScaler.GetLength(0); i++)
            {
                for (int j = 0; j < isScaler.GetLength(1); j++)
                {
                    if ((i==j && (isScaler[i,j]!=kontrol || kontrol==0))||((i != j && (isScaler[i, j] != 0 || kontrol == 0))))
                    {
                        sonuc = "Scaler matris değidir.";
                        break;
                    }
                }
            }
            Console.WriteLine(sonuc);
        }
        public static void IsIdentity(int[,] isIdentity)
        {
            string sonuc = "Birim matristir.";
            for (int i = 0; i < isIdentity.GetLength(0); i++)
            {
                for (int j = 0; j < isIdentity.GetLength(1); j++)
                {
                    if ((i==j && isIdentity[i,j]!=1) || (i!=j && isIdentity[i,j]!=0))
                    {
                        sonuc = "Birim matris değildir.";
                        break;
                    }
                }
            }
            Console.WriteLine(sonuc);
        }
        public static void GetDiagonalArray(int[,] diagonaller)
        {
            int[] matris = new int[diagonaller.GetLength(0)];
            int eleman = 0;
            for (int k = 0; k < diagonaller.GetLength(0); k++)
            {
                for (int l = 0; l < diagonaller.GetLength(1); l++)
                {
                    if (k==l)
                    {
                        matris[eleman] = diagonaller[k,l];
                        eleman++;
                    }
                }
            }

            foreach (int gez in matris)
            {
                Console.Write(gez+" ");
            }

            //for (int i = 0; i < matris.Length; i++)
            //{
            //    Console.Write(matris[i]+" ");
            //}
        }
    }
}