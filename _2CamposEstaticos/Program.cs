Console.WriteLine("Campos estáticos!\n-------");

//Cliente c1 = new Cliente();
//c1.Nome = "MAthues";
//Cliente c2 = new Cliente();
//c2.Nome = "jose";
//Cliente.Idade = "trintinha";
//Console.WriteLine($"c1.Nome={c1.Nome}, c2.Nome={c2.Nome} e Cliente.Idade={Cliente.Idade}");

//ContaCorrente c1 = new ContaCorrente();
//c1.Conta = 101;
//c1.Nome = "Maria";
//c1.Juros = 3.99f;

//ContaCorrente c2 = new ContaCorrente();
//c2.Conta = 102;
//c2.Nome = "Jusefa";
//c2.Juros = 4.99f;

//Console.WriteLine($"Cliente: {c1.Nome} - Juros anual: {c1.JurosAnual()}");
//Console.WriteLine($"Cliente: {c2.Nome} - Juros anual: {c2.JurosAnual()}");

Console.WriteLine("EXERCICIO PRÁTICO 6\n---------\n\n");
//var valorIPVA = Convert.ToString(TributosCarro.ObterValorIpva());
//Console.WriteLine($"o valor do IPVA é: {valorIPVA}");

Console.WriteLine("Construtor estático\n----------");
Pessoa p1 = new Pessoa(19, "Mariazinha");
Console.WriteLine($"{p1.Nome}, {p1.Idade}");
Console.WriteLine("Idade mínima "+ Pessoa.IdadeMinima);

public class TributosCarro
{
    public static double ValorIpva;

    public static double ObterValorIpva()
    {
        ValorIpva = 4;
        return ValorIpva;
    }
}

public class Cliente
{
    // Métodos/Membros/Campos estáticos não dependem da criação de uma instância da classe para serem acessados
    // pertencem à classe, e não ao objeto ligado àquela classe
    // Exemplos: Classes Math, Console, Main...
    
    public string? Nome;
    public static string? Idade;
}

public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public float Juros;

    public float JurosAnual()
    {
        return Juros * 12;
    }
}