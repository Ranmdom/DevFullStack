/*
Altere o programa anterior permitindo ao usuário informar as populações e as taxas de crescimento iniciais 
Valide a entrada e permita repetir a operação.
*/
do{

    Console.WriteLine("Informe a população do páis A (valor inteiro): ");
    int populacaoA; 

    while(!int.TryParse(Console.ReadLine(),out populacaoA) || populacaoA <= 0){

        Console.WriteLine("População inválida. Por favor, informe um valor inteiro positivo.");

    }

    Console.WriteLine("Informe a taxa de crescimento do Páis A (em decimal): ");
    double taxaCrescimentoA;
    while(!double.TryParse(Console.ReadLine(), out taxaCrescimentoA)||taxaCrescimentoA <= 0){

        Console.WriteLine("Taxa de crescimento inválida. Por Favor, informe um valor decimal positivo.");

    }
    Console.WriteLine("Informe a população do país B(Valor inteiro): ");
    int populacaoB;
    while(!int.TryParse(Console.ReadLine(), out populacaoB) || populacaoB <= 0){

        Console.WriteLine("População inválida. Por favor, informe um valor inteiro positivo.");

    }
    Console.WriteLine("Informe a taxa de crescimento do país B (em decimal): ");
    double taxaCrescimentoB;
    while(!double.TryParse(Console.ReadLine(), out taxaCrescimentoB) || taxaCrescimentoB <= 0){

        Console.WriteLine("Taxa de crescimento inválida. Por favor, informe um valor decimal positivo.");

    }
    int anos = 0;

    while(populacaoA < populacaoB){

        populacaoA += (int)(populacaoA * taxaCrescimentoA);
        populacaoB += (int)(populacaoB * taxaCrescimentoB);
        anos++;

    }

    Console.WriteLine("Serão necessários " + anos + " anos para que a população do país A ultrapasse ou iguale a população do país B");

    Console.WriteLine("Dejeja repetir a operação? (S/N)");

}while(Console.ReadLine().ToUpper() == "S");
