﻿//Console.WriteLine("Hello, World!");

//// escrever um switch case para 3 parcelas em cima do valor de 800 reais

//int n = 800;
//Console.WriteLine("Em quantas parcelas você irá pagar?");
//var p = Convert.ToInt32(Console.ReadLine());

//switch (p)
//{
//    case 1:
//        switch (n)
//        {
//            case 2:
//            Console.WriteLine("Vai pagar à vista!");
//            break;
//        }
//        break;

//    case 2:
//        Console.WriteLine($"Duas vezes de {n / p}");
//        break;

//    case 3:
//        Console.WriteLine($"Três vezes de {n/p}");
//        break;
//}

// DO WHILE
//var i = 0;
//do
//{
//    Console.WriteLine($"O valor de i é: {i}");
//    i++;
//    if(i == 5)
//    {
//        Console.WriteLine($"O valor de i é: {i}.O programa irá encerrar");

//        break;
//    }
//} while(i < 10);

//TABOADA
//int numero, resultado;

//Console.WriteLine("Digite um nº de 1 a 9");
//numero = Convert.ToInt32(Console.ReadLine());
//    if(!(numero > 0 && numero < 10))
//    {
//        Console.WriteLine("Opção inválida. O programa encerrará");
//        Environment.Exit(0);
//    }

//for (var i = 1; i < 10; i++)
//{
//    resultado = numero * i;
//    Console.WriteLine($"{numero} * {i} = {resultado}");
//}

//INSTRUCAO WHILE


//int cargo, funcao;
//Console.WriteLine("Você é programador(1) ou gerente(2)?");
//cargo = Convert.ToInt32(Console.ReadLine());

//switch (cargo)
//{
//    case 1:
//        Console.WriteLine("Você é Junior(1) ou Senior(2)?");
//        funcao = Convert.ToInt32(Console.ReadLine());
//        switch (funcao)
//        {
//            case 1:
//                Console.WriteLine("Olá, juninho!");
//                break;
//            case 2:
//                Console.WriteLine("Olá, senior");
//        break;
//        }
//        break;
//    case 2:
//        Console.WriteLine("Bem vindo gerencia");
//        break;
//    default:
//        Console.WriteLine("jogou onde?");
//        break;
//}