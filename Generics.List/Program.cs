// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Net.WebSockets;
using System.Reflection;
using System.Text.Json.Serialization;

Console.WriteLine("Generics - Lists\n------------");

// Algorithm Reverse array
//int[] teste = { 1, 2, 3, 4, 5 };
//var display = Reverse(teste);
//foreach (var item in display)
//{
//    Console.Write(item+" ");
//}
//static T[] Reverse<T>(T[] array)
//{
//    T[] result = new T[array.Length];
//    int i = 0;
//    for(var j = result.Length-1; j>=0; j--)
//    {
//        result[i] = array[j];
//        i++;
//    }
//    return result;
//}

//LIST<T>.São tipos de referência e precisam ser inicializados 
//List<int> lista = new();
//lista.Add(1);
//Console.WriteLine(lista[0]);

//List<string> lista2;
//lista2 = new List<string>();
//lista2.Add("contratado");
//Console.WriteLine(lista2[0]);
//List<int> list0 = new()
//{
//    0, 1, 2, 3
//};
//foreach (var i in list0)
//{
//    Console.WriteLine(i);
//}

//List<string> l = new() { "matheus", "luiggi", "tata" };
//// inclusão de itens, coleções
//l.Add("xande");
//l.Insert(1, "igor");
//l.AddRange(new List<string>() { "ze", "damanga"});
//l.InsertRange(1, new List<string>() { "jjj", "zzz" });
//Console.WriteLine(l.Count());
// acesso aos elementos pelo índice
//Console.WriteLine(l[1]);
// iteração
//for (var i = 0; i < l.Count; i++)
//{
//    Console.Write(l[i]+" ");
//}
// verificar se existe
var zzz = new List<string>() { "luiggi", "matheus" };
//foreach(var i in zzz)
//{
//    Console.Write(i.ToUpper()+" ");
//}

//foreach (var i in zzz)
//{   

//    Console.WriteLine(zzz[0]);
//Console.WriteLine("busque seu nome na lista");
//var input=Console.ReadLine();
//if (zzz.Contains(input.ToUpper()))
//{
//    Console.WriteLine("seu nome está aqui");
//    break;
//}
//}
// remoção de itens
//l.RemoveAt(0);
//l.RemoveRange(4, 1);
//Console.WriteLine("");
//for (var i = 0; i < l.Count; i++)
//{
//    Console.Write(l[i] + " ");
//}
//var ultimo = l[l.Count - 1];
//Console.WriteLine($"\n{ultimo}");
//foreach (var item in l)
//{
////Console.Write(item+" ");
//}

//Console.WriteLine("-----------");
//Console.WriteLine("-----------");
//zzz.Sort();

//int num = 20;
//Object obj = num; // boxing
//var e = (int)obj; // unboxing

// ARRAY LIST
// Ao incluir um tipo de valor em uma ArrayList ele automaticamente vira um Object(boxing automático. Tipo de referência)
// ao recuperar o valor desse item dentro da ArrayList ele torna-se um tipo de valor novamente (unboxing automático)
// Numa List<T> essas operações não ocorrem. ISSO É MELHOR PRA PERFORMANCE
//Console.WriteLine("------------------------------");
//ArrayList teste1 = new();
//teste1.Add(1);
//teste1.Add("Ola");
//DisplayElements(teste1);

//static void DisplayElements(ArrayList array)
//{
//    foreach(var t in array)
//    {
//        Console.Write(t+" ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("--------");
//List<int> nums = new() {1, 2, 3, 4, 5 };
//var a = nums.Find(x => x == 1);
//var b = nums.FindIndex(0, x => x == 4);

//List<string> listinha = new() { "banana", "arroz" };
//var last = listinha.FindIndex(x => x.Contains("a"));
//Console.WriteLine(last);

//IENUMERABLE
// descreve um comportamento. É read-only, não é possível alterar a coleção



//public class Limite
//{
//    public int Numero { get; set; }
//    private bool isRestricao;

//    public Limite()
//    {
//        var semente = Guid.NewGuid().GetHashCode();
//        var numeroAleatorio = new Random(semente).Next(1, 4);
//        isRestricao = numeroAleatorio == 1;
//    }

//    public bool AnaliseLimite()
//    {
//        Console.WriteLine($"Análise de limite de Crédito para o limite {Numero}");
//        return isRestricao;
//    }
//}

//EXERCÍCIO 1

var listaAlunos = FonteDados.GetAlunos();
var somaNotas = 0.0;
Console.WriteLine("Aluno\tNota");
foreach(var aluno in listaAlunos)
{
    Console.WriteLine($"{aluno.Nome}\t{aluno.Nota}");
    somaNotas += aluno.Nota;
}
var mediaAlunos = somaNotas / listaAlunos.Count();
Console.WriteLine($"\nmédia da turma: {Math.Round(mediaAlunos, 2)}");

List<Aluno> novosAlunos = new List<Aluno>(){ new Aluno() { Nome = "Mario", Nota = 8.95 }, new Aluno() { Nome = "Bia", Nota = 7.75 } };
listaAlunos.Add(novosAlunos[0]);
listaAlunos.Add(novosAlunos[1]);
DisplayAlunos(listaAlunos);

var tchauAmanda=listaAlunos.Find(x => x.Nome.Equals("Amanda"));
listaAlunos.Remove(tchauAmanda);
DisplayAlunos(listaAlunos);

var listaOrdenada = listaAlunos.OrderBy(x=>x.Nome).ToList();
DisplayAlunos(listaOrdenada);

var alunosNotaOito = listaAlunos.FindAll(x => x.Nota >= 8);
Console.WriteLine("\nALunos nota oito ou mais\n-----------");
foreach (var aluno in alunosNotaOito)
{
    Console.WriteLine($"{aluno.Nome}\t{aluno.Nota}");
}


static void DisplayPropertiesAlunos<T>(List<T> lista)
{
    foreach(var item in lista)
    {
        //qual o tipo do item
        Type type = item.GetType();
        //pegar as propriedades de item
        PropertyInfo nomePropInfo = type.GetProperty("Nome");
        PropertyInfo notaPropInfo = type.GetProperty("Nota");
        //verificar se as propriedades são do tipo desejado
        if(nomePropInfo.PropertyType == typeof(string) && notaPropInfo.PropertyType == typeof(double))
        {
            //pegar o valor das propriedades
            var name = nomePropInfo.GetValue(item).ToString();
            var nota = notaPropInfo.GetValue(item);
            Console.WriteLine($"{name}, {nota}");
        }
        //calcular média
    }
}

static void DisplayAlunos(List<Aluno> lista)
{
    Console.WriteLine();
    foreach (var item in lista)
    {
        Console.WriteLine($"{item.Nome}\t{item.Nota}");
    }
}

public class FonteDados
{
    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new() {
            new Aluno() { Nome = "Ze", Nota = 7.5 },
            new Aluno() { Nome = "Maria", Nota = 8.2 },
            new Aluno() { Nome = "Joao", Nota = 6.2 },
            new Aluno() { Nome = "Jose", Nota = 5.2 },
            new Aluno() { Nome = "Endrick", Nota = 9.7 },
            new Aluno() { Nome = "Peipá", Nota = 8.8 },
            new Aluno() { Nome = "Amanda", Nota = 8.8 }
        };

        return alunos;
    }
}

public class Aluno
{
    public string Nome { get; set; }
    public double Nota { get; set; }
}
