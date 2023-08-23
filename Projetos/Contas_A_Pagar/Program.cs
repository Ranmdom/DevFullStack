using System;
using  Contas_A_Pagar.Classes;
using Microsoft.EntityFrameworkCore;


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

using (var context = new FinanceiroContext())
        {
            // Cadastrar usuário
            var usuario = new Usuario { Nome = "João", Renda = 5000m };
            context.Usuarios.Add(usuario);
            context.SaveChanges();

            // Cadastrar contas a pagar e a receber
            var contaPagar = new Conta { Descricao = "Aluguel", DataVencimento = DateTime.Now.AddDays(10), Valor = 1000m, Tipo = TipoConta.APagar, UsuarioId = usuario.UsuarioId };
            var contaReceber = new Conta { Descricao = "Venda de Produto", DataVencimento = DateTime.Now.AddDays(5), Valor = 1500m, Tipo = TipoConta.AReceber, UsuarioId = usuario.UsuarioId };

            context.Contas.AddRange(contaPagar, contaReceber);
            context.SaveChanges();

            // Listar contas e usuários
            var usuarios = context.Usuarios.ToList();
            Console.WriteLine("Usuários:");
            foreach (var u in usuarios)
            {
                Console.WriteLine($"ID: {u.UsuarioId}, Nome: {u.Nome}, Renda: {u.Renda}");
            }

            var contas = context.Contas.Include(c => c.Usuario).ToList();
            Console.WriteLine("\nContas:");
            foreach (var c in contas)
            {
                Console.WriteLine($"ID: {c.ContaId}, Descrição: {c.Descricao}, Valor: {c.Valor}, Tipo: {c.Tipo}, Usuário: {c.Usuario.Nome}, Data de Vencimento: {c.DataVencimento}");
            }
        }
