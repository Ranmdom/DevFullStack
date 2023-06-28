/*
Faça um programa que permite ao usuário entrar com uma matriz de tamanho 3 x 3 de numeros
inteiros. Em seguida, calcule um vetor contendo três posições, em que cada posição deverá 
armazenar a soma dos números de cada coluna da matriz. Exiba na tela esse array. Por exemplo
a matriz: 

5 -810
1  215
25 107

Deverá gerar o vetor: 

31 4 32
*/

//Declaração de variaveis
int [,] matriz = new int[3,3];
int [] vetorSomaColuna = new int[3];
int soma = 0;

//Ler a matriz 
for(int i = 0; i < 3; i++){

    for(int j = 0; j < 3; j++){

        Console.WriteLine($"Digite o valor para a posição [{i},{j}]: ");
        matriz [i,j] = int.Parse(Console.ReadLine());

    }
}

//Calculo o vetor da soma de colunas
for(int j = 0; j < 3; j++){
    soma = 0; 
    
    for(int i = 0; i < 3; i++){
        soma += matriz[i,j];

    }
    vetorSomaColuna[j] = soma;
}

//Exibir o vetor da soma das colunas
Console.WriteLine("Vetor da soma das colunas: ");
foreach(int valor in vetorSomaColuna){
    Console.Write(valor + " ");
}
Console.WriteLine();
