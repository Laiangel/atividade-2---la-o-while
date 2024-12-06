using System;

class atividade2
{
    static void Main()
    {
        int numero = -1; // Inicializa com um valor diferente de 0 para entrar no laço
        int soma = 0;

        Console.WriteLine("Digite números inteiros. Para sair, digite 0:");

        // Laço while que continua enquanto o número digitado não for 0
        while (numero != 0)
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine()); // Lê e converte o número digitado pelo usuário

            soma += numero; // Soma o número à variável acumuladora
        }

        Console.WriteLine($"A soma dos números digitados é: {soma}");
    }
}
