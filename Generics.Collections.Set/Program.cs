// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Coleções Set\n----------");
//------------------------------------------DEFINIÇÕES------------------------------------------
// coleção que contém apenas itens distintos é conhecida como SET
// HashSet<T> e SortedSet<T> são coleções genéricas usadas para manipular e armazenas conjuntos de dados não duplicados
// estão presentes no namespace System.Collection.Generics

// Obs.: HashSet<T> é melhor para adicionar e remover elementos
// Obs2.: SortedSet<T>  é melhor para operações que dependem da ordem dos elemento, como localizar primeiro ou o último


//------------------------------------------HASHSET<T>-------------------------------------------
//var pares = new HashSet<int>();

//for(var i =1; i < 6; i++)
//{
//    pares.Add(i*2);
//}
//foreach(var i in pares)
//{
//    Console.Write(i+" ");
//}

//var numeros = new List<int> { 1, 2, 3};
//var numeros2 = new List<int> { 1, 2, 4, 12, 22};
//var conjunto = new HashSet<int>(numeros);

//foreach (var i in conjunto)
//{
//    Console.Write(i + " ");
//}

//Console.WriteLine(conjunto.SetEquals(numeros2));
//EXERCICIO
var timesSP = new HashSet<string> { "São Paulo", "Santos", "Palmeiras" };
var timesRJ = new HashSet<string> { "Vasco", "Botafogo", "Fluminense" };
var timesBA = new HashSet<string> { "Bahia", "Vitoria" };
var timesMundiais = new HashSet<string> { "São Paulo", "Santos", "Palmeiras", "Flamengo" };

//if (!timesRJ.Contains("Flamengo"))
//    timesRJ.Add("Flamengo");

//if (timesSP.Overlaps(timesMundiais))
//{
//    Console.WriteLine("Pelo menos um time de SP possui título mundial");
//}

//if (timesSP.IsSubsetOf(timesMundiais))
//    Console.WriteLine("timesSP é um subset de timesMundiais");
//Console.WriteLine("Juntando todos os times");
//var todosTimes = new HashSet<string>();
//todosTimes.UnionWith(timesSP);
//todosTimes.UnionWith(timesRJ);
//todosTimes.UnionWith(timesBA);

//Console.WriteLine("Exibir todos os times ordenados");
//var todosTimesOrdenados = new SortedSet<string>(todosTimes);

//Console.WriteLine("\ncoleçaõ times da interseção");
//timesSP.IntersectWith(timesMundiais);
//var timesDiferencas = timesMundiais.Except(timesSP);

//ExibirColecao();

//----------------------------------------SORTEDSET-----------------------------------------
Console.WriteLine("\nSortedSet\n--------");
var impares = new SortedSet<int>();
for(var i = 6; i > 0; i--)
{
    impares.Add(i * 3);
}

ExibirColecao(impares);

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao)
    {
        Console.Write(item + " ");
    }
}