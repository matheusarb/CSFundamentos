// See https://aka.ms/new-console-template for more information
using System.Collections.Immutable;

Console.WriteLine("Indexadores\n--------");

//var times = new Time();
//// set
//times[0] = "Vitória";
//times[1] = "Jacuipense";
//times[11] = "Bahia";
//// get
//var t1 = times[0];
//var t2 = times[1];
//var t3 = times[11];

//Console.WriteLine(t1);
//Console.WriteLine(t2);
//Console.WriteLine(t3);

//Console.WriteLine("\n--------\nSorteio de loteria com Random()\n----------");
//int numPremiado, numAposta;
//numPremiado = 6;
//numAposta = new Random().Next(0, 10);

//if(numAposta == numPremiado)
//{
//    Console.WriteLine($"Parabéns!! Você foi o ganhador do sorteio\nNº do sorteio: {numPremiado}\tNº da sua aposta: {numAposta}");
//}
//else
//{
//    Console.WriteLine($"Que pena! Não foi dessa vez.\nNº do sorteio: {numPremiado}\tNº da sua aposta: {numAposta}");
//}
//Console.ReadLine();

Console.WriteLine("\nSorteio da Mega da virada");
var random = new Random();
int[] numSorteados = new int[6];

for (int i = 0; i < 6; i++)
{
    int numAleatorios;
    do
    {
        numAleatorios = random.Next(1, 61);
    } while (numSorteados.Contains(numAleatorios));
    numSorteados[i] += numAleatorios;
}
Array.Sort(numSorteados);
Console.WriteLine($"Os Nºs do Sorteio 1971 são: {string.Join(" ",numSorteados)}");

public class Time
{
    public string[] valor = new string[10];

    public string this[int i]
    {
        get 
        {
            if(i >= 0 && i < valor.Length)
            {
                return valor[i];
            }
            return "Error";
        }
        set 
        {
            if (i >= 0 && i < valor.Length)
            {
                valor[i] = value;
            }
        }
    }
}