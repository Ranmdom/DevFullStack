/*
Leia uma matriz de tamanho 4 x 4. Em seguida, conte e escreva na tela quantos valores 
maiores do que 10 ela possui. 
*/

//Declaração das variaveis 

int [,] matriz = new int[4,4];


Console.WriteLine("Digite os valores da matriz: ");

for(int i = 0; i < 4; i++){
    for(int j = 0; j < 4; j++){

        Console.WriteLine($"Digite o valor para a posição [{i}, {j}]: ");
        matriz[ i, j ] = int.Parse(Console.ReadLine());

    }
}

//Contagem dos valores maiores que 10
int count = 0;

for(int i = 0; i < 4; i++){

    for(int j = 0; j < 4; j++){

        if(matriz[i,j] > 10){
            count++;

        }
    }
}

Console.WriteLine($"A matriz possui {count} valores maiores do que 10");