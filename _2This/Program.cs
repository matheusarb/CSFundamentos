using System.Runtime.CompilerServices;

Console.WriteLine("Palavra this\n----------");

//Cliente teste = new Cliente();

//Teste t1 = new Teste();
//t1.num1 = 1;
//t1.num2 = 2;
//t1.Exibir();

//Teste t2 = new Teste();
//t2.num1 = 80;
//t2.num2 = 99;
//t2.Exibir();

Teste2 teste = new Teste2(999);

Console.ReadKey();

public class Teste
{
    public int num1;
    public int num2;

    public void PassarParametro(Teste t)
    {
        Console.WriteLine($"\n this = {this}");
        Console.WriteLine($"Num1 = {t.num1}");
        Console.WriteLine($"Num2 = {t.num2}");
    }

    public void Exibir()
    {
        //this aqui está passando como parâmetro a INSTÂNCIA ATUAL DO OBJETO
        //ou seja, qndo Exibir() for chamado, ele irá chamar PassarParametro() com os valores atribuídos para aquela instância do objeto
        PassarParametro(this);
    }
}

public class Teste2
{
    public Teste2(int num1, int num2)
    {
        Console.WriteLine($"Invocando o construtor com dois parâmetros: {num1} {num2}");
    }

    public Teste2(int num) : this(777, 888)
    {
        Console.WriteLine($"invocando o construtor com UM parâmetro: {num}");
    }
}