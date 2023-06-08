/*
Programa de aumento de salário aos seus colaboradores e lhe contrataram para desenvolver
o programa que calculará os reajustes. Faça um programa que recebe o salário de um colaborador 
e faça o reajuste segundo o seguinte critério, baseado no salário atual: 

- Salarios até 280,00 reais (incluindo aumento de 20%)
- Salarios entre 280,00 e 700,00 (aumento de 15%)
- Salários entre 700,00 reais e 1500,00 reais(aumento de 10%)
- Salários entre 1500,00 reais em diante aumento de 5%

Informar o salario antes do reajuste 
Percentual de aumento aplicado 
Valor do aumento 
Novo salario ,após o aumento
*/
Console.WriteLine("Informe o seu salário: ");
double salario = double.Parse(Console.ReadLine());

if(salario <= 280.00 || salario <= 280){
     double novo_salario, reajuste; 
     reajuste = salario * 0.20; 
     novo_salario = salario + reajuste;

     Console.WriteLine("Salário antes do reajuste: " + salario + " reais");
     Console.WriteLine("Percentual do aumento aplicado: 20%");
     Console.WriteLine("Valor do aumento: " + reajuste + " reais");
     Console.WriteLine("Novo salário: " + novo_salario + " reais");
}
else if(salario >= 280.00 || salario <= 700.00 || salario >= 280 || salario <= 700){
    double novo_salario, reajuste;
    reajuste = salario * 0.15;
    novo_salario = salario + reajuste;

     Console.WriteLine("Salário antes do reajuste: " + salario + " reais");
     Console.WriteLine("Percentual do aumento aplicado: 15%");
     Console.WriteLine("Valor do aumento: " + reajuste + " reais");
     Console.WriteLine("Novo salário: " + novo_salario + " reais");

}
else if(salario >= 700.00 || salario <= 1500.00 || salario >= 700 || salario <= 1500){
    double novo_salario, reajuste;
    reajuste = salario * 0.10;
    novo_salario = salario + reajuste;

     Console.WriteLine("Salário antes do reajuste: " + salario + " reais");
     Console.WriteLine("Percentual do aumento aplicado: 10%");
     Console.WriteLine("Valor do aumento: " + reajuste + " reais");
     Console.WriteLine("Novo salário: " + novo_salario + " reais");
}
else if(salario >= 1500.00 || salario >= 1500){
    double novo_salario, reajuste;
    reajuste = salario * 0.05;
    novo_salario = salario + reajuste;

     Console.WriteLine("Salário antes do reajuste: " + salario + " reais");
     Console.WriteLine("Percentual do aumento aplicado: 5%");
     Console.WriteLine("Valor do aumento: " + reajuste + " reais");
     Console.WriteLine("Novo salário: " + novo_salario + " reais");

}


