/*
Distribuidor = 28% = 0.28 
Imposto = 45% = 0.45
Carro novo = Custo_Fabrica + Per_Distribuidor + Impostos
*/
Console.WriteLine("Informe o custo de fabrica do carro: ");
string input = Console.ReadLine();
float Impostos = 0.45f;
float Per_Distribuidor = 0.28f;
float Custo_Fabrica = Impostos + Per_Distribuidor;
float Carro_novo,Carro_F;
bool sucesso = float.TryParse(input, out Carro_novo);

if(sucesso){
    Carro_F = Carro_novo * Custo_Fabrica;
    Carro_novo = Carro_novo + Carro_F;

    Console.WriteLine("Custo final: " + Carro_novo);
}
else{
    Console.WriteLine("Entrada inváida, por favor digite apenas números");
}



