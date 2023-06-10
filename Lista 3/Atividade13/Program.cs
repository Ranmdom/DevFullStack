/*
Programa que tem como dados de entrada a altura e o sexo de uma pessoa 
Calcular o peso ideal tendo em vista: 
Homens = (72.7 x h) - 58

Mulheres = (62,1 x h) - 44,7

Pedir o peso da pessoa e informar se está acima ou abaixo do peso. 
*/
Console.WriteLine("Informe sua altura: ");
float altura =float.Parse(Console.ReadLine());

Console.WriteLine("M -- Mulher");
Console.WriteLine("H -- Homem");
Console.WriteLine("Infomre se você é homem ou mulher: ");
string input = Console.ReadLine();

Console.WriteLine("Informe o seu peso: ");
float peso = float.Parse(Console.ReadLine());

float peso_ideal;

if(input == "M" || input == "m"){
    
    peso_ideal = (62.1f * altura) - 44.7f;

    string Peso_Formatado = peso_ideal.ToString("F1");
    string Peso_formatado_P = peso.ToString("F1");
    Console.WriteLine("Peso ideal: " + Peso_Formatado);
    Console.WriteLine("Seu peso: " + Peso_formatado_P);
    if(peso < peso_ideal){
        Console.WriteLine("Você está abaixo do peso ideial");
    }else if(peso == peso_ideal){
        Console.WriteLine("Você está no peso ideial");
    }else{
        Console.WriteLine("Você está acima do peso");
    }

}else if(input == "H" || input == "h"){
    
    peso_ideal = (72.7f * altura) - 58;
    string Peso_Formatado = peso_ideal.ToString("F1");
    string Peso_formatado_P = peso.ToString("F1");
    Console.WriteLine("Peso ideal: " + Peso_Formatado);
    Console.WriteLine("Seu peso: " + Peso_formatado_P);
    if(peso < peso_ideal){
        Console.WriteLine("Você está abaixo do peso ideial");
    }else if(peso == peso_ideal){
        Console.WriteLine("Você está no peso ideial");
    }else{
        Console.WriteLine("Você está acima do peso");
    }

}else{
    Console.WriteLine("Entrada inválida por favor digite apenas as letras descritas");
    return;
}