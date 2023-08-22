using System.Xml;

Console.WriteLine("Operadores de Incremento e Decremento \n---------");

// operador pode ficar após ou antes a variável

//se após (x++), em caso de expressão, primeiro a expressão será resolvido para, dps, ocorrer o incremento:
int x = 0;
int result = x++ + 10;
Console.WriteLine($"result é: {result}"); //o resultado aqui será 10
Console.WriteLine(x);
Console.WriteLine("--");

// se antes (++x), em caso de expressão, o incremento no valor ocorrerá antes de resolver a expressão:
int y = 0;
int result2 = ++y + 10; // aqui será 11
Console.WriteLine($"result2 é: {result2}");
