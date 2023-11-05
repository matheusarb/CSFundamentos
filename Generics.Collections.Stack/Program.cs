// See https://aka.ms/new-console-template for more information
Console.WriteLine("---------Stack---------\n");

//------------------------------------------DEFINIÇÃO------------------------------------

//´Coleção genérica de tamanho variável. Funciona com base no princípio LIFO(Last In First Out)
// pode ter elementos duplicados e aceita null como valores
// UTILIDADE: armazenamento temporário para obtenção de informações, ou seja, quando talvez você queira descartar um elemento depois de recuperar seu valor
//permite repetição de elementos

var stac = new Stack<int>();
stac.Push(1);
stac.Push(2);
stac.Push(3);
stac.Push(9);
stac.Pop();

Exibir(stac);

static void Exibir<T>(IEnumerable<T> arr)
{
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
}
