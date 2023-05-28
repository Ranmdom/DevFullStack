/*
Ler o número total de leitores de um munícipio 
numero de votos brancos, nulos e validos 
Calcular e escrever o percentual que cada um representa 
em relação total de leitores 

calculo = numero / 100 que vai dar a porcentagem
*/
Console.WriteLine("Informe o número total de leitores: ");
string input = Console.ReadLine();

Console.WriteLine("Informe o núemero de votos brancos: ");
string inputB = Console.ReadLine();

Console.WriteLine("Informe a quantidade de votos nulos: ");
string inputN = Console.ReadLine();

float leitores, votos_nulos, votos_brancos;

bool sucesso_leitores = float.TryParse(input, out leitores);
bool sucesso_brancos = float.TryParse(inputB, out votos_brancos);
bool sucesso_nulos = float.TryParse(inputN, out votos_nulos);

if(sucesso_brancos && sucesso_leitores && sucesso_nulos){
    
    float P_brancos = votos_brancos / leitores * 100;
    float P_nulos = votos_nulos / leitores * 100;

    Console.WriteLine("O total de leitores foi: " + leitores);
    Console.WriteLine("O percentual de votos brancos: " + P_brancos + "%");
    Console.WriteLine("O percentual de votos brancos: " + P_nulos + "%");

}
else{
    Console.WriteLine("Entrada Inválida, por favor digite apenas números ");
}

