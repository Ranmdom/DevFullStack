using System;
using Biblioteca.Classes;

//Lista 1 - Promotores

List <Promotor> promotores = new List<Promotor>(){
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
foreach (var Promotor in promotores){
    Console.WriteLine($"Promotor: {Promotor.Nome} {Promotor.Sobrenome}, Telefone: {Promotor.Telefone}, Cartão de visita: {Promotor.CartaoDeVisita}, Local: {Promotor.Local}");
}

foreach (var Escritor in escritores){
    Console.WriteLine($"Escritor: {Escritor.Nome} {Escritor.Sobrenome}, Biografia: {Escritor.Biografia},Tipo: {Escritor.Tipo}");
}

foreach (var BodyBuilder in bodyBuilders){
    Console.WriteLine($"BodyBuilder: {BodyBuilder.Nome} {BodyBuilder.Sobrenome}, Peso: {BodyBuilder.Peso}, QuantosKGPega: {BodyBuilder.QuantosKgPega},Tipo: {BodyBuilder.Tipo}");
}

foreach (var Vlogger in vloggers){
    Console.WriteLine($"Vlogger: {Vlogger.Nome} {Vlogger.Sobrenome}, TipoDeCanal: {Vlogger.TipoDeCanal},Câmeras: {Vlogger.QuantasCamerasUsa}");
}

//EF 

using (var context = new BibliotecaContext())
        {
            // Cadastrar livro
            var livro = new Livro { Titulo = "O Hobbit", Autor = "J.R.R. Tolkien", EstaDisponivel = true };
            context.Livros.Add(livro);
            context.SaveChanges();

            // Cadastrar usuário
            var usuario = new Usuario { Nome = "Carlos", Sobrenome = "Silva" };
            context.Usuarios.Add(usuario);
            context.SaveChanges();

            // Registrar empréstimo
            var emprestimo = new Emprestimo
            {
                LivroId = livro.LivroId,
                UsuarioId = usuario.UsuarioId,
                DataEmprestimo = DateTime.Now
            };
            livro.EstaDisponivel = false; // Marcar livro como indisponível
            context.Emprestimos.Add(emprestimo);
            context.SaveChanges();

            // Registrar devolução
            emprestimo.DataDevolucao = DateTime.Now;
            livro.EstaDisponivel = true; // Marcar livro como disponível novamente
            context.SaveChanges();
        }
