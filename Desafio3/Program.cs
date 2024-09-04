
using System;

class Program{
    static void Main(){
        Console.Clear();
        Console.Write("insira um número: ");
        float num1 = float.Parse(Console.ReadLine());
        Console.Write("Insira outro número: ");
        float num2 = float.Parse(Console.ReadLine());

        if(num1 > num2){
            Console.WriteLine($"O primeiro número({num1}) é maior que o segundo({num2})");
        }else if(num1 < num2){
            Console.WriteLine($"O primeiro número({num1}) é menor que o segundo({num2})");
        }else{
            Console.WriteLine("Os numeros são iguais");
        }
    }
}