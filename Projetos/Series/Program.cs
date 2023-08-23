using Microsoft.EntityFrameworkCore;
using Series.Classes;

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

 using (var context = new SistemaSeriesContext())
        {
            // Cadastrar usuário
            var usuario = new Usuario { Nome = "João", Senha = "12345" }; // Em uma aplicação real, use hashing para senhas!
            context.Usuarios.Add(usuario);
            context.SaveChanges();

            // Cadastrar série
            var serie = new Serie { Nome = "Exemplo de Série" };
            context.Series.Add(serie);
            context.SaveChanges();

            // Cadastrar episódio
            var episodio = new Episodio { Titulo = "Episódio Piloto", Temporada = 1, Numero = 1, SerieId = serie.SerieId };
            context.Episodios.Add(episodio);
            context.SaveChanges();

            // Registrar episódio assistido
            var episodioAssistido = new EpisodioAssistido { UsuarioId = usuario.UsuarioId, EpisodioId = episodio.EpisodioId, Data = DateTime.Now };
            context.EpisodiosAssistidos.Add(episodioAssistido);
            context.SaveChanges();

            // Listar usuários, séries, episódios e episódios assistidos
            var usuarios = context.Usuarios.ToList();
            Console.WriteLine("Usuários:");
            foreach (var u in usuarios)
            {
                Console.WriteLine($"ID: {u.UsuarioId}, Nome: {u.Nome}");
            }

            var series = context.Series.ToList();
            Console.WriteLine("\nSéries:");
            foreach (var s in series)
            {
                Console.WriteLine($"ID: {s.SerieId}, Nome: {s.Nome}");
            }

            var episodios = context.Episodios.Include(e => e.Serie).ToList();
            Console.WriteLine("\nEpisódios:");
            foreach (var e in episodios)
            {
                Console.WriteLine($"ID: {e.EpisodioId}, Título: {e.Titulo}, Série: {e.Serie.Nome}, Temporada: {e.Temporada}, Número: {e.Numero}");
            }

            var episodiosAssistidos = context.EpisodiosAssistidos.Include(ea => ea.Usuario).Include(ea => ea.Episodio).ThenInclude(e => e.Serie).ToList();
            Console.WriteLine("\nEpisódios Assistidos:");
            foreach (var ea in episodiosAssistidos)
            {
                Console.WriteLine($"ID: {ea.EpisodioAssistidoId}, Usuário: {ea.Usuario.Nome}, Episódio: {ea.Episodio.Titulo}, Série: {ea.Episodio.Serie.Nome}, Data: {ea.Data}");
            }
        }