/*
Perguntar o quanto ganha por hora  
Numero de horas trabalhadas
Calcular e mostrar o total do salário no mês referido 
SAbendo que tem 11% de imposto de renda e 8% para INSS
Ou seja 11% (11/100 ou 0,11) e 8% (8/100 ou 0,08) e
5% (5/100 ou 0,05) para o sindicato.
Precisa ter: 
A) salario bruto = ganhar por hora * numero de horas
B) quanto pagou ao INSS 
C) Quanto pagou ao sindicato 
D) Salario liquido (salario bruto - descontos)
E) Calcular os descontos e o salario liquido 

*/
Console.WriteLine("Informe quantos reais ganha por hora: ");
string input_Qt = Console.ReadLine();

Console.WriteLine("Quantidade de horas trabalhadas: ");
string input_H = Console.ReadLine();

float salario,salario_bruto,salario_liquido,Horas_G,numero_H;
float descontos,INSS,Imposto,sindicato;

bool sucesso_Qt = float.TryParse(input_Qt, out Horas_G);
bool sucesso_H = float.TryParse(input_H, out numero_H);

if(sucesso_H && sucesso_Qt){
    salario_bruto = Horas_G * numero_H; 
    descontos = salario_bruto * (0.11f + 0.05f + 0.08f);
    salario_liquido = salario_bruto - descontos; 
    INSS = salario_bruto * 0.08f; 
    Imposto = salario_bruto * 0.11f;
    sindicato = salario_bruto * 0.05f;
    
    //arredondamento com math.round
    double arredondamento_b = Math.Round(salario_bruto,2);
    double arredondamento_L = Math.Round(salario_liquido,2);
    double arredondamento_I = Math.Round(INSS,1);
    double arredondamento_S = Math.Round(sindicato,1);
     
    Console.WriteLine("Salario bruto: " + arredondamento_b + " Reais");
    Console.WriteLine("INSS: " + arredondamento_I + " Reais");
    Console.WriteLine("Sindicato: " + arredondamento_S + " Reais");
    Console.WriteLine("Salario Líquido: " + arredondamento_L + " Reais");
    
}
else{
    Console.WriteLine("Entrada Inválida, por favor digite apeans números");
}

