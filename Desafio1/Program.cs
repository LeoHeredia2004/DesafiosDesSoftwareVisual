using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Altura: ");
        float altura = float.Parse(Console.ReadLine());

        Console.Write("Base: ");
        float baseT = float.Parse(Console.ReadLine());

        float area = baseT * altura / 2;
        Console.WriteLine("Área do triângulo: " + area);
    }
}

