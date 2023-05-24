/*
Entrada altura da pessoa 
Calcular o peso ideai usando a formual (72,7 * altura) - 58
*/
Console.WriteLine("Digite a sua altura: ");
string input = Console.ReadLine();

float altura; 
bool sucesso_a = float.TryParse(input , out altura);

if(sucesso_a = true){
    altura = (72.7f * altura) - 58;
    double  resultado_A = Math.Round(altura, 1);  //Math.round é um arredondamento para 1 casa decimal a ami
    Console.WriteLine("Seu pedo ideal é: " + resultado_A + " kg");

}