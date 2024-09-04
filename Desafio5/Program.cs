//Criar um algoritmo que receba um valor positivo inteiro
// e imprima a sequência Fibonacci até o valor lido.
// Por exemplo: caso o usuário insira o número 15,
// o programa deve imprimir na tela os números 
//0, 1, 1, 2, 3, 5, 8, 13.

//git init
//git status
//git add .
//git commit -m "Descrição do commit"
//git push

using System;

class program{
    static void Main(){
        Console.Write("Insira um numero para encerrar a sequencia fibonnaci: ");
        int numero = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;

        Console.Write(a);

        while(b <= numero){
            Console.Write(", " + b);

            int temp = a + b;
            a = b;
            b = temp;
        }   
    }
}
