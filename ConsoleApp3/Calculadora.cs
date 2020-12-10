using System;
using System.Globalization;
using System.Collections.Generic;

namespace Projeto
{
     class Calculadora
     {
        public double Soma(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Soma(List<double> numeros)
        {
            double resultado = 0.0;
            foreach (double numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }

        public double Subtrai(List<double> numeros)
        {
            double primeiroNumero = numeros[0];
            for (int i = 1; i < numeros.Count; i++)
            {
                primeiroNumero -= numeros[i];
            }

            return primeiroNumero;
        }

        public double Multiplica(List<double> numeros)
        {
            double primeiroNumero = numeros[0];
            for (int i = 1; i < numeros.Count; i++)
            {
                primeiroNumero *= numeros[i];
            }
            return primeiroNumero;
        }

        public string Divide(List<double> numeros)
        {
            string resultado = "";
            double primeiroNumero = numeros[0];
            for (int i = 1; i < numeros.Count; i++)
            {
                if (numeros[i] == 0)
                {
                    resultado = "Impossível dividir por zero";
                    return resultado;
                }
                primeiroNumero /= numeros[i];
            }
            return primeiroNumero.ToString("F2", CultureInfo.InvariantCulture);
        }
        
     }
}