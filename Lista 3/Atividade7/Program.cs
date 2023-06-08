/*
Programa que pergunte o preço de três produtos e informar qual
o produto que deve comprar.
Decisão: sempre pelo mais barato 
Sempre pelo menor ,nunca pelo maior( mais caro e mais barato )
*/
Console.WriteLine("Digite aqui o preço do primeiro produto: ");
float preco1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite aqui o preço do segundo produto: ");
float preco2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite aqui o preço do terceiro produto: ");
float preco3 = float.Parse(Console.ReadLine()); 


if(preco1 < preco2 && preco1 < preco3){
    
    Console.WriteLine("Compre o primeiro produto");
}else if(preco2 < preco1 && preco2 < preco3){
    Console.WriteLine("Compre o segundo produto");

}else if(preco3 < preco1 && preco3 < preco2){
    Console.WriteLine("Compre o terceiro produto");

}else{
    Console.WriteLine("Os três preços são em conta");
}