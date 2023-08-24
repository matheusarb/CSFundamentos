Console.WriteLine("Partial Class\n--------");
MinhaPartialClass instancia = new MinhaPartialClass();
instancia.Hello();

//quando usar partial class?
//

public partial class MinhaPartialClass
{
    public DateTime DataNascimento { get; set; }
    public string? Nome { get; set; }
}

