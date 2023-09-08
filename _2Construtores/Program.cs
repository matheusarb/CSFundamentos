Console.WriteLine("Construtores\n---------");
//1. Deve possuir o mesmo nome da classe
//2. Não possui neenhum tipo de retorno, nem mesmo void
//3. Pode possuir parâmetros que são usados para inicializar os membros da classe
//3.1. Caso não possua parâmetros, o C# utiliza o construtor padrão para instanciar a classe. Nenhuma classe pode ser instanciada sem o construtor


Aluno aluno = new Aluno("Leuris", 31, "Masc", "t");

Console.WriteLine(aluno.Nome ?? "null");
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "nulo" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "nulo" : aluno.Aprovado);


public class Aluno
{
    public Aluno(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public Aluno(string nome, int idade, string sexo, string aprovado) : this(nome, idade) //a atribuição do parâmetro 'nome' nesse construtor é obtida invocando o valor passado ao outro construtor
    {
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}