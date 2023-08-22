using Microsoft.VisualBasic;
using System.Security.Cryptography;

Console.WriteLine("Carros de Matheus\n-------\n");

Carro chevrolet = new Carro("Chevrolet","Onix","Sedan",2016,110);
Carro ford = new Carro("Ford", "EcoSport", "SUV", 2018, 120);
chevrolet.ExibirInformacoes();
chevrolet.Acelerar(chevrolet.marca);
Console.WriteLine();
ford.ExibirInformacoes();
ford.Acelerar(ford.marca);
ford.VelocidadeMaxima(ford.potencia);

public class Carro
{
    public string? marca;
    public string? modelo;
    public string? tipo;
    public int ano;
    public int potencia;


    public Carro(string marca, string modelo, string tipo, int ano, int potencia)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.tipo = tipo;
        this.ano = ano;
        this.potencia = potencia;
    }

    public Carro(string modelo, string tipo)
    {
        modelo = modelo;
        tipo = tipo;
    }

    public double VelocidadeMaxima(int potencia) => potencia * 1.75;

    public void ExibirInformacoes()
    {
        InformacoesCarro(this);
    }

    public void InformacoesCarro(Carro obj)
    {
        Console.WriteLine($"marca: {obj.marca}\nmodelo: {obj.modelo}\ntipo: {obj.tipo}\nano: {obj.ano}\npotência: {obj.potencia}");
    }

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }

}