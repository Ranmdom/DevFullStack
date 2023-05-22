/*
Programa que le a idade de uma pessoa expressa em anos,meses e dias, 
e digitar a idade apenas em dias. 
Ano = 365 dias 
meses = 30 dias; 
*/
//expressar melhor uma variável direto no ReadLine 
int anos,meses,dias;

Console.WriteLine("Digite sua idade em anos: ");
string input_A = Console.ReadLine();

Console.WriteLine("Digite sua idade em meses: ");
string input_M = Console.ReadLine();

Console.WriteLine("Digite sua idade em dias: ");
string input_D = Console.ReadLine();

//Construção da validação de cada um 
bool sucesso_anos = int.TryParse(input_A, out anos);
bool sucesso_meses = int.TryParse(input_M, out meses);
bool sucesso_dias = int.TryParse(input_D, out dias);

if(sucesso_anos && sucesso_meses && sucesso_dias){
    //int idade_em_dias = calcularIdade(anos,meses,dias);
    int idade_A = anos * 365;
    int idade_M = meses * 30;
    int idade_D = dias; 
    Console.WriteLine("A idade expressa de anos em dias é: " + idade_A);
    Console.WriteLine("A idade expressa de meses em dias é: " + idade_M);
    Console.WriteLine("A idade em dias é: " + idade_D);

}
else{
    Console.WriteLine("Entrada Inválida, por favor digite apenas números inteiros");
    
}



