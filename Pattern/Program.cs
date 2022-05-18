namespace Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lineCount = Convert.ToInt32(Console.ReadLine());
            {
                for (int currentLine = 1; currentLine < lineCount; currentLine++)
                {
                    for (int spaceCount = lineCount-currentLine; spaceCount > 0; spaceCount--)
                    {
                        Console.Write(" ");
                    }
                    for (int star = 1; star < currentLine; star++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void at()
        {
            int lineCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < lineCount; i++)
            {
                if (i >= lineCount / 2)
                {
                    for (int k = i / 2; k > 0; k--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < lineCount - i; j++)
                    {
                        Console.Write("*");
                    }
                }
                //else if (i==lineCount/2)
                //{
                //    for (int j = 0; j < lineCount/2; j++)
                //    {
                //        Console.Write("*");
                //    }
                //}
                else
                {
                    for (int j = lineCount / 2 - (i / 2); j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
        
    }
}