using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();
            sehirler.Add(48, "Muğla");
            sehirler.Add(35, "İzmir");
            sehirler.Add(15, "Burdur");
            sehirler.Add(32, "Isparta");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(09, "Aydın");
            sehirler.Add(20, "Denizli");

            foreach (var sehir in sehirler.Items)
            {
                Console.WriteLine("Plaka: " + sehir.Item1 + "\tŞehir: " + sehir.Item2);
            }

            Console.WriteLine("Plakası ve İsmi Yazılan İl Sayısı " + sehirler.Items.Length);

        }
    }
}
