using System;
using System.Collections.Generic;
using System.Text;
namespace FiguraAbst
{
    class Cuadrado : Figuras
    {
        float lado;
        public Cuadrado(float lado)
        {
            this.lado = lado;
        }
        public Cuadrado()
        {
        }
        public float Lado { get => lado; set => lado = value; }
        public override float Area()
        {
            return (float)Math.Pow(lado, 2);

        }
        public override float Perimetro()
        {
            return lado * 4;

        }
    }
}