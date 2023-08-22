Console.WriteLine("Propriedades get e set!\n -----------");

Produto p1 = new ();
p1.Nome = "Caderno Novo";
p1.Preco = 4.00;
//p1.Desconto = 0.05;
p1.PrecoFinal = p1.Preco - p1.Preco * p1.Desconto;
p1.EstoqueMinimo = 10;

p1.Exibir();

public class Produto
{
    private string? nome;
    public string? Nome
    {
        get { return nome.ToUpper(); }
        set { nome = value; }
    }

    private double preco;
    public double Preco 
    {
        get { return preco; }
        set
        {
            if (value < 5.00)
                preco = 5.00;
            else
                preco = value;
        }
    }

    private double desconto=0.05;
    public double Desconto
    {
        get { return desconto; }
    }

    public double PrecoFinal { get; set; }
    public int EstoqueMinimo { get; set; }

    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n{Preco.ToString("c")} \n{Desconto} \n{PrecoFinal.ToString("c")} \n{EstoqueMinimo}");
    }
}
