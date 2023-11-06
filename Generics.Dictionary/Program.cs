// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Runtime.CompilerServices;

Console.WriteLine("Dictionary\n----------\n");

//1. cada chave em um Dictionary<TKey, TValue> deve ser exclusiva (não podem se repetir)
//2. Uma chave NÃO PODE ser null, mas um valor pode, desde que seu tipo (TValue) seja tipo de referência (string, object...)


//-----------------------------------TREINAMENTO---------------------------
//var dic1 = new Dictionary<int, int>()
//{
//    {2, 200 },
//    {1, 100 },
//    {6, 666 },
//    {3, 300 }
//};

//Console.WriteLine("Diionario desordenado (forma padrão)\n--------");
//foreach (var item in dic1)
//{
//    Console.WriteLine($"{item.Key} {item.Value}");
//}

//Console.WriteLine("Dicionaroio ordenado\n-----------");
//var dicOrdenado = dic1.OrderBy(x => x.Key);
//foreach (var item in dicOrdenado)
//{
//    Console.WriteLine($"{item.Key} {item.Value}");
//}


//--------------------------------EXERCÍCIO---------------------------------
//Console.WriteLine("PRIMEIRA ABORDAGEM DE SOLUÇÃO\n-------------");

//var dadosAlunos = new Dictionary<string, double>()
//{
//    {"Maria", 7 },
//    {"Eric", 8 },
//    {"Ana", 9 },
//    {"Alex", 6 },
//    {"Diná", 5 }
//};

////1. acessar e exibir
//Console.WriteLine("1. Lista dos alunos\n-------");
//Aluno.ExibirAlunos(dadosAlunos);

////2. Localizar e atualizar a nota de um aluno
//Console.WriteLine("\n2. Nota Ana atualizada\n-------");
//if (dadosAlunos.ContainsKey("Ana"))
//{
//    dadosAlunos["Ana"] = 9.6;
//}
//Aluno.ExibirAlunos(dadosAlunos);

////3. remover aluno
//Console.WriteLine("\n3. Remoçãode Alex\n-------");
//dadosAlunos.Remove("Alex");
//Aluno.ExibirAlunos(dadosAlunos);

////4. incluir Vilma
//Console.WriteLine("\n4. IOnclusão de vilma\n-------");
//dadosAlunos.Add("Vilma", 7);
//Aluno.ExibirAlunos(dadosAlunos);

////5. ordenar por nome
//Console.WriteLine("\n5. Ordenar alunos\n-------");
//var alunosOrdenados = dadosAlunos.OrderBy(x => x.Key);
//foreach (var aluno in alunosOrdenados)
//{
//    Console.WriteLine($"{aluno.Key} {aluno.Value}");
//}

////6. Remover todos os dados
//Console.WriteLine("\n6. Remoção dos dados\n-------");
//Aluno.Remocao(dadosAlunos);

//Console.WriteLine("SEGUNDA ABORDAGEM DE SOLUÇÃO\n---------");

//Dictionary<int, Aluno> dados2 = new Dictionary<int, Aluno>()
//{
//    {1, new Aluno("Maria", 7) },
//    {2, new Aluno("Eric", 8) },
//    {3, new Aluno("Ana", 9) },
//    {4, new Aluno("Alex", 0) },
//    {5, new Aluno("Mãe Diná", 5) }
//};

//1.Exibir alunos
//Aluno.ExibirAlunos(dados2);

////2. atualizar nota mãe diná
//do
//{
//Console.WriteLine("\nInforme o código do aluno desejado (aperte 99 para sair): ");
//int codigo = Convert.ToInt32(Console.ReadLine());

//if (codigo == 99)
//break;

//var resultado = dados2.ContainsKey(codigo);
//if (resultado)
//{
//Console.WriteLine("Digite a nota de 1 a 10:");
//int notaAtualizada = Convert.ToInt32(Console.ReadLine());
//dados2[codigo].Nota = notaAtualizada;
//break;
//}
//else
//{
//Console.WriteLine("Aluno não localizado");
//}
//} while (true);
//Aluno.ExibirAlunos(dados2);


//public class Aluno
//{
//    public string Nome { get; set; }
//    public int Nota { get; set; }

//    public Aluno(string nome, int nota)
//    {
//        Nome = nome;
//        Nota = nota;
//    }

//    public static void ExibirAlunos(Dictionary<string, double> dic)
//    {
//        foreach (var aluno in dic)
//        {
//            Console.WriteLine($"{aluno.Key} {aluno.Value}");
//        }
//    }

//    public static void ExibirAlunos(Dictionary<int, Aluno> dic)
//    {
//        foreach (var aluno in dic)
//        {
//            Console.WriteLine($"{aluno.Key}\t {aluno.Value.Nome} {aluno.Value.Nota}");
//        }
//    }

//    public static void Remocao(Dictionary<string, double> dic)
//    {
//        dic.Clear();
//        Console.WriteLine("A lista de alunos foi zerada");
//    }

//    public static void Remocao(Dictionary<int, Aluno> dic)
//    {
//        dic.Clear();
//        Console.WriteLine("A lista de alunos foi zerada");
//    }
//}


