using System;
using System.Globalization;

namespace Exercicio2
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void ReajusteSalarial(double reajuste)
        {
            Salario = Salario + (Salario * reajuste / 100.0);
        }

        public override string ToString()
        {
            return Nome + ", R$ " + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
