using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasGeometricas.figurasGeo
{
    /// <summary>
    /// Gutierrez Ruiz Evelyn Pamela
    /// esta clase es la encargada de crear objetos de tipo triangulo rectangulo como calcular su area y perimetro.
    /// </summary>
    public class TrianguloRectangulo : Figura
    {
        public double CatetoA { get; set; }
        public double CatetoB { get; set; }

        public TrianguloRectangulo(string color, double catetoA, double catetoB) 
        {
            this.color = color;
            this.CatetoA = catetoA;
            this.CatetoB = catetoB;
        }

        public override double CalcularArea()
        {
            return (CatetoA * CatetoB) / 2;
        }

        public override double CalcularPerimetro()
        {
            double hipotenusa = Math.Sqrt(CatetoA * CatetoA + CatetoB * CatetoB);
            return CatetoA + CatetoB + hipotenusa;
        }
    }
}
