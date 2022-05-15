namespace TheMultiplicationTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i =0; i <= 10; i++)
            {
                //Console.WriteLine("---{0}'ler---",i);
                for (int j = 1; j <= 10; j++)
                {
                    if (i == 0)
                    {
                        Console.Write("---{0:d2}'ler--- ||", j);
                    }
                    else
                    {
                        Console.Write("{0:d2} * {1:d2} = {2:d2} ||", j, i, i * j);
                    }
                    //Console.WriteLine("{0} * {1} = {2} ",i,j,i*j);

                    
                }
                Console.WriteLine();
            }
        }
    }
}