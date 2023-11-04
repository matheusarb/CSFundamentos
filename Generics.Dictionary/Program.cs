// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dictionary\n----------\n");

//1. cada chave em um Dictionary<TKey, TValue> deve ser exclusiva (não podem se repetir)
//2. Uma chave NÃO PODE ser null, mas um valor pode, desde que seu tipo (TValue) seja tipo de referência (string, object...)

Dictionary<string, int> dic1 = new Dictionary<string, int>();
dic1.Add("Primeiro", 1);
dic1.Add("Segundo", 20);
Console.WriteLine(dic1.Values);
