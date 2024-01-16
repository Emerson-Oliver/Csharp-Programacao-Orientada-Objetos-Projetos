using System;
using System.Globalization;

namespace EmcapsulamentoEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Nobebook", 500.00, 10);

            p.Nome = "Notebook";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(p.Quantidade);
        }
    }
}