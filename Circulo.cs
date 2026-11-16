using System;
using System.Collections.Generic;
using System.Text;
namespace FiguraAbst
{
    class Circulo : Figuras
    {
        private float radio;
        public float Radio { get => radio; set => radio = value; }
        public Circulo(float radio)
        {
            this.radio = radio;
        }
        public Circulo()
        {
        }
        public override float Area()
        {
            return (float)(Math.Pow(this.radio, 2) * Math.PI);
        }
        public override float Perimetro()
        {
            return (float)(2 * Math.PI * this.radio);

        }
    }
}