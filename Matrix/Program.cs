namespace Matrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[,] aMatrix = MatrisOlustur();
            //int[,] bMatrix = MatrisOlustur();
            //IsEqual(aMatrix, bMatrix);
            int[,] kullaniciMatrix = MatrisOlustur();
            MatrisYazdir(kullaniciMatrix);
            SarrusKurali(kullaniciMatrix);

            //Toplam(kullaniciMatrix);
            //int[,] scalerMatris = ScalerCarpim(kullaniciMatrix);
            //MatrisYazdir(scalerMatris);

            //Determinant(kullaniciMatrix);

            //int[,] transposeMatrix = Transpose(kullaniciMatrix);
            //MatrisYazdir(transposeMatrix);

            //int[] diagonalArray=GetDiagonalArray(kullaniciMatrix);
            //MatrisYazdir(diagonalArray);
            //TraceOfMatrix(diagonalArray);
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

        public static string[,] MatrisOlustur(int a, int b)
        {
            string[,] matris = new string[a, b];
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
                    Console.Write(matriss[i, j] + " ");
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

        public static void MatrisYazdir(int[] matriss)
        {
            foreach (int gez in matriss)
            {
                Console.Write(gez + " ");
            }
            //for (int i = 0; i < matriss.Length; i++)
            //{
            //    Console.Write(matriss[i]+" ");
            //}
        }

        public static int[,] MatrisOlustur(int a, int b, int girilenDeger)
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
                    Console.Write("Matrisin {0},{1} elemanı= ", k, l);
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
                    if ((i == j && isDiagonal[i, j] == 0) || (i != j && isDiagonal[i, j] != 0))
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
                    if ((i == j && (isScaler[i, j] != kontrol || kontrol == 0)) ||
                        ((i != j && (isScaler[i, j] != 0 || kontrol == 0))))
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
                    if ((i == j && isIdentity[i, j] != 1) || (i != j && isIdentity[i, j] != 0))
                    {
                        sonuc = "Birim matris değildir.";
                        break;
                    }
                }
            }

            Console.WriteLine(sonuc);
        }

        public static int[] GetDiagonalArray(int[,] matriss)
        {
            int[] diagonalList = new int[matriss.GetLength(0)];
            int eleman = 0;
            for (int k = 0; k < matriss.GetLength(0); k++)
            {
                for (int l = 0; l < matriss.GetLength(1); l++)
                {
                    if (k == l)
                    {
                        diagonalList[eleman] = matriss[k, l];
                        eleman++;
                    }
                }
            }
            return diagonalList;
        }

        public static void TraceOfMatrix(int[] matris)
        {
            int toplam = 0;
            for (int i = 0; i < matris.Length; i++)
            {
                toplam += matris[i];
            }

            Console.WriteLine();
            Console.WriteLine(toplam);
        }

        public static int[,] Transpose(int[,] matris)
        {
            int[,] transposeMatris = new int[matris.GetLength(1), matris.GetLength(0)];
            for (int i = 0; i < matris.GetLength(1); i++)
            {
                for (int j = 0; j < matris.GetLength(0); j++)
                {
                    transposeMatris[i, j] = matris[j, i];
                }
            }
            return transposeMatris;
        }

        public static void IsEqual(int[,] aMatrix, int[,] bMatrix)
        {
            int aMatrisSatir=aMatrix.GetLength(0);
            int bMatrisSatir=bMatrix.GetLength(0);
            int aMatrisSutun = aMatrix.GetLength(1);
            int bMatrisSutun = bMatrix.GetLength(1);
            string sonuc = "Matrisler eşittir.";
            if (aMatrisSatir == bMatrisSatir && aMatrisSutun == bMatrisSutun)
            {
                for (int i = 0; i < aMatrisSatir; i++)
                {
                    for (int j = 0; j < bMatrisSutun; j++)
                    {
                        if (aMatrix[i, j] != bMatrix[i,j])
                        {
                            sonuc = "Eşit değildir";
                            break;
                        }
                    }
                }
            }
            else
            {
                sonuc = "Matrislerin satır sütün eşit değildir";

            }
            Console.WriteLine(sonuc);
        }
        public static void Determinant(int[,]matris)
        {
            int diagonalcarpim = 1;
            int tersdiagonalcarpim = 1;
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        diagonalcarpim*=matris[i,j];
                    }
                    else
                    {
                        tersdiagonalcarpim *= matris[i, j];
                    }
                }
            }
            Console.WriteLine(Math.Abs(diagonalcarpim-tersdiagonalcarpim));
        }

        public static int[,] ScalerCarpim(int[,] matris)
        {
            Console.Write("Çarpım değeriniz= ");
            int carpim = Convert.ToInt32(Console.ReadLine());
            int satirSayisi = matris.GetLength(0);
            int sutunSayisi=matris.GetLength(1);
            // int[,] scalerMatris = new int[satirSayisi, sutunSayisi];
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    matris[i, j] = carpim * matris[i, j];
                }
            }
            return matris;
        }

        public static void Toplam(int[,]matris)
        {
            int toplama = 0;
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    toplama+=matris[i, j];
                }
            }
            Console.WriteLine(toplama);
        }

        public static void SarrusKurali(int[,] matris)
        {
            int sarrus = 0;
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    sarrus=(((matris[0, 0]* matris[1, 1]* matris[2, 2])+( matris[0, 1]* matris[1, 2]* matris[2, 0])+ (matris[0, 2]* matris[1, 0]* matris[2, 1]))-((
                        matris[0, 2]* matris[1, 1]* matris[2, 0])+( matris[0, 0]* matris[1, 2]* matris[2, 1])+ (matris[0, 1]* matris[1, 0]* matris[2, 2])));
                }
            }
            Console.WriteLine(sarrus);
           
        }
        
    }
}