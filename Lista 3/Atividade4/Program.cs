// Programa que identifica se a letra digitada é vogal ou consoante
Console.WriteLine("Digite um letra: ");
char letra = char.Parse(Console.ReadLine());

if(letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U' || letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
{
        Console.WriteLine(letra + " é uma vogal");
}else{
    Console.WriteLine(letra + " é uma consoante");
}
