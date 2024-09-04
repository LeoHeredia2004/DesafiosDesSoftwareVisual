using System;

class program{
    static void Main(string[] args){
        Console.Write("Insira um valor em reais: ");
        float reais = float.Parse(Console.ReadLine());
        float dolar = reais / 5.17f;
        float euro = reais / 6.14f;
        float pesos = reais * 0.05f;

        Console.WriteLine($"Dolares: {dolar:F2}");
        Console.WriteLine($"Euros: {euro:F2}");
        Console.WriteLine($"Pesos: {pesos:F2}");
    }
}

