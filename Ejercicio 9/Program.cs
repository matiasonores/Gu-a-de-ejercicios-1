//Una universidad desea conocer los porcentajes de mujeres y hombres en las
//carreras de ciencias exactas. Se solicita un programa para cargar la cantidad de
//mujeres y la cantidad de hombres y que el mismo calcule y emita por pantalla
//los porcentajes correspondientes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
   class Program
   {
      static void Main(string[] args)
      {
         int mujeres, hombres;
         double porcentaje;

         Console.WriteLine("Ingrese la cantidad de mujeres:");
         mujeres = int.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese la cantidad de hombres:");
         hombres = int.Parse(Console.ReadLine());

         porcentaje = mujeres * 100 / (mujeres + hombres);
         Console.WriteLine("El porcentaje de mujeres es: {0}%", porcentaje);
         porcentaje = hombres * 100 / (mujeres + hombres);
         Console.WriteLine("El porcentaje de hombres es: {0}%", porcentaje);

         Console.ReadKey();
      }
   }
}
