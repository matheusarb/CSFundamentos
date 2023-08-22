using System.Threading.Channels;
using System.Xml;

Console.WriteLine("Metodos\n------");

//Sintaxe mínima pra criar um método
//1. Tipo de Retorno= determina o que o método retorna. Comumente setamos para void
//2. Nome do método
//3. Lista de Parâmetros= tipo de dados e variáveis q o método pode receber
//4. Corpo do método= instruções definidas entre chaves no corpo do método

//Sobrecarga de métodos
// um método possui uma assinatura própria, composta de:
// 1. Nome do método;
// 2. número de parâmetros;
// 3. o tipo dos parâmetros;
// 4. A ordem dos parâmetros; Alterar a ordem permite usar o mesmo nome para o método

//MinhaClasse2 teste = new();
//teste.Saudacao();
//teste.Saudacao2("Matheus", DateTime.Now.ToString());


Console.WriteLine("\nMetodos com parâmetros\n---------");

Aluno aluno1 = new Aluno();
aluno1.Consultar();

Console.ReadKey();

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\n O aluno {aluno.Nome}, {aluno.Sexo}, com {aluno.Idade} anos:");
        if(aluno.Aprovado == "S".ToLower())
            Console.WriteLine("\nFoi aprovado");
        else
            Console.WriteLine("\nFoi reprovado");
    }
}
public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar()
    {
        var aluno = new Aluno();
        Console.WriteLine("Nome: ");
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Idade: ");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sexo: ");
        aluno.Sexo = Console.ReadLine();
        Console.WriteLine("Aprovado? 'S' para Sim e 'N' para Não: ");
        aluno.Aprovado = Console.ReadLine();

        Curso curso = new();
        curso.Resultado(aluno);
    }
}

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem=vindo");
        ExibirDataAtual();
    } 

    public void ExibirDataAtual() => Console.WriteLine(DateTime.Today);
}

class MinhaClasse2
{
    //parametros do metodo
    public void Saudacao2(string nome, string date)
    {
        Console.WriteLine(nome);
        Console.WriteLine(date);
    }
}