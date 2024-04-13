using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculadora;

namespace calculadora
{
    public class Calculadora
    {
        public string Marca { get; set; }
        public string Serie { get; set; }

        public int suma(int num1, int num2)
        {
            return num1 + num2;
        }

        public int resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int multi(int num1, int num2)
        {
            return num1 * num2;
        }

        public int div(int num1, int num2)
        {
            return num1 / num2;
        }

        public class CalculadoraCientifica : Calculadora
        {
            public string color {  get; set; }
            public double Potencia(double num, double exponente)
            {
                return Math.Pow(num, exponente);
            }

            public double Raiz(double num)
            {
                return Math.Sqrt(num);
            }

            public double Modulo(double num, double divisor)
            {
                return num % divisor;
            }

            public double Logaritmo(double num, double baseLog)
            {
                return Math.Log(num, baseLog);
            }
        }
    }
}