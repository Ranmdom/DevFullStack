/*
Programa que leia um número e exiba o dia correspondente da semana. 
1- Domingo 
2- Segunda e etc
*/

Console.WriteLine("Escreva um número de 1 a 7: ");
int numero = int.Parse(Console.ReadLine());
string DiaSemana = ""; 

switch(numero){
    case 1: 
      DiaSemana = "Domingo";
      break;
    
    case 2: 
      DiaSemana = "Segunda-Feira";
      break;

    case 3: 
      DiaSemana = "Terça-Feira";
      break;
    
    case 4: 
      DiaSemana = "Quarta-Feira";
      break;

    case 5: 
      DiaSemana = "Quinta-Feira";
      break; 
    
    case 6: 
      DiaSemana = "Sexta-Feira";
      break;

    case 7: 
      DiaSemana = "Sábado";
      break;
}

Console.WriteLine("O dia da semana é: " + DiaSemana + " e o número do dia é: "+numero);

