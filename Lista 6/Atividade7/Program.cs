
//Declaração de variaveis
int [,] notas = new int[10,3];
int countPiorNotaProva1 = 0;
int countPiorNotaProva2 = 0;
int countPiorNotaProva3 = 0;
int piorNota;

//Ler notas dos alunos 
for(int i = 0; i < 10; i++){
    for(int j = 0; j < 3; j++){

        Console.WriteLine($"Digite a nota do aluno {i + 1} na prova {j + 1}: ");
        notas[i,j] = int.Parse(Console.ReadLine());

    }
}

//Verificação de notas

for(int i = 0; i < 10; i++){

     piorNota = notas[i, 0];
    
    for(int j = 1; j < 3; j++){

        piorNota = notas[i,j];
    }
    //Estruturas condicionais 
    if(piorNota == notas[i,0]){
      
        countPiorNotaProva1++;
    }
    else if(piorNota == notas[i, 1]){

        countPiorNotaProva2++;

    }else if(piorNota == notas[i, 2]){
        
        countPiorNotaProva3++;
    }
}
//Exibir os resultados 

Console.WriteLine($"Número de alunos cuja a pior nota foi na primeira prova: {countPiorNotaProva1}");
Console.WriteLine($"Número de alunos cuja a pior nota foi na segunda prova: {countPiorNotaProva2}");
Console.WriteLine($"Número de alunos cuja a pior nota foi na terceira prova: {countPiorNotaProva3}");
