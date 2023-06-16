int nota; 

do{
    Console.WriteLine("Digite uma nota entre zero e dez: ");
    nota = int.Parse(Console.ReadLine());

    if(nota < 0 || nota > 10){

        Console.WriteLine("Valor inválido! Digite novamente");

    }
}while(nota < 0 || nota > 10);

Console.WriteLine("Nota Válida: " + nota);
