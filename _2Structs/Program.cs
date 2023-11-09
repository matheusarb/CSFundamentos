Console.WriteLine("Structs!\n---------");
// tipo de addo definido pelo usuário, semelhante a uma classe
// contém campos, métodos, constantees, construtores, prorpiedades, indexadores, operadores e outros tipos de estrututa
// são opções mais "leves", em termos de performance, quando comparadas a uma classe

// A PRINCIPAL DIFERENÇA entre CLASSE e STRUCTS é que structs são TIPOS DE VALOR, e não de referência
// A alocação de memória é feita na Stack(tipo de valor), e não na Heap(tipo de referência)
// QUando usar uma Struct ao invés de classe?
//1. QUando representar, logicamente, um único valor, semelhante aos tipos primitivos (int, double etc...)
//2. Quando tiver um tamanho de instância inferior a 16 bytes
//3. Quando for IMUTÁVEL
//4. Quando não precisar sofrer CONVERSÕES PARA TIPO DE REFERÊNCIA(boxing) com frequência

//Cliente cliente = new();
//cliente.Nome = "maria";
//cliente.Idade = 28;
//cliente.Email = "www.@gmai..com";
//cliente.ExibirInfo("José", "matheus@mgial.com", 18);

//Cliente cliente2 = new Cliente("Matheus", "gmail", 31);

//Cliente.ExibirInfo(cliente2.Nome, cliente2.Email, cliente2.Idade);
//Cliente.ExibirInfo(cliente2.Nome, cliente2.Email);

//Console.WriteLine($"nome: {cliente2.Nome} e idade: {cliente2.Idade} e email: {cliente2.Email}");
//public struct Cliente
//{
//    public string? Nome { get; set; }
//    public string? Email { get; set; }

//    private int idade;
//    public int Idade
//    {
//        get => idade;
//        set 
//            {
//                if (idade < 18)
//                    idade = 18;
//                else
//                    idade = value;
//            }
//    }

//    public Cliente(string? nome, string? email, int idade)
//    {
//        Nome = nome;
//        Idade = idade;
//        Email = email;
//    }


//    public static void ExibirInfo(string? nome, string? email, int idade = 18)
//    {
//        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Email: {email}");
//    }
//}