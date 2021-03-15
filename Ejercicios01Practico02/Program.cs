using Ejercicios01Practico02POO.BL;
using System;

namespace Ejercicios01Practico02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangulo rectangulo = new Rectangulo();
                Console.WriteLine("Ingrese el Lado Mayor:");
                var LadoMayor = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el Lado Menor:");
                var LadoMenor = int.Parse(Console.ReadLine());
                if ( LadoMenor > 0 & LadoMayor > 0)
                {
                    rectangulo.LadoMayor = LadoMenor;
                    rectangulo.LadoMenor = LadoMayor;
                    

                    Console.WriteLine($"El perimetro es {rectangulo.GetPerimetro()}");
                    Console.WriteLine($"La superficie es {rectangulo.GetSuperficie()}");

                }
                else
                {
                    
                    
                    Console.WriteLine("Ingrese un numero mayor a 0");

                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Lado mal ingresado");
                
            }
            Console.ReadLine();

        }
    }
}
