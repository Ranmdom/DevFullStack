/*
Programa que verifica se uma letra digitada é "F" ou "M" 
F - Feminino 
M - Masculino 
Se não for uma dessas letras sexo inválido
*/
Console.WriteLine("F - Feminino\nM - Masculino");
Console.WriteLine("Digite a Letra do sexo: ");
char letra = char.Parse(Console.ReadLine());

if(letra == 'F' || letra == 'f'){
    Console.WriteLine("Sexo Feminino");

}else if(letra == 'm' || letra == 'M'){
    Console.WriteLine("Sexo Masculino");
}else{
    Console.WriteLine("Sexo inválido");
}
