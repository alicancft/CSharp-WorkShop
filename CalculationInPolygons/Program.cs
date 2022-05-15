namespace CalculationInPolygons
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static float CircumferenceOfTheCircle(int radius)
        {
            return 2 * MathF.PI * radius;
        }

        public static float AreaOfTheCircle(int radius)
        {
            return MathF.PI * MathF.Pow(radius, 2);
        }

        public static int AreaOfRectangle(int a, int b)
        {
            return a * b;
        }

        public static int TheVolumeOfTheRectangle(int a, int b, int h)
        {
            return AreaOfRectangle(a, b) * h;
        }

        public static float AreaOfTheSphere(int radius)
        {
            return AreaOfTheCircle(radius) * 4;
        }

        public static float VolumeOfSphere(int radius)
        {
            return (4 / 3) * MathF.PI * MathF.Pow(radius, 3);
        }
    }
}