using System;
using System.Globalization;


namespace Exercicio1
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;
        public double Area()
        {
            return Altura * Largura;
        }
        
        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }    
}
