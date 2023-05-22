Console.WriteLine("Digite um número: ");
string input = Console.ReadLine();

int numero; 
int.TryParse(input, out numero);

int antecessor = numero - 1; 
int sucessor = numero  + 1;


Console.WriteLine("Antecessor do valor: " + antecessor);
Console.WriteLine("Valor do número: " + numero);
Console.WriteLine("Sucessor do numero: " + sucessor);
