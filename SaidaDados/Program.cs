Console.WriteLine("Saída de dados : Formatação");
Console.WriteLine();

int idade = 25;
string nome = "maria";

//Console.Write(nome);
//Console.Write(idade);
Console.WriteLine("Interpolação---------");
// Interpolação de string (template literals)
Console.Write($"{nome} tem {idade}");
Console.WriteLine("");

Console.WriteLine("Concatenação--------");
//Concatenação
Console.Write(nome + " tem " + idade);

Console.WriteLine("");
Console.WriteLine("Placeholders--------");

//PLaceholders
Console.Write("{0} tem {1} anos", nome, idade);

Console.ReadLine();
