/*
Faça um programa que declare uma matriz de tamanho 5 x 5. Preencha com 1 a diagonal 
principal e 0 os demais elementos. Ao final, escreva a matriz obtida na tela.

se i for igual a j então vai ser 1 se não vai ser 0

*/


//Declaração de variaveis

int [,] matriz = new int[5,5];

//Preecnher a matriz 

//Linha 
for(int i = 0; i < 5; i++){
    //Coluna
    for(int j = 0; j < 5; j++){

        if(i == j){

            matriz[i,j] = 1;

        }
        else{

            matriz[i,j] = 0;

        }


    }
}

//Mostrar a matriz

Console.WriteLine("Matriz Resultante: ");
for(int i = 0; i < 5; i++){
    for(int j = 0; j < 5; j++){

        Console.WriteLine(matriz[i,j].ToString().PadLeft(2) + " "); // Assim fica tudo numa linha só 
    } // PadLeft adiciona espaços a esquerda de cada elemento o PadRight ( na direita)
 Console.WriteLine(" "); // Adicionando coluna

}


