using Microsoft.EntityFrameworkCore;
using Diario_De_turma.Classes;


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

using (var context = new DiarioTurmaContext())
        {
            // Cadastrar aluno
            var aluno = new Aluno { Nome = "Maria" };
            context.Alunos.Add(aluno);
            context.SaveChanges();

            // Cadastrar matéria
            var materia = new Materia { Nome = "Matemática" };
            context.Materias.Add(materia);
            context.SaveChanges();

            // Cadastrar nota
            var nota = new Nota { Valor = 8.5, AlunoId = aluno.AlunoId, MateriaId = materia.MateriaId };
            context.Notas.Add(nota);
            context.SaveChanges();

            // Listar alunos, matérias e notas
            var alunos = context.Alunos.ToList();
            Console.WriteLine("Alunos:");
            foreach (var a in alunos)
            {
                Console.WriteLine($"ID: {a.AlunoId}, Nome: {a.Nome}");
            }

            var materias = context.Materias.ToList();
            Console.WriteLine("\nMatérias:");
            foreach (var m in materias)
            {
                Console.WriteLine($"ID: {m.MateriaId}, Nome: {m.Nome}");
            }

            var notas = context.Notas.Include(n => n.Aluno).Include(n => n.Materia).ToList();
            Console.WriteLine("\nNotas:");
            foreach (var n in notas)
            {
                Console.WriteLine($"ID: {n.NotaId}, Valor: {n.Valor}, Aluno: {n.Aluno.Nome}, Matéria: {n.Materia.Nome}");
            }
        }