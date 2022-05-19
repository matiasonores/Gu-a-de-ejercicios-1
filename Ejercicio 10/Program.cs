//Hacer un programa que permita ingresar por teclado dos números y que luego
//muestre por pantalla la suma, la resta, la multiplicación y la división de dichos
//números. Se deben mostrar cuatro resultados en pantalla. Los números deben
//ser solicitados una única vez.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
   class Program
   {
      static void Main(string[] args)
      {
         int n1, n2;
         double operacion;

         Console.WriteLine("Ingrese el primer valor:");
         n1 = int.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese el segundo valor:");
         n2 = int.Parse(Console.ReadLine());

         Console.WriteLine("El resultado de la suma es:{0}", operacion =n1+n2);
         Console.WriteLine("El resultado de la resta es:{0}", operacion = n1 - n2);
         Console.WriteLine("El resultado de la multiplicación es:{0}", operacion = n1 * n2);
         Console.WriteLine("El resultado de la división es:{0}", operacion = n1 / n2);

         Console.ReadKey();


      }
   }
}
