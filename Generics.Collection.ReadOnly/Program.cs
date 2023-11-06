// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;
using System.Globalization;

Console.WriteLine("---------------ReadOnlyCollection<T>---------------");
//-------------------------------------- DEFINIÇÕES -----------------------------
//1. útil para cenários onde desejamos armazenar uma coleção somente para leitura. Não queremos que o usuário modifique acidentalmente

//1. inicialização 1
//var example = new List<string> { "1", "2", "3", "4", "5" };
//var readOnlyCol = new ReadOnlyCollection<string>(example);
////1.1 inicialização 2
//var rocol2 = example.AsReadOnly();

////operações com readOnlyCollection

////copiar array e excluir o último index e o primeiro
//var arr = new string[example.Count  + 2];
//readOnlyCol.CopyTo(arr, 1);

//foreach (var item in arr)
//{
//    Console.WriteLine($"\"{item}\"");
//}

//Console.ReadKey();

////-------------------EXERCÍCIO---------------------
//ReadOnlyCollection<Aluno> listaAlunos = new ReadOnlyCollection<Aluno>(Aluno.GetAlunos());
//foreach(var aluno in listaAlunos)
//{
//    Console.WriteLine(aluno.Nome);
//}

//public class Aluno
//{
//    public string Nome { get; set; } = string.Empty;

//    public static List<Aluno> GetAlunos()
//    {
//        return new List<Aluno>()
//        {
//            new Aluno() { Nome="MAtheus" },
//            new Aluno() { Nome="Luiggi" },
//            new Aluno() { Nome="Alexandre" }
//        };
//    }
//}

