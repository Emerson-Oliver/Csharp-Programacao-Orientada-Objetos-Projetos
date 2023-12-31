﻿using Exercicio_2;
using System;
using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do Segundo Funcionario: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double salarioMedio = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}