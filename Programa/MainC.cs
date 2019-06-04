using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    class MainC
    {
        static void Main(string[] args)
        {
            Suma suma = new Suma();
            suma.calcular(3,4);
            suma.mostrar();
            Console.ReadKey();
        }
    }
}
