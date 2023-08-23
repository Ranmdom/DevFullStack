using Almoxarife.Classes;
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

using (var context = new AlmoxarifadoContext())
        {
            // Cadastrar usuário
            var usuario = new Usuario { Nome = "João", Senha = "12345" }; // Em uma aplicação real, use hashing para senhas!
            context.Usuarios.Add(usuario);
            context.SaveChanges();

            // Cadastrar produto
            var produto = new Produto { Nome = "Chave de fenda", Descricao = "Chave de fenda tamanho médio", QuantidadeEmEstoque = 50 };
            context.Produtos.Add(produto);
            context.SaveChanges();

            // Distribuir produto
            var produtoDistribuido = new ProdutoDistribuido 
            { 
                UsuarioId = usuario.UsuarioId, 
                ProdutoId = produto.ProdutoId, 
                Quantidade = 5, 
                DataDistribuicao = DateTime.Now 
            };
            produto.QuantidadeEmEstoque -= produtoDistribuido.Quantidade; // Atualizar quantidade em estoque
            context.ProdutosDistribuidos.Add(produtoDistribuido);
            context.SaveChanges();

            // Listar usuários, produtos e produtos distribuídos
            var usuarios = context.Usuarios.ToList();
            Console.WriteLine("Usuários:");
            foreach (var u in usuarios)
            {
                Console.WriteLine($"ID: {u.UsuarioId}, Nome: {u.Nome}");
            }

            var produtos = context.Produtos.ToList();
            Console.WriteLine("\nProdutos:");
            foreach (var p in produtos)
            {
                Console.WriteLine($"ID: {p.ProdutoId}, Nome: {p.Nome}, Descrição: {p.Descricao}, Quantidade em Estoque: {p.QuantidadeEmEstoque}");
            }

            var produtosDistribuidos = context.ProdutosDistribuidos.Include(pd => pd.Usuario).Include(pd => pd.Produto).ToList();
            Console.WriteLine("\nProdutos Distribuídos:");
            foreach (var pd in produtosDistribuidos)
            {
                Console.WriteLine($"ID: {pd.ProdutoDistribuidoId}, Usuário: {pd.Usuario.Nome}, Produto: {pd.Produto.Nome}, Quantidade: {pd.Quantidade}, Data de Distribuição: {pd.DataDistribuicao}");
            }
        }