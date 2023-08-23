using Maquiagem.Classes;
using Microsoft.EntityFrameworkCore;

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

using (var context = new EstudioMaquiagemContext())
        {
            // Cadastrar usuário
            var usuario = new Usuario { Nome = "Ana", Senha = "senha123" };
            context.Usuarios.Add(usuario);
            context.SaveChanges();

            // Cadastrar cliente
            var cliente = new Cliente { Nome = "Lúcia", Telefone = "99999-7777" };
            context.Clientes.Add(cliente);
            context.SaveChanges();

            // Cadastrar tipo de maquiagem
            var tipoMaquiagem = new TipoMaquiagem { Descricao = "Maquiagem Noite", Preco = 80.00 };
            context.TiposMaquiagem.Add(tipoMaquiagem);
            context.SaveChanges();

            // Marcar horário
            var horarioMarcado = new HorarioMarcado 
            { 
                DataHora = DateTime.Now.AddHours(5),
                UsuarioId = usuario.UsuarioId, 
                ClienteId = cliente.ClienteId,
                TipoMaquiagemId = tipoMaquiagem.TipoMaquiagemId
            };
            context.HorariosMarcados.Add(horarioMarcado);
            context.SaveChanges();

            // Listar informações
            Console.WriteLine("Usuários:");
            foreach (var u in context.Usuarios)
            {
                Console.WriteLine($"ID: {u.UsuarioId}, Nome: {u.Nome}");
            }

            Console.WriteLine("\nClientes:");
            foreach (var c in context.Clientes)
            {
                Console.WriteLine($"ID: {c.ClienteId}, Nome: {c.Nome}, Telefone: {c.Telefone}");
            }

            Console.WriteLine("\nTipos de Maquiagem:");
            foreach (var tm in context.TiposMaquiagem)
            {
                Console.WriteLine($"ID: {tm.TipoMaquiagemId}, Descrição: {tm.Descricao}, Preço: {tm.Preco}");
            }

            Console.WriteLine("\nHorários Marcados:");
            var horarios = context.HorariosMarcados.Include(h => h.Usuario).Include(h => h.Cliente).Include(h => h.TipoMaquiagem).ToList();
            foreach (var h in horarios)
            {
                Console.WriteLine($"ID: {h.HorarioMarcadoId}, Data/Hora: {h.DataHora}, Usuário: {h.Usuario.Nome}, Cliente: {h.Cliente.Nome}, Tipo de Maquiagem: {h.TipoMaquiagem.Descricao}");
            }
        }