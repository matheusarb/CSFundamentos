// See https://aka.ms/new-console-template for more information
Console.WriteLine("Generics\n---------");
// Principais benefícios do Generics são:
//1. Reutilização de código
//2. Segurança de tipo (Type Safety)
//3. Desempenho

//var n1 = 10.2f;
//var n2 = 10.2m;

//var t = new Teste<int, int>();
//var f = new Teste<float, string>();
//var s = new Teste<object, object>();

public class Teste<T1, T2> where T1 : struct where T2 : class // struct representa tipo de valor e class tipo de referência
{
    public void Comparar<TNum1, TNum2>(TNum1 n1, TNum2 n2)
    {
        Console.WriteLine($"Os tipos {n1.GetType()} e {n2.GetType()}");
        var resultado = n1.Equals(n2);
        Console.WriteLine($"{n1} e {n2} são iguais? {(resultado ? "Sim" : "Não")}");
    }
}