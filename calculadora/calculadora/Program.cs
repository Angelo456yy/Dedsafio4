using System;
using static calculadora.Calculadora;


namespace calculadora {
    class Program
    {
        static void Main(string[] args)
        {

            Calculadora calculadoran = new Calculadora();
            calculadoran.Marca = "Fast";
            calculadoran.Serie = "C33215";

            Console.WriteLine("Calculadora:");
            Console.WriteLine(calculadoran.Marca);
            Console.WriteLine(calculadoran.Serie);
            Console.WriteLine("Suma: " + calculadoran.suma(5, 3));
            Console.WriteLine("Resta: " + calculadoran.resta(20, 9));
            Console.WriteLine("Multiplicacion: " + calculadoran.multi(10, 3));
            Console.WriteLine("Division:" + calculadoran.div(50, 5)+"\n");


            CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica();
            calculadoraCientifica.Marca = "Casio";
            calculadoraCientifica.Serie = "S203350";
            calculadoraCientifica.color = "Negra";

            Console.WriteLine("\nCalculadora Científica:");
            Console.WriteLine(calculadoraCientifica.Marca);
            Console.WriteLine(calculadoraCientifica.Serie);
            Console.WriteLine(calculadoraCientifica.color);
            Console.WriteLine("Potencia: " + calculadoraCientifica.Pote(2, 4));
            Console.WriteLine("Raíz cuadrada: " + calculadoraCientifica.Raiz(81));
            Console.WriteLine("Módulo: " + calculadoraCientifica.Mod(100, 3));
            Console.WriteLine("Logaritmo: " + calculadoraCientifica.Loga(100, 10));
        }
    }
}