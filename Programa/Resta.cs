using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    class Resta : IOperacion
    {
        private double resultado = 0;

        private ArrayList resultadosArrayList = new ArrayList();

        public void calcular(double numero1, double numero2)
        {
            resultado = numero1 - numero2;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la resta es {0}", resultado);
            resultadosArrayList.Add(resultado);
        }

        public void MuestraResultados()
        {
            foreach (double resultado in resultadosArrayList)
                Console.WriteLine(resultado);
        }
    }
}
