Console.WriteLine("Tipos anônimos\n-------");

var aluno = new
{
    Nome = "Matheus",
    Nota = 10
};

var aluno2 = new
{
    Id = 1,
    Nome = "Jaminho",
    Email = "wwww@gmai.com",
    Endereco = new { Id = 1, Cidade = "Savaldor", Pais = "Brasil" }
};

Console.WriteLine(aluno2.Nome);
Console.WriteLine(aluno2.Endereco);
//var conversao = new string[aluno2.Endereco];

//Console.WriteLine(aluno.Nome);
//Console.WriteLine(aluno.Nota);

Console.WriteLine("\n--");
Console.WriteLine(aluno.Nota.GetType().ToString());