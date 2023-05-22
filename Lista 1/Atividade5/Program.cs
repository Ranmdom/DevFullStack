Console.WriteLine("Digite o raio do circulo: ");
string input = Console.ReadLine();
//Area do circulo = pi * (raio * raio)
float raio;
float.TryParse(input, out raio);

float areaC = 3.14f * (raio * raio);
Console.WriteLine("A área do circulo é: " + areaC + " m²");
