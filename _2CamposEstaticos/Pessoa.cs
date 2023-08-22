
//Cliente c1 = new Cliente();
public class Pessoa
{
    public static int IdadeMinima;

    public int Idade { get; set; }
    public string Nome { get; set; } = string.Empty;
            
    public Pessoa()
    {}

    public Pessoa(int idade, string nome)
    {
        Idade = idade;
        Nome = nome;
    }


    static Pessoa()
    {
        Console.WriteLine("\nInicializando o construtor estático...");
        Console.WriteLine("\nA pessoa terá a idade mínima de:");
        IdadeMinima = 18;
    }
}
