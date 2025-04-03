// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um numero inteiro para saber a tabuada dele: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i <= 10; i++){
    Console.WriteLine($"[num] x [i] = " + num * i);
}
