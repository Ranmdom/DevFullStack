using System;
using Atividade1;

Retangulo retangulo = new Retangulo();
Console.WriteLine("Calcular Area e Perimetro de um cômodo: ");

Console.WriteLine("\nInforme a base: ");
double Base = double.Parse(Console.ReadLine());

Console.WriteLine("\nInforme a altura: ");
double Altura = double.Parse(Console.ReadLine());

//Passando os valores do metodo para a variavel local e vise versa
retangulo.Base = Base;
retangulo.Altura = Altura;


double Area = retangulo.CalcularArea();
double Perimetro = retangulo.CalcularPerimetro();

Console.WriteLine($"Area total: {Area.ToString("F2")}");
Console.WriteLine($"Perimetro total: {Perimetro.ToString("F2")}");

Console.WriteLine("Informar um novo lado? \n(S)im \n(N)ão");
char opcao = Console.ReadKey().KeyChar;

if(opcao == 'S' || opcao == 's'){
    Console.WriteLine("Infome o novo lado da Base: ");
    double novaBase = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a nova altura: ");
    double novaAltura = double.Parse(Console.ReadLine());

    retangulo.Base = novaBase;
    retangulo.Altura = novaAltura;

    Area = retangulo.CalcularArea();
    Perimetro = retangulo.CalcularPerimetro();

    Console.WriteLine($"Area total: {Area.ToString("F2")}");
    Console.WriteLine($"Perimetro total: {Perimetro.ToString("F2")}");
}else{
    Console.WriteLine("Até mais!");
}