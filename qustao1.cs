using System;

namespace ExemploVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroInteiro = 10;
            float numeroDecimal = 9.97f;
            string texto = "Trabalho de POO";
            bool valorBooleano = true;

            Console.WriteLine("O valor do número inteiro é: " + numeroInteiro);
            Console.WriteLine("O valor do número decimal é: " + numeroDecimal);
            Console.WriteLine("O texto é: " + texto);
            Console.WriteLine("O valor booleano é: " + valorBooleano);

            Console.ReadKey();
        }
    }
}