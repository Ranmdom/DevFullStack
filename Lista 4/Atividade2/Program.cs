//Declaração de variaveis
int populacaoA = 80000;
double taxaCrescimentoA = 0.03;
int populacaoB = 200000;
double taxaCrescimentoB = 0.015;
int anos = 0;

//Estrutura condicional 
while(populacaoA < populacaoB){

    populacaoA += (int)(populacaoA * taxaCrescimentoA);
    populacaoB += (int)(populacaoB * taxaCrescimentoB);
    anos++;

}

Console.WriteLine("Serão necessários " + anos + " anos para que a população do país A ultrapasse ou iguale a população do população do país B.");
