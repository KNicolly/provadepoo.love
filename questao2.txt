using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double b = double.Parse(Console.ReadLine());

        double soma = a + b;
        double subtracao = a - b;
        double multiplicacao = a * b;
        double divisao = a / b;

        Console.WriteLine($"Soma = {soma}");
        Console.WriteLine($"Subtração = {subtracao}");
        Console.WriteLine($"Multiplicação = {multiplicacao}");
        Console.WriteLine($"Divisão = {divisao}");


    }
}
