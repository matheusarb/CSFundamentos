// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sorted Dictionary\n---------");

var sortDic = new SortedDictionary<int, string>();
sortDic.Add(1, "Brasil");
sortDic.Add(3, "India");
sortDic.Add(7, "França");
sortDic.Add(8, "GER");
sortDic.Add(2, "EUA");

foreach(var item in sortDic)
{
    Console.WriteLine($"{item.Key}\t{item.Value}");
}

Console.WriteLine("\nExibindo o valor através do TryGetValue()\n");
if(sortDic.TryGetValue(8, out string? value))
    Console.WriteLine($"O valor é: {value}");
else
    Console.WriteLine("A chave não existe");

