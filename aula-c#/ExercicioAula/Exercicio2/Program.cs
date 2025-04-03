Console.WriteLine("Digite um numero inteiro");
int numUm = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo numero inteiro");
int numDois = Convert.ToInt32(Console.ReadLine());


if(numUm > numDois){
    Console.WriteLine("O numero " + numUm + " eh maior");
}else {
    Console.WriteLine("O numero " + numDois + " eh maior");
}

int soma = numUm + numDois;

Console.WriteLine("A soma dos dois numero eh: " + soma);
