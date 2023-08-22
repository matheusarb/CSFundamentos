Console.WriteLine("Hello, World!");

Console.WriteLine("Informe o valor de x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y:");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n Raiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"\n Potência de x = {Math.Pow(x, y)}");
Console.WriteLine($"\n Valor mínino entre x e y = {Math.Min(x, y)}");
Console.WriteLine($"\n Valor máximo entre x e y = {Math.Max(x, y)}");
Console.WriteLine($"\n Coseno de x = {Math.Cos(x)}");
Console.WriteLine($"\n Seno de x = {Math.Sin(x)}");
Console.WriteLine($"\n Exponencial de x = {Math.Exp(x)}");

Console.ReadKey();

//Console.WriteLine($"O valor de x+y é {x+y}");
//Console.WriteLine($"O valor de x-y é {x-y}");
//Console.WriteLine($"O valor de x*y é {x*y}");
//double resultado = (double)x / y;
//Console.WriteLine($"O valor de x/y é {resultado}");
//Console.WriteLine($"O valor de x%y é {x%y}");