using emprestimo.Classes;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
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

        using (var context = new SistemaEmprestimosContext())
        {
            // Cadastrar usuário
            var usuario = new Usuario { Nome = "Carlos", Senha = "senha123" }; // Use hashing para senhas em aplicações reais!
            context.Usuarios.Add(usuario);
            context.SaveChanges();

            // Cadastrar cliente
            var cliente = new Cliente (1, "123.456.789-09");
            bool isCPFValid = cliente.ValidarCPF();
            context.Clientes.Add(cliente);
            context.SaveChanges();

            // Cadastrar item a ser emprestado
            var itemEmprestado = new ItemEmprestado { Descricao = "Notebook Dell", Valor = 4000.00 };
            context.ItensEmprestados.Add(itemEmprestado);
            context.SaveChanges();

            // Registrar empréstimo
            var emprestimo = new Emprestimo
            {
                DataEmprestimo = DateTime.Now,
                DataDevolucao = DateTime.Now.AddDays(7),
                UsuarioId = usuario.UsuarioId,
                ClienteId = cliente.ClienteId,
                ItemEmprestadoId = itemEmprestado.ItemEmprestadoId
            };
            context.Emprestimos.Add(emprestimo);
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
                Console.WriteLine($"ID: {c.ClienteId}, Nome: {c.Nome}, CPF: {c.CPF}");
            }

            Console.WriteLine("\nItens Emprestados:");
            foreach (var ie in context.ItensEmprestados)
            {
                Console.WriteLine($"ID: {ie.ItemEmprestadoId}, Descrição: {ie.Descricao}, Valor: {ie.Valor}");
            }

            Console.WriteLine("\nEmpréstimos:");
            var emprestimosLista = context.Emprestimos.Include(e => e.Usuario).Include(e => e.Cliente).Include(e => e.ItemEmprestado).ToList();
            foreach (var e in emprestimosLista)
            {
                Console.WriteLine($"ID: {e.EmprestimoId}, Data de Empréstimo: {e.DataEmprestimo}, Data de Devolução: {e.DataDevolucao}, Usuário: {e.Usuario.Nome}, Cliente: {e.Cliente.Nome}, Item: {e.ItemEmprestado.Descricao}");
            }
        }
    }
}