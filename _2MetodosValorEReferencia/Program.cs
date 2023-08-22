using System.Xml;

Console.WriteLine("Valor e Referência\n-------");

//Carro carro = new Carro();
//var y = 10;
//carro.AumentarPotencia(ref y);
//Console.WriteLine(y);

//Console.WriteLine("informa o raio do ciruslo: ");
//double raio = Convert.ToDouble(Console.ReadLine());

//Circulo circulo = new Circulo();
//double calculaPerimetro = circulo.CalculoPerimetro(raio);
//double calculaArea = circulo.CalculaArea(raio);

//Console.WriteLine($"períemtro: {calculaPerimetro}");
//Console.WriteLine($"área: {calculaArea}");

//Circulo.MetodoEstatico();
Cliente c1 = new Cliente();
c1.Nome = "MAthues";

Cliente c2 = new Cliente();
c2.Nome = "jose";

Cliente.Idade = "trintinha";

Console.WriteLine($"c1.Nome={c1.Nome}, c2.Nome={c2.Nome} e Cliente.Idade={Cliente.Idade}");

public class Cliente
{
    public string? Nome;
    public static string? Idade;
}

public class Carro{
    public void AumentarPotencia(int potencia)
    {
        Console.WriteLine($"a potência foi aumentada para: {potencia+=3}");
    }

    public void AumentarPotencia(ref int potencia)
    {
        Console.WriteLine($"a potência foi aumentada para: {potencia+=5}");
    }
}

public class Circulo
{
    public double CalculaArea(double raio)
    {
        double area = Math.PI * Math.Pow(raio, 2);
        return area;
    }

    public double CalculoPerimetro(double raio)
    {
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }

    public double CalculaAreaEPerimetro(double raio, out double area)
    {
        area = 0;
        return area;
    }

    
    public static void MetodoEstatico()
    {
        Console.WriteLine("O método estático funcionou");
    }
}

