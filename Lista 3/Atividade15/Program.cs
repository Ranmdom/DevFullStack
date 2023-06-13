
Console.WriteLine("Digite a primeira nota do aluno: ");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota do aluno: ");
float nota2 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2) / 2;

if(media >= 9.0 && media <= 10.0){

    Console.WriteLine("Primeira nota: {0}" , nota1);
    Console.WriteLine("Segunda nota: {0}" , nota2);
    Console.WriteLine("Media: {0}" , media);
    Console.WriteLine("Conceito A");

}else if(media >= 7.5 && media <= 9.0){

    Console.WriteLine("Primeira nota: {0}" , nota1);
    Console.WriteLine("Segunda nota: {0}" , nota2);
    Console.WriteLine("Media: {0}" , media);
    Console.WriteLine("Conceito B");

}else if(media >= 6.0 && media <= 7.5){

    Console.WriteLine("Primeira nota: {0}" , nota1);
    Console.WriteLine("Segunda nota: {0}" , nota2);
    Console.WriteLine("Media: {0}" , media);
    Console.WriteLine("Conceito C");

}else if(media >= 4.0 && media <= 6.0){
    
    Console.WriteLine("Primeira nota: {0}" , nota1);
    Console.WriteLine("Segunda nota: {0}" , nota2);
    Console.WriteLine("Media: {0}" , media);
    Console.WriteLine("Conceito D");

}else if(media >= 4.0 && media <= 0.0){
    Console.WriteLine("Primeira nota: {0}" , nota1);
    Console.WriteLine("Segunda nota: {0}" , nota2);
    Console.WriteLine("Media: {0}" , media);
    Console.WriteLine("Conceito E");

}else{
    Console.WriteLine("Entrada inválida, digite apenas núemros");
}

