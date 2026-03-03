using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace figurasGeometricas.figurasGeo
{
    /// <summary>
    /// Gutierrez Ruiz Evelyn Pamela
    /// esta clase es la encargada de crear objetos de tipo figura, como calcular su area y perimetro, mostrar su informacion y cambiar el color.
    /// </summary>
    public abstract class Figura
    {
        public string color { get; set; }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        public string tipodfig()
        {
            Console.WriteLine("Ingresa tipo de figura: " +
                "circulo, rectangulo, triangulo, triangulo rectangulo");
                string tipofig = Console.ReadLine();
            return tipofig;
        }
        public void MostrarInformacion()
        {
           
            Console.WriteLine($"Tipo de figura: {tipodfig()}");
            
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Área: {CalcularArea()}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro()}");

            Console.WriteLine($"Tu tipo de figura es: {tipodfig()} Color: {color} Area: {CalcularArea()} Perímetro: {CalcularPerimetro()}");
        }

        public void NuevoColor(string nuevoColor)
        {
            this.color = nuevoColor;
            Console.WriteLine($"El nuevo color de la figura es: {color}");
        }
    }
}
