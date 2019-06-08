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
            double numero1 = 0;
            double numero2 = 0;
            int opcion;

            IOperacion operacion = new Suma(); //Aqui aplicariamos el polimorfismo

            Console.WriteLine("Introduzca 1- para sumar, 2 - para restar, 3 - para multiplicar, 4- para dividir");
            opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ahora introduzca el primer valor");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ahora introduzca el segundo valor");
            numero2 = Convert.ToDouble(Console.ReadLine());

            switch (opcion)
            {
                case 1: 
                    operacion = new Suma();
                    operacion.calcular(numero1,numero2);
                    operacion.mostrar();
                    break;
                case 2:
                    operacion = new Resta();
                    operacion.calcular(numero1, numero2);
                    operacion.mostrar();
                    break;
                case 3:
                    operacion = new Multiplicacion();
                    operacion.calcular(numero1, numero2);
                    operacion.mostrar();
                    break;
                case 4:
                    operacion = new Division();
                    operacion.calcular(numero1, numero2);
                    operacion.mostrar();
                    break;
                default:
                    break;
            }
        }
    }
}
