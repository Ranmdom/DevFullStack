
Console.WriteLine("Digite o primeiro lado do triângulo: ");
float Lado1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo lado do triângulo: ");
float Lado2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro lado do triângulo: ");
float Lado3 = float.Parse(Console.ReadLine());

if(Lado1 + Lado2 > Lado3 && Lado2 + Lado3 > Lado1 && Lado1 + Lado3 > Lado2){
    if(Lado1 == Lado2 && Lado2 == Lado3){

        Console.WriteLine("É um triângulo equilátero");

    }else if(Lado1 == Lado2 || Lado2 == Lado3 || Lado1 == Lado3){

        Console.WriteLine("É um triângulo isósceles");

    }else{

        Console.WriteLine("É um triângulo escaleno");
    }
}
else{

    Console.WriteLine("Não é possível formar um triângulo com esses lados");
}

