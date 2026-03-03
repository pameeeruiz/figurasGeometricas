using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasGeometricas.figurasGeo
{
    public class Rectangulo : Figura
    {
        /// <summary>
        /// Gutierrez Ruiz Evelyn Pamela
        /// esta clase es la encargada de crear objetos de tipo rectangulo como calcular su area y perimetro.
        /// </summary>
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(string color, double baseRec, double altura) 
        {
            this.color = color;
            this.Base = baseRec;
            this.Altura = altura;
        }
        public override double CalcularArea()
        {
            return Base * Altura;
        }
        public override double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
