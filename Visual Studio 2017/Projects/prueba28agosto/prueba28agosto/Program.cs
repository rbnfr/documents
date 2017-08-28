using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba28agosto
{
    class Program
    {
        static void Main(string[] args)
        {
            //var caja = new Caja(); // Instancia de caja, no puede instanciarse.
            
            Caja CajaPrueba = Caja.InstanceCaja;
            CajaPrueba.Total += 100;
            CajaPrueba.Total += 90;
            CajaPrueba.Total += 20;

            Console.WriteLine(CajaPrueba.Total);
        }
    }
}
