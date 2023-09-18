using System;
namespace TrianguloMetodo
{
    internal class Triangulo
    {
        //Atributos da classe
        public double A;
        public double B;
        public double C;

        //Metodo calculo da area
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            
        }

    }
}