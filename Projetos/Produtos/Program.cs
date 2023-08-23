using Produtos.Classes;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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

 using (var context = new GerenciamentoProdutoContext())
        {
            // Cadastrar produto
            var produto = new Produto { Nome = "Camisa", Preco = 50m, Estoque = 100 };
            context.Produtos.Add(produto);
            context.SaveChanges();

            // Cadastrar usuário
            var usuario = new Usuario { Nome = "Lucas", Senha = "12345" }; // Em uma aplicação real, use hashing para senhas!
            context.Usuarios.Add(usuario);
            context.SaveChanges();

            // Cadastrar cliente
            var cliente = new Cliente { Nome = "Ana" };
            context.Clientes.Add(cliente);
            context.SaveChanges();

            // Registrar venda
            var venda = new Venda { DataVenda = DateTime.Now, ProdutoId = produto.ProdutoId, UsuarioId = usuario.UsuarioId, ClienteId = cliente.ClienteId, Quantidade = 2 };
            context.Vendas.Add(venda);
            context.SaveChanges();

            // Listar produtos, usuários, clientes e vendas
            var produtos = context.Produtos.ToList();
            Console.WriteLine("Produtos:");
            foreach (var p in produtos)
            {
                Console.WriteLine($"ID: {p.ProdutoId}, Nome: {p.Nome}, Preço: {p.Preco}, Estoque: {p.Estoque}");
            }

            var usuarios = context.Usuarios.ToList();
            Console.WriteLine("\nUsuários:");
            foreach (var u in usuarios)
            {
                Console.WriteLine($"ID: {u.UsuarioId}, Nome: {u.Nome}");
            }

            var clientes = context.Clientes.ToList();
            Console.WriteLine("\nClientes:");
            foreach (var c in clientes)
            {
                Console.WriteLine($"ID: {c.ClienteId}, Nome: {c.Nome}");
            }

            var vendas = context.Vendas.Include(v => v.Produto).Include(v => v.Usuario).Include(v => v.Cliente).ToList();
            Console.WriteLine("\nVendas:");
            foreach (var v in vendas)
            {
                Console.WriteLine($"ID: {v.VendaId}, Produto: {v.Produto.Nome}, Usuario: {v.Usuario.Nome}, Cliente: {v.Cliente.Nome}, Data: {v.DataVenda}, Quantidade: {v.Quantidade}");
            }
        }