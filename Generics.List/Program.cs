// See https://aka.ms/new-console-template for more information
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

List<string> l = new() { "matheus", "luiggi", "tata" };
// inclusão de itens, coleções
l.Add("xande");
l.Insert(1, "igor");
l.AddRange(new List<string>() { "ze", "damanga"});
// acesso aos elementos pelo índice
Console.WriteLine(l[1]);
// iteração
for (var i = 0; i < l.Count; i++)
{
}
// verificar se existe
//foreach(var i in l)
//{
//    var uppC = i.ToUpper();
//    List<string> upper = new();
//    upper.Add(uppC);
//    foreach(var item in upper)
//    {
//        Console.Write(item);
//    }
//    if (upper.Contains("LUIGGI"))
//    {
//        Console.WriteLine("contains");
//    }
//}
// remoção de itens

foreach (var item in l)
{
//Console.Write(item+" ");
}