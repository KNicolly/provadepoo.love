
using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());

        if (a > 0)
        {
            Console.WriteLine("Positivo");
        }
        else if (a == 0)
        {
            Console.WriteLine("Zero");
        }
        else
        {
            Console.WriteLine("Negativo");
        }

        
    }
}