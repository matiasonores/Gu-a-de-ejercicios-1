//Una importante cadena de delivery cuenta con una promoción por tiempo
//limitado en la que otorga un 15% de descuento sobre el total del valor de la
//compra realizada. Hacer un programa para solicitar el monto total y el mismo
//calcule y emita por pantalla el total a cobrar con el descuento aplicado.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
   class Program
   {
      static void Main(string[] args)
      {
         double montoTotal;
         Console.WriteLine("Ingrese el valor de la compra realizada:");
         montoTotal = double.Parse(Console.ReadLine());
         Console.WriteLine("El valor de la compra, con el descuento del 15% aplicado es de: {0}", montoTotal*0.85);
         Console.ReadKey();
      }
   }
}
