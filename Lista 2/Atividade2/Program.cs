/*
Programa que peça 4 notas e mostre a média delas 
Média = (n1 + n2 + n3 + n4) / n  
Exemplo = 10 + 10 + 10 + 10 / 4 = 40/4 = 10 
*/
Console.WriteLine("Informe a primeira nota: ");
string input1 = Console.ReadLine();

Console.WriteLine("Informe a segunda nota: ");
string input2 = Console.ReadLine();

Console.WriteLine("Informe a terceira nota:");
string input3 = Console.ReadLine();

Console.WriteLine("Informe a quarta nota: ");
string input4 = Console.ReadLine();

float nota1 ,nota2 ,nota3 ,nota4, media;

//verificação
bool sucesso_n1 = float.TryParse(input1, out nota1);
bool sucesso_n2 = float.TryParse(input2, out nota2);
bool sucesso_n3 = float.TryParse(input3, out nota3);
bool sucesso_n4 = float.TryParse(input4, out nota4);

if(sucesso_n1 && sucesso_n2 && sucesso_n3 && sucesso_n4){
    media = (nota1 + nota2 + nota3 + nota4) / 4; 
    Console.WriteLine("--------------------------------");
    Console.WriteLine("A média das notas foi: " + media);
    Console.WriteLine("---------------------------------");
}
else{
    Console.WriteLine("Entrada inválida, por favor digite apenas números");
}

