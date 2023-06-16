Console.WriteLine("Digite o valor do saque (entre 10 e 600):");
int valorSaque = int.Parse(Console.ReadLine());

if (valorSaque < 10 || valorSaque > 600)
{
    Console.WriteLine("Valor de saque inválido. Digite um valor entre 10 e 600.");
}
else
{
    int notas100 = valorSaque / 100;
    int resto = valorSaque % 100;

    int notas50 = resto / 50;
    resto %= 50;

    int notas10 = resto / 10;
    resto %= 10;

    int notas5 = resto / 5;
    resto %= 5;

    int notas1 = resto;

    Console.WriteLine("Notas de 100: " + notas100);
    Console.WriteLine("Notas de 50: " + notas50);
    Console.WriteLine("Notas de 10: " + notas10);
    Console.WriteLine("Notas de 5: " + notas5);
    Console.WriteLine("Notas de 1: " + notas1);
}

