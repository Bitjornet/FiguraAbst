using System;

namespace FiguraAbst
{
    class Triangulo : Figuras
    {
        private float baseT;
        private float altura;
        private float lado1;
        private float lado2;
        private float lado3;

        public float BaseT { get => baseT; set => baseT = value; }
        public float Altura { get => altura; set => altura = value; }
        public float Lado1 { get => lado1; set => lado1 = value; }
        public float Lado2 { get => lado2; set => lado2 = value; }
        public float Lado3 { get => lado3; set => lado3 = value; }

        public Triangulo(float baseT, float altura, float lado1, float lado2, float lado3)
        {
            this.baseT = baseT;
            this.altura = altura;
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public Triangulo()
        {
        }

        public override float Area()
        {
            return (baseT * altura) / 2;
        }

        public override float Perimetro()
        {
            return lado1 + lado2 + lado3;
        }
    }
}