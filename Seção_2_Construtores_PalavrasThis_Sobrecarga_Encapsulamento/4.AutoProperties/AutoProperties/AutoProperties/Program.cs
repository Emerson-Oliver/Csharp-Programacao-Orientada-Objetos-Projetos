

using System;
using System.Globalization;

namespace AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Nobebook", 500.00, 10);

            p.Nome = "N";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(p.Quantidade);
        }
    }
}


