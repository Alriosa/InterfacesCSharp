using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    class Suma : IOperacion //Aqui estoy implementando herencia
    {
        private double resultado = 0;

        private ArrayList resultados = new ArrayList();

        //Metodos que se deben implementar OBLIGATORIAMENTE
        public void calcular(double numero1, double numero2)
        {
            resultado = numero1 + numero2;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la suma es {0}" , resultados);
            resultados.Add(resultado);
        }

        public void MuestraResultados()
        {
            foreach(double resultado in resultados)
                Console.WriteLine(resultado);
        }
    }
}
