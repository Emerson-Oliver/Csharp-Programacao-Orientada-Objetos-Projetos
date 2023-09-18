
using System.Globalization;
namespace ExercicioFixacao
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int qtde)
        {
            Quantidade += qtde;
        }

        public void RemoverProduto(int qtde)
        {
            Quantidade -= qtde;
        }

        public override string ToString()
        {
            return Nome + ", R$ " + Preco.ToString("F2",CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: R$" 
            + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
