
//Declaração de variavel 

int[,] matriz = new int [4, 4];
int maiorValor = int.MinValue;
int linhaMaiorValor = 0;
int colunaMaiorValor = 0;

//Leitura da matriz 

for(int i = 0; i < 4; i++){

    //Segunda area para formar a coluna 

    for(int j = 0; j < 4; j++){
        Console.WriteLine($"Digite o valor para a posição [{i},{j}]: ");
        matriz[i , j] = int.Parse(Console.ReadLine());

        if(matriz[i,j] > maiorValor){

            maiorValor = matriz[i,j];
            linhaMaiorValor = i;
            colunaMaiorValor = j;
        }

    }
}

//Impressão e localização 

//Maior Valor encontrado

Console.WriteLine($"O maior valor encontrado foi {maiorValor}");
//Localização de linha e coluna 

Console.WriteLine($"Localizado na linha {linhaMaiorValor} e coluna {colunaMaiorValor}");