using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1DAWN
{
    class EjemploDeMiCafetera //16
    {
        static void main()
        {
            Cafetera mi_cafetera_ejemplo = new Cafetera("EspressoBarista", "Procoffee", 0.6, 7);

            Console.WriteLine(mi_cafetera_ejemplo.CantidadAgua);
            Console.WriteLine(mi_cafetera_ejemplo.ConsumoCapsulas(5));
            Console.WriteLine(mi_cafetera_ejemplo.Totaldecapsulas);
            Console.WriteLine(mi_cafetera_ejemplo.ConsumoAgua(5));
            Console.WriteLine(mi_cafetera_ejemplo.CantidadAgua);
            mi_cafetera_ejemplo.LlenarDeposito(0.5);
            Console.WriteLine(mi_cafetera_ejemplo.CantidadAgua);
            mi_cafetera_ejemplo.ReponerCapsulas(3);
            Console.WriteLine(mi_cafetera_ejemplo.Totaldecapsulas);
        }
    }
}
