using System;
class program{
    static void Main(){
        Console.Clear();
        Console.Write("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if(idade < 13){
             Console.Write("Criança");
        }else if(idade >= 13 && idade < 18){
            Console.Write("Adolescente");
        }else if(idade >= 18 && idade < 60){
            Console.Write("Adulto");
        }else if(idade >= 60){
            Console.Write("Idoso");
        }

    }
}
