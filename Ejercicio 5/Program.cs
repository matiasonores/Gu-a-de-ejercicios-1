//Una casa de computación paga a sus empleados un sueldo fijo de ARS15000
//más una comisión del 5% sobre el total facturado por cada empleado. Hacer un
//programa para ingresar el total facturado por un empleado y que luego calcule
//y emita por pantalla el sueldo total a cobrar por el mismo.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
   class Program
   {
      static void Main(string[] args)
      {
         int sueldoFijo = 15000;
         double totalFacturado, sueldoTotal;
         Console.WriteLine("Ingrese el total facturado:");
         totalFacturado = double.Parse(Console.ReadLine());
         sueldoTotal = sueldoFijo + totalFacturado * 1.05;
         Console.WriteLine("El sueldo total es: {0}",sueldoTotal);
         Console.ReadKey();
         

      }
   }
}
