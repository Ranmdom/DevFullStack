/*
Algoritmo que leia três notas. 
Calular e escrever a media final com pesos 
Peso da nota 1 = 2 ,nota 2 = 3 e nota 3 = 5 / 10
N1 * 2 + N2 * 3 + n3 * 5 / 10 -- formula
*/

Console.WriteLine("Informe a primeira nota: ");
string primeiro = Console.ReadLine();
Console.WriteLine("Informe a segunda nota: ");
string segundo = Console.ReadLine();
Console.WriteLine("Informe a terceira nota: ");
string terceiro = Console.ReadLine();

float nota1, nota2, nota3, nota_Final;

bool S_primeiro = float.TryParse(primeiro, out nota1);
bool S_segundo = float.TryParse(segundo, out nota2);
bool S_terceiro = float.TryParse(terceiro, out nota3);

if(S_primeiro && S_segundo && S_terceiro){
    nota_Final = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10;

    Console.WriteLine("A média do aluno foi de: " + nota_Final);
}
else{
    Console.WriteLine("Entrada Inválida, por favor digite apenas números inteiros");
}