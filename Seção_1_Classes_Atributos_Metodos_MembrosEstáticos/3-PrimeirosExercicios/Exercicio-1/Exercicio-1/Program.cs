using Exercicio_1;
using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pessoa é a entidade
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira Pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da Sergunda Pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            String pessoaMVelha = " ";

            if(p1.Idade > p2.Idade)
            {
                pessoaMVelha = p1.Nome;
            }
            else
            {
                pessoaMVelha = p2.Nome;
            }
            Console.WriteLine("Pessoa mais velha: " + pessoaMVelha);
        }
    }
}