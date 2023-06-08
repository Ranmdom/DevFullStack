/*
Programa para o cálculo de uma folha de pagamento, sabendo que os descontos são do imposto de renda 
que depende do salário bruto. 
Sindicato = 3% ou 0.03 (desconto); 
FGTS = 11% ou 0.11;  (mas não é descontado)
INSS = 10% ou 0.10(vai ser descontado)
salario liquido = salario bruto - descontos

Desconto do IR: 
 - Salario bruto até 900 -- Isento
 - Salario bruto até 1500 -- desconto 5% ou 0.05
 - Salario bruto até 2500 -- desconto 10% ou 0.10
 - Salario bruto acima de 2500 -- desconto 20% ou 0.20

 imprimir na tela as informações dispostas conforme o exemplo abaixo. 
 Nele o valor da hora é de 5 reais - 1h , e a quantidade de horas são 220h
 Usar apenas um bloco de print no final. 

*/

double valor_Hora, salarioBruto, sindicato, fgts,inss, ir,salario_liquido,total_Descontos;

int quantidadeHoras = 220;

valor_Hora = 5.0;
salarioBruto = valor_Hora * quantidadeHoras;

sindicato = salarioBruto * 0.03;
fgts = salarioBruto * 0.11;
inss = salarioBruto * 0.10;

if(salarioBruto <= 900){
    ir = 0.0;
}else if(salarioBruto <= 1500){
    ir = salarioBruto * 0.05;
}else if(salarioBruto <= 2500){
    ir = salarioBruto * 0.10;
}else{
    ir = salarioBruto * 0.20;
}

total_Descontos = inss + ir;
salario_liquido = salarioBruto - total_Descontos;
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Folha de pagamento: ");
Console.WriteLine("Salário Bruto: R$" + salarioBruto+",00");
Console.WriteLine("FGTS:          R$" + fgts+",00");
Console.WriteLine("INSS:          R$" + inss+",00");
Console.WriteLine("IR:            R$"+ ir+",00");
Console.WriteLine("Total de descontos: R$" + total_Descontos+",00");
Console.WriteLine("Salário Liquido: R$" + salario_liquido+",00");
Console.WriteLine("-----------------------------------------------");