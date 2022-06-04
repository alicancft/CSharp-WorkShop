using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İzmir");
            cities.Add(1);
            foreach (var VARIABLE in cities)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}