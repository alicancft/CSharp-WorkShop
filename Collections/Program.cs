using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList cities = new ArrayList();
            //cities.Add("Ankara");
            //cities.Add("Adana");
            //cities.Add("İzmir");
            //cities.Add(1);
            //foreach (var VARIABLE in cities)
            //{
            //    Console.WriteLine(VARIABLE);
            //}
            //List<string> cities = new List<string>();
            //cities.Add("Ankara");
            //cities.Add("İzmir");
            //var count = cities.Count; //eleman sayısı
            //Console.WriteLine(count);
            Dictionary<string,string> dictionary=new Dictionary<string,string>();
            dictionary.Add("book","kitap");
            dictionary.Add("table","tablo");
            dictionary.Add("computer","bilgisayar");

            Console.WriteLine(dictionary["table"]);
            Console.WriteLine(dictionary["computer"]);
            foreach (var items in dictionary)
            {
                Console.WriteLine(items.Value);
            }

        }
    }
}