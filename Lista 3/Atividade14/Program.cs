//Area de variaveis

const float Peso_Limite = 50.0f;
const float Multa_Por_Quilo = 4.0f;

float Excesso = 0.0f;
float Multa = 0.0f;

//Area de Prints

Console.WriteLine("Informe a quantidade de KG de peixes pescados: ");
float peso = float.Parse(Console.ReadLine());

if(peso > Peso_Limite){
    Excesso = peso - Peso_Limite;
    Multa = Excesso * Multa_Por_Quilo;

    Console.WriteLine("Excesso de peso: {0} KG", Excesso);
    Console.WriteLine("Multa a ser paga: R$ {0}", Multa);
}
else{
    Console.WriteLine("Não houve excesso de peso.");
}



