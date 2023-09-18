using System;
using System.Globalization;

namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto mercadoria = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            mercadoria.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            mercadoria.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade atual no estoque: ");
            mercadoria.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + mercadoria);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            mercadoria.AdicionarProduto(quantidade);
            Console.WriteLine("Dados Atualizados: " + mercadoria);
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + mercadoria);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser Removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            mercadoria.RemoverProduto(quantidade);
            Console.WriteLine("Dados Atualizados: " + mercadoria);
        }
    }
}