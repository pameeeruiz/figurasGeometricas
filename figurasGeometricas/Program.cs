using figurasGeometricas.figurasGeo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasGeometricas
{
    internal class Program
    {
        /// <summary>
        /// Gutierrez Ruiz Evelyn Pamela
        /// esta clase es la encargada de crear objetos de tipo figura, circulo, rectangulo y triangulo rectangulo, mostrar su informacion, cambiar el color y calcular su area.
        /// </summary>
       
        static void Main(string[] args)
        {
			try
			{
                Figura circulo = new Circulo("Rojo", 3);
                Figura rectangulo = new Rectangulo("Azul", 4, 5);
                Figura triangulo = new TrianguloRectangulo("Verde", 3, 4);
                Figura TrianguloRectangulo = new TrianguloRectangulo("Amarillo", 5, 12);

                circulo.MostrarInformacion();
                rectangulo.MostrarInformacion();
                triangulo.MostrarInformacion();
                TrianguloRectangulo.MostrarInformacion();

                circulo.NuevoColor("Morado");
                Console.WriteLine("Cambio color:");
                circulo.MostrarInformacion();

               double areatotal=    
                    circulo.CalcularArea() +
                    triangulo.CalcularArea()+
                    rectangulo.CalcularArea()+
                    TrianguloRectangulo.CalcularArea();
            }
			catch (Exception ex)
			{
				Console.WriteLine($"Ocurrió un error: {ex.Message}"); 
                Console.WriteLine(ex.Message);
				throw;
			}



        }
    }
}
