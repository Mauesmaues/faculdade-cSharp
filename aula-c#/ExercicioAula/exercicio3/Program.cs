// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um numero para saber seu fatorial");
int num = Convert.ToInt32(Console.ReadLine());
int fatorial = 0;
for (int i = 0; i <= num; i++){
    fatorial += i;
}
Console.WriteLine(fatorial);
