Console.WriteLine("Exercício 2\n -----------");

//string nome = "Matheus";
//int idade = 17;
//double nota = 7.5;
//Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");
//Console.WriteLine($"{nome}\n{idade}\n{nota}");

//fase 2
Console.WriteLine("Digite uma letra");
char a = Convert.ToChar(Console.ReadLine());
//Console.ReadKey();

Console.WriteLine("Digite outra letra");
char b = Convert.ToChar(Console.ReadLine());
//Console.ReadKey();

Console.WriteLine("Digite mais uma letra");
char c = Convert.ToChar(Console.ReadLine());

Console.WriteLine($"Suas letras são {c} {b} {a}");
Console.ReadKey();