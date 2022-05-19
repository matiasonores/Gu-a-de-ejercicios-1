//Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_1_Ejercicio_2
{
   class Ejercicio2
   {
      static void Main(string[] args)
      {
         int numero;
         Console.WriteLine("Ingrese un valor para elevar al cubo");//Solicita al usuario que ingrese un valor.
         numero = int.Parse(Console.ReadLine());//Recibe la entrada del usuario y la castea a un valor de tipo de int.
         int resultado = numero * numero*numero;
         Console.WriteLine("El número elevado al cubo es: {0}",resultado);
         Console.ReadKey();
      }
   }
}
