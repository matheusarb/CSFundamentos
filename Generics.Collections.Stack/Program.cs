// See https://aka.ms/new-console-template for more information
using Generics.Collections.Stack;

Console.WriteLine("---------Stack---------\n");

//------------------------------------------DEFINIÇÃO------------------------------------

//´Coleção genérica de tamanho variável. Funciona com base no princípio LIFO(Last In First Out)
// pode ter elementos duplicados e aceita null como valores
// UTILIDADE: armazenamento temporário para obtenção de informações, ou seja, quando talvez você queira descartar um elemento depois de recuperar seu valor
//permite repetição de elementos

var stac = new Stack<int>();
//stac.Push(1);
//stac.Push(2);
//stac.Push(3);
//stac.Push(9);

//Exibir(stac);
//Console.WriteLine();

//Console.WriteLine($"Peek: {stac.Peek()}");
//Console.WriteLine($"Pop: {stac.Pop()}");
//Exibir(stac);

//static void Exibir<T>(IEnumerable<T> arr)
//{
//    Console.WriteLine();
//    foreach (var item in arr)
//    {
//        Console.Write(item + " ");
//    }
//}

//-----------------------------------EXERCÍCIO----------------------------------
var teste = new TextEditor();
Console.WriteLine("\nEscrevendo o texto");
teste.Write('s');
teste.Write('t');
teste.Write('a');
teste.Write('c');
teste.Write('h');

Console.WriteLine("\nDesfazendo...");
teste.Undo();
teste.Undo();

Console.WriteLine("\nDIgitando novamente...");
teste.Write('c');
teste.Write('k');
teste.Write('!');
