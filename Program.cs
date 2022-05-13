using System;

namespace csharp_oop_shop
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto unProdotto = new Prodotto("Scarpe", 10.5, 20);
            Console.WriteLine(unProdotto.GetNomeEsteso());
        }
    }
}