using EnumExercicio;

Console.WriteLine("Enum!\n--------");
//Enum pode ser qualquer tipo de dado NUMÉRICO
// byte, sbyte, short, ushort, int, uint, long ou ulong

//int terca = (int)DiasDaSemana.Terca;
//int domingo = (int)DiasDaSemana.Domingo;
//Console.WriteLine($"{DiasDaSemana.Terca}: {terca}\n{DiasDaSemana.Domingo}: {domingo}");

//Console.WriteLine($"{Categorias.Moda}\t{(int)Categorias.Moda}");
//Console.WriteLine($"{Categorias.Automotivo}\t{(int)Categorias.Automotivo}");
//Console.WriteLine($"{Categorias.Artes}\t{(int)Categorias.Artes}");
//Console.WriteLine($"{Categorias.Bebidas}\t{(int)Categorias.Bebidas}");

//Console.WriteLine("\nEscolha o valor da categoria que deseja empreender");
//var valor = Convert.ToInt32(Console.ReadLine());
//var escolhaUsuario = (Categorias)valor;

//Console.WriteLine($"\nA categoria selecionada foi {(Categorias)valor}");

//enum DiasDaSemana : byte
//{
//    Segunda=0,
//    Terca=12,
//    Quarta=13,
//    Quinta=14,
//    Sexta,
//    Sabado,
//    Domingo
//}

//enum Categorias
//{
//    Moda,
//    Automotivo,
//    Artes,
//    Bebidas
//}

Carro carro = new(1);

carro.ExibirInfo();

public class Carro
{
    public int Cor { get; set; }

    public Carro(int cor)
    {
        this.Cor = cor;
    }

    public void ExibirInfo(int cor = 1)
    {
        Console.WriteLine($"A cor do carro é {(Cores)Cor}");
    }
}