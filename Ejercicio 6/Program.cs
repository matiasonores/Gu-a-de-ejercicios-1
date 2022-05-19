//Hacer un programa para ingresar por teclado las tres notas de exámenes de un
//alumno y luego calcule y emita por pantalla el promedio final.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
   class Program
   {
      static void Main(string[] args)
      {
         int nota1, nota2, nota3;
         double promedio;

         Console.WriteLine("Ingrese las notas del alumno: (1-100)");
         nota1 = int.Parse(Console.ReadLine());
         nota2 = int.Parse(Console.ReadLine());
         nota3 = int.Parse(Console.ReadLine());

         promedio = (nota1 + nota2 + nota3) / 3;
         Console.WriteLine("El promedio del alumno es: {0}", promedio);
         Console.ReadKey();
      }
   }
}
