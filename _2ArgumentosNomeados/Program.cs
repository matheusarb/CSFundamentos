Console.WriteLine("Hello, World!");

Email email = new();
email.Enviar(titulo: "TITULO", assunto: "ASSUNTO", destino: "PARAMIM");


public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"Para {destino} - {titulo}\n{assunto}");
    }
}