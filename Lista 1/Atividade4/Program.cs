//Pedir a área do quadrado 
Console.WriteLine("Digite a dimensão do quadrado: ");
string input = Console.ReadLine();

//A = b.h ou b.b 
float b; 
float.TryParse(input, out b); //Converter a string em número 

float area = b * b;
Console.WriteLine("A área do quadrado é: " + area);

