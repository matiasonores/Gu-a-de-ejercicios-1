//Hacer un programa que permita ingresar el año actual y el año de la fecha de nacimiento de una persona
//y luego calcule y emita por pantalla su edad.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
   class Ejercicio3
   {
      static void Main(string[] args)
      {
         int anioActual = 2022;
         int fechaNacimiento;
         int edad;

         Console.WriteLine("Ingrese el año de nacimiento de la persona:");
         fechaNacimiento = int.Parse(Console.ReadLine());

         Console.WriteLine("La edad de la persona es: {0}", edad = anioActual - fechaNacimiento);
         Console.ReadKey();
      }
   }
}
