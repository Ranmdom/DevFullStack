
Console.WriteLine("Informe a primeira nota do aluno: ");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe a segunda nota do aluno: ");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe a terceira nota do aluno: ");
float nota3 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3) / 3;

if(media == 10.0){

    Console.WriteLine("Aprovado com Distinção");
    Console.WriteLine("Media: {0:F1}", media);

}else if(media >= 7.0 && media < 10){

    Console.WriteLine("Aprovado");
    Console.WriteLine("Media: {0:F1}",media);

}else if(media <= 7.0){

    Console.WriteLine("Reprovado");
    Console.WriteLine("Media: {0:F1}", media);

}else{

    Console.WriteLine("Entrada inválida, por favor digite apenas números");

}


