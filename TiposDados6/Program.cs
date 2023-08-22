using System.Runtime;
Console.WriteLine("## Nullable types ##\n");

int valor = 100;
//Console.WriteLine(valor);

int? nullableeTest = null;
//Console.WriteLine(nullableeTest);

int? a = 4;
int b = 3;
int? c = a * b;
Console.WriteLine(c);
Console.WriteLine("---------");

int? z = 100;
if (z.HasValue)
{
    Console.WriteLine($"z possui valor{z}");
}
else
{
    Console.WriteLine($"z não possui valor{z}");

}
  