internal class Program
{
    //---------------------DEFINIÇÃO------------------------
    //1. coleção genérica de tamanho variável funciona com base no princípio FIFO (First in First out)

    private static void Main(string[] args)
    {
        Console.WriteLine("Queue\n-----------");

        var fifo = new Queue<int>();
        fifo.Enqueue(1);
        fifo.Enqueue(5);
        fifo.Enqueue(10);
        fifo.Enqueue(15);
        Exibir(fifo);

        Console.WriteLine("Retirando o elemento: ");
        fifo.Dequeue();
        Exibir(fifo);
    }

    static void Exibir<T>(IEnumerable<T> arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\n-----------");
    }
}