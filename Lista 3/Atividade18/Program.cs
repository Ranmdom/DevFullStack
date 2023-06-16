int contador = 0;

Console.WriteLine("Responda 'Sim' ou 'Não' para as seguintes perguntas:");

Console.WriteLine("Telefonou para a vítima?");
string resposta1 = Console.ReadLine();
if (resposta1.ToLower() == "sim")
{
    contador++;
}

Console.WriteLine("Esteve no local do crime?");
string resposta2 = Console.ReadLine();
if (resposta2.ToLower() == "sim")
{
    contador++;
}

Console.WriteLine("Mora perto da vítima?");
string resposta3 = Console.ReadLine();
if (resposta3.ToLower() == "sim")
{
    contador++;
}

Console.WriteLine("Devia para a vítima?");
string resposta4 = Console.ReadLine();
if (resposta4.ToLower() == "sim")
{
    contador++;
}

Console.WriteLine("Já trabalhou com a vítima?");
string resposta5 = Console.ReadLine();
if (resposta5.ToLower() == "sim")
{
    contador++;
}

if (contador == 2)
{
    Console.WriteLine("Suspeita");
}
else if (contador >= 3 && contador <= 4)
{
    Console.WriteLine("Cúmplice");
}
else if (contador == 5)
{
    Console.WriteLine("Assassino");
}
else
{
    Console.WriteLine("Inocente");
}

