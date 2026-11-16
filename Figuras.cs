using System;
using System.Collections.Generic;
using System.Text;
namespace FiguraAbst
{
    public abstract class Figuras
    {
        private string nombreFig;
        public string NombreFig { get => nombreFig; set => nombreFig = value; }
        public abstract float Area();
        public abstract float Perimetro();
    }
}