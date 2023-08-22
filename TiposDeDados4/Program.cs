// Tipos de REFERÊNCIA
// string, objects, dynamic e class

internal class Program
{
    public Program()
    {
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Variáveis do tipo string object e dynamic!");

        string nome = "Curso c#";
        Console.WriteLine(nome);
        // strings são IMUTÁVEIS
        // cada vez que a string declara for alterada, ela irá ocupar um NOVO LUGAR NA MEMÓRIA. Não irá sobrescrever a informação no local de origem
        nome = "mudei";
        Console.WriteLine(nome);
        nome = "mudei de novo";
        Console.WriteLine(nome);
        // POr conta disso, se for trabalhar com textos e realizar muitas alterações, recomenda-se o uso do tipo StringBuilder

        object nota = 10;
        Console.WriteLine(nota);
    }
}