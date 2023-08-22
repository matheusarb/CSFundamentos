Console.WriteLine("Inicio estruturas de repetição");
//goto e repeat

//int i = 0;

//repeat:
//Console.WriteLine($"i = {i}");
//i++;

//if( i <= 10)
//{
//    goto repeat;
//}

//Console.WriteLine("\nFim do processamento");

//int numero = 0;
//while(numero < 10)
//{
//    numero++;
//    int multiplicador = numero * 8;
//    Console.WriteLine(multiplicador);
//}

//Console.WriteLine(numero);

//Console.ReadKey();

int x = 0;
while(x < 5)
{
    int y = 0;
    while(y < 5)
    {
        Console.WriteLine($"{x},{y}");
        y++;
    }
    x++;
    Console.WriteLine();
}