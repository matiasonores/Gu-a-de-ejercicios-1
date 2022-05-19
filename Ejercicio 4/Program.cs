//Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo.
//Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
   class Ejercicio4
   {
      static void Main(string[] args)
      {
         int distancia, velocidad;
         double tiempo;

         Console.WriteLine("Ingrese la distancia entre la ciudad A y la ciudad B:");
         distancia = int.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese la velocidad a la cual se desplaza:");
         velocidad = int.Parse(Console.ReadLine());

         Console.WriteLine("El tiempo de viaje será de: {0} horas",tiempo=distancia/velocidad);
         Console.ReadKey();
      }
   }
}
