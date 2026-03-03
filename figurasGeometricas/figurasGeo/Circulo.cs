using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasGeometricas.figurasGeo
{
    /// <summary> 
    /// Gutierrez Ruiz Evelyn Pamela
    /// esta clase es la encargada de crear objetos de tipo circulo como calcular su area.
    /// </summary>
    public class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(string color, double radio) 
        {
            this.color = color;
            this.Radio = radio;
        }

        public override double CalcularArea()
        {
            return  3.1416 *(Radio* Radio);
        }

        public override double CalcularPerimetro()
        {
            return 2 * 3.1416 * Radio;
        }
    }
}
