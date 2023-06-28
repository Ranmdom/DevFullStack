//Declarar variaveis 

int [,] matriz = new int [3,3];
int somaDiagonalSecundaria = 0;

//Ler a matriz 
for(int i = 0; i < 3; i++){
    for(int j = 0; j < 3; j++){

        Console.WriteLine($"Digite o valor da posição [{i},{j}]: ");
        matriz[i,j] = int.Parse(Console.ReadLine());

    }
}

//Imprimir a matriz 
for(int i = 0; i < 3; i++){
    for(int j = 0; j < 3; j++){

        Console.Write(matriz[i,j].ToString().PadLeft(2) + " ");

    }

    Console.WriteLine();
}

//A soma da diagonal secundária
for(int j = 0; j < 3; j++){

    somaDiagonalSecundaria += matriz[j,j];

}

Console.WriteLine($"A soma da diagonal secundária: {somaDiagonalSecundaria}");

