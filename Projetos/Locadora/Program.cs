using Locadora.Classe;
using Locadora.Classes;

List<Promotor> promotores = new List<Promotor>(){
    new Promotor { Nome = "João", Sobrenome = "Silva", Telefone = "12345-6789", CartaoDeVisita = "Cartão A",Local = "ITA" },
    new Promotor { Nome = "Maria", Sobrenome = "JUlia", Telefone = "12345-6789",CartaoDeVisita = "Cartão B", Local = "ITA" },
    new Promotor {Nome = "Pedro", Sobrenome = "Costa", Telefone = "12345-6789", CartaoDeVisita = "Cartão C", Local = "SESC"}
};

        //Lista 2 - Escritores
        List<Escritor> escritores = new List<Escritor>(){
    new Escritor{ Nome = "Lucas", Sobrenome = "Pereira", Biografia = "Escritor de livro", Tipo = "Livro"},
    new Escritor{ Nome = "Mauro", Sobrenome = "Rocha", Biografia = "Escritor de blog", Tipo = "Blog"}
};

        //List 3 - BodyBuilders
        List<BodyBuilder> bodyBuilders = new List<BodyBuilder>(){
    new BodyBuilder { Nome = "Rodrigo", Sobrenome = "Mendes", Peso = 92.0, QuantosKgPega = 120.2,  Tipo = "Fisiculturista"},
    new BodyBuilder { Nome = "Silva", Sobrenome = "Rocha", Peso = 78.0, QuantosKgPega = 90.0, Tipo = "Calistenia"}
};

        //List 4 - Vloggers 
        List<Vlogger> vloggers = new List<Vlogger>(){
    new Vlogger { Nome = "Carlos", Sobrenome = "Machado", TipoDeCanal = "Viagens", QuantasCamerasUsa = 3},
    new Vlogger { Nome = "Fernanda", Sobrenome = "Ribeiro", TipoDeCanal = "Dia a dia", QuantasCamerasUsa = 1}
};

        //Printando as informações 
        foreach (var Promotor in promotores)
        {
            Console.WriteLine($"Promotor: {Promotor.Nome} {Promotor.Sobrenome}, Telefone: {Promotor.Telefone}, Cartão de visita: {Promotor.CartaoDeVisita}, Local: {Promotor.Local}");
        }

        foreach (var Escritor in escritores)
        {
            Console.WriteLine($"Escritor: {Escritor.Nome} {Escritor.Sobrenome}, Biografia: {Escritor.Biografia},Tipo: {Escritor.Tipo}");
        }

        foreach (var BodyBuilder in bodyBuilders)
        {
            Console.WriteLine($"BodyBuilder: {BodyBuilder.Nome} {BodyBuilder.Sobrenome}, Peso: {BodyBuilder.Peso}, QuantosKGPega: {BodyBuilder.QuantosKgPega},Tipo: {BodyBuilder.Tipo}");
        }

        foreach (var Vlogger in vloggers)
        {
            Console.WriteLine($"Vlogger: {Vlogger.Nome} {Vlogger.Sobrenome}, TipoDeCanal: {Vlogger.TipoDeCanal},Câmeras: {Vlogger.QuantasCamerasUsa}");
        }

        using (var context = new LocadoraContext())
{
    // Adicionando um novo cliente
    var cliente = new Cliente { Nome = "João Silva", CPF = "123.456.789-00" };
    context.Clientes.Add(cliente);
    context.SaveChanges();

    // Adicionando um novo filme
    var filme = new Filme { Titulo = "Matrix", AnoLancamento = 1999, EstaDisponivel = true };
    context.Filmes.Add(filme);
    context.SaveChanges();

    // Realizando um empréstimo
    var emprestimo = new Emprestimo
    {
        DataEmprestimo = DateTime.Now,
        DataDevolucaoPrevista = DateTime.Now.AddDays(7),
        ClienteId = cliente.ClienteId,
        FilmeId = filme.FilmeId
    };
    context.Emprestimos.Add(emprestimo);
    filme.EstaDisponivel = false; // Marcar filme como indisponível após o empréstimo
    context.SaveChanges();
}