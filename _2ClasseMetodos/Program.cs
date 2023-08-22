Console.WriteLine("Classes e Métodos\n--------");

Pessoa p1 = new Pessoa();
p1.nome = "Matheus";
p1.idade = 31;
p1.sexo = "masculino";
//Console.WriteLine($"{p1.nome}, {p1.idade}, {p1.sexo}");

Pessoa mutante = new();
//mutante.cor = "verde";

Pessoa mt2 = new Pessoa
{
    nome = "teste",

    sexo = "sim"
};
Console.WriteLine(mt2.sexo);

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}