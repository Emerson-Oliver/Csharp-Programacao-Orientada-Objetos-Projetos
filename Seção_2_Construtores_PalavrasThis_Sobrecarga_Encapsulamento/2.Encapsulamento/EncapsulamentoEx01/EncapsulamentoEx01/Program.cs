using System;
using System.Globalization;

namespace EmcapsulamentoEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Nobebook", 500.00, 10);

            p.setNome("Notebook Gamer");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(p.GetQuantidade());
        }
    }
}