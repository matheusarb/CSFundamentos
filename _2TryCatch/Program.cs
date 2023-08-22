Console.WriteLine("Tratamento de exceções (try catch)\n--------");

// Exceção(exception) - É um erro que ocorre em tempo de execução de um programa que viola uma condição que não foi especificada para acontecer durante a operação normal
// Se o programa não fornecer o código para tratar uma exceção, o sistema vai parar a execuçaõ do programa com uma mensagem de erro. (lançar uma exception)
// uma exceção contém diversas propriedade somente leitura que mostram informações sobre a exceção que causou o erro
    // As principais são:
    // Message(string)  - contém uma mensagem de erro contendo o teor da exceção
    // StackTrace(string) - contém a informação que descreve aonde a exceção ocorreu
    // InnerException(exception) - se a exceção foi lançada por outra exceção, esta propriedade contém a referência da antiga exceção

// bloco FINALLY (opcional) - sempre será executado e será usado para liberar recursos usados no programa ou realizar uma tarefa

Console.WriteLine(" x / y ");
Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

try
{
    // código que será executado e que poderá gerar uma exceção
    int z = x / y;
    Console.WriteLine($"{x}/{y} = {z}");
}
catch (Exception ex)
{
    // se ocorrer  um erro será tratado aqui
    Console.WriteLine($"\nNão existe divisão por 0. Tente outro número");
    Console.WriteLine($"Erro: <<< {ex.Message} >>>");
    Console.WriteLine($"Detalhes: <<< {ex?.StackTrace?.ToString()} >>>");
}
finally
{
    Console.WriteLine("\nProcessamento concluído");
}

Console.ReadKey();