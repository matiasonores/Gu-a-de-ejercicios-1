//Hacer un programa para ingresar por teclado los metros cuadrados totales de
//un predio y los metros cuadrados cubiertos; luego calcular y mostrar por
//pantalla el porcentaje de metros cuadrados cubiertos y el porcentaje de
//metros cuadrados descubiertos.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
   class Program
   {
      static void Main(string[] args)
      {
         int mct, mcc,mcd;

         Console.WriteLine("Ingrese los metros cuadrados totales del predio:");
         mct = int.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese los metros cuadrados cubiertos:");
         mcc = int.Parse(Console.ReadLine());
         mcd = mct - mcc;
         double porcentajeDescubierto = (mcd*100) / mct;
         double porcentajeCubierto = mcc*100 / mct;
         Console.WriteLine("Porcentaje de metros cuadrados descubierto:{0}",porcentajeDescubierto);
         Console.WriteLine("Porcentaje de metros cuadrados cubierto:{0}", porcentajeCubierto);
         Console.ReadKey();

      }
   }
}
