using System;

class Programa
{
    static void Main(string[] args)
    {
        // Solicita ao usuário para inserir o primeiro número
        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        // Solicita ao usuário para inserir o segundo número
        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        // Calcula a soma dos dois números
        double soma = numero1 + numero2;

        // Exibe o resultado
        Console.WriteLine($"A soma de {numero1} e {numero2} é {soma}");
    }
}
