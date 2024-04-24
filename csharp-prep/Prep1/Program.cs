using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar o primeiro nome do usuário
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();

        // Solicitar o último nome do usuário
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        // Exibir o nome completo no formato especificado
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
