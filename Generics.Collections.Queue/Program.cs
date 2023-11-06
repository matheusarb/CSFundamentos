using System.ComponentModel;
using System.Globalization;

internal class Program
{
    //---------------------DEFINIÇÃO------------------------
    //1. coleção genérica de tamanho variável funciona com base no princípio FIFO (First in First out)

    public static void Main(string[] args)
    {
        Console.WriteLine("Queue\n-----------");

        //    var fifo = new Queue<int>();
        //    fifo.Enqueue(1);
        //    fifo.Enqueue(5);
        //    fifo.Enqueue(10);
        //    fifo.Enqueue(15);
        //    Exibir(fifo);

        //    Console.WriteLine("Retirando o elemento: ");
        //    fifo.Dequeue();
        //    Exibir(fifo);
        //}

        //static void Exibir<T>(IEnumerable<T> arr)
        //{
        //    foreach (var item in arr)
        //    {
        //        Console.Write($"{item} ");
        //    }
        //    Console.WriteLine("\n-----------");
        //}

        //-------------------EXERCÍCIO----------------------------
        //Criar uma lista de pedidos de um restaurante, com as propriedades Valor e nº de pedido

        Queue<Pedido> listaPedidos = new Queue<Pedido>();
        listaPedidos.Enqueue(new Pedido(51, 39.90));
        listaPedidos.Enqueue(new Pedido(53, 67.89));
        listaPedidos.Enqueue(new Pedido(55, 19.90));

        //quantidade de items na Queue
        Console.WriteLine("quantidade de items:");
        Console.WriteLine(listaPedidos.Count);

        //mostrar todos os pedidos
        Console.WriteLine("\nmostrar peddidos:");
        foreach(var pedido in listaPedidos)
        {
            Console.WriteLine($"nº pedido:{pedido.Numero}\t valor:{pedido.Valor}");
        }

        //localizar pedido na fila
        Console.WriteLine("\nlocalizar um pedido na fila:");
        int pedidoUsuario = 53;
        Pedido pedidoLocalizado = listaPedidos.FirstOrDefault(x => x.Numero == pedidoUsuario);
        if (pedidoLocalizado!=null)
            Console.WriteLine($"O pedido de nº{pedidoUsuario} foi encontrado");
        else
            Console.WriteLine($"O pedido de nº{pedidoUsuario} não foi encontrado na fila");

        //printar o processamento de todos os pedidos
        Console.WriteLine("\nprintar processameento de todos os pedidos:");
        while (listaPedidos.Count > 0)
        {
            var pedidoProcessado = listaPedidos.Dequeue();
            Console.WriteLine($"O pedido nº{pedidoProcessado.Numero} está preparado e pronto para sair");
        }

        //




    }
        public class Pedido
        {
            public int Numero { get; set; }
            public double Valor { get; set; }

            public Pedido(int numero, double valor)
            {
                Numero = numero;
                Valor = valor;
            }
        }
}