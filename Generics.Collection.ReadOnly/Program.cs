// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;
using System.Globalization;

Console.WriteLine("---------------ReadOnlyCollection<T>---------------");
//-------------------------------------- DEFINIÇÕES -----------------------------
//1. útil para cenários onde desejamos armazenar uma coleção somente para leitura. Não queremos que o usuário modifique acidentalmente

//1. inicialização 1
var example = new List<int> { 1, 2, 3, 4, 5 };
var readOnlyCol = new ReadOnlyCollection<int>(example);
//1.1 inicialização 2
var rocol2 = example.AsReadOnly();

//operações com readOnlyCollection

//copiar array e excluir o último index e o primeiro e segundo
int[] arr = new int[example.Count - 2];
readOnlyCol.CopyTo(arr, 2);

foreach (var item in arr)
{
    Console.Write($"{item} ");
}




Console.ReadKey();
