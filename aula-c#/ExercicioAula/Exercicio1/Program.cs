/*Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e ordenar do menor para o maior.

1. Desenvolver o algoritmo de ordenação (Bubble Sort);
2. Utilizar uma função em C# para ordenação;*/

int[] vetor = new int[10];
int aux;
bool troca = false;
int vetorTamanho = vetor.Length - 1;
Random numAleatorio = new Random();

for(int i = 0; i < vetor.Length; i++){
    vetor[i] = numAleatorio.Next(1, 20);
}

for(int i = 0; i < vetor.Length ; i++){
    Console.Write(vetor[i] + " ");
}

do{
    troca = false;
for(int i = 0; i < vetorTamanho; i++){
    if(vetor[i]>vetor[i + 1]){
        aux = vetor[i];
        vetor[i] = vetor[i + 1];
        vetor[i + 1] = aux; 
        troca = true;
        vetorTamanho--;
    }else{
        continue;
    }
}
}while(troca == true);

Console.WriteLine(" ");

for(int i = 0; i < vetor.Length ; i++){
    Console.Write(vetor[i] + " ");
}