int tamanho = 100;
int[] vetor = new int[tamanho];

Random random = new Random();

for(int i = 0;i < vetor.Length; i++){
    vetor[i] = random.Next(100);
}

for(int i = 0;i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}

for(int i = 0;i < vetor.Length - 1;i++){
    if(vetor[i] > vetor[i + 1]){
        
        int aux = vetor[i];
        vetor[i] = vetor[i + 1];
        vetor[i + 1] = aux;
    }
}

Console.WriteLine(" ");
Console.WriteLine(" ");


for(int i = 0;i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}


