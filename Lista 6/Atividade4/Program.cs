/*
Leia uma matriz 3 x 3 e imprima a soma dos valores contidos 
em sua diagonal principal  
*/

//Declaração da matriz 3 x 3 
int [,] matriz = new int [3,3];
int soma = 0;

//Ler a matriz 

for(int i = 0; i < 3; i++){
    for(int j = 0; j < 3; j++){

        Console.WriteLine($"Digite o valor para a posição [{i}, {j}]: ");
        matriz[i,j] = int.Parse(Console.ReadLine());

    }
}
//Mostrar a matriz: 

for(int i = 0; i < 3; i++){
    for(int j = 0; j < 3; j++){
        Console.WriteLine(matriz[i,j] + " ");
    }
    Console.WriteLine();
}

//Calcular a soma da diagonal principal 

int somaDiagonalPrincipal = 0;
for(int i = 0; i < 3; i++){

        somaDiagonalPrincipal += matriz[i,i];

}

Console.WriteLine($"A soma dos valores da diagonal principal é: {somaDiagonalPrincipal} ");