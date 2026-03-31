/*using System;
using System.Globalization;

enum Moeda
{
    Dolar = 1,
    Euro = 2,
    Iene = 3,
    Libra = 4
}

class ConversaoDeMoedas
{
    static void Main()
    {
        Console.WriteLine("Informe o valor em real que deseja converter:");
        Console.Write("Digite o valor em Reais (R$): ");

        decimal valorReal;
        if (!decimal.TryParse(Console.ReadLine(), out valorReal))
        {
            Console.WriteLine("Valor inválido!");
            return;
        }

        Console.WriteLine("\nEscolha a moeda:");
        Console.WriteLine("1 - Dólar");
        Console.WriteLine("2 - Euro");
        Console.WriteLine("3 - Iene");
        Console.WriteLine("4 - Libra");

        int opcao;
        if (!int.TryParse(Console.ReadLine(), out opcao))
        {
            Console.WriteLine("Opção inválida!");
            return;
        }

        Moeda moedaEscolhida = (Moeda)opcao;

        decimal valorConvertido = 0;
        CultureInfo cultura;

        switch (moedaEscolhida)
        {
            case Moeda.Dolar:
                valorConvertido = valorReal / 4.50m;
                cultura = new CultureInfo("en-US");
                break;

            case Moeda.Euro:
                valorConvertido = valorReal / 6.20m;
                cultura = new CultureInfo("fr-FR");
                break;

            case Moeda.Iene:
                valorConvertido = valorReal / 0.052m;
                cultura = new CultureInfo("ja-JP");
                break;

            case Moeda.Libra:
                valorConvertido = valorReal / 6.95m;
                cultura = new CultureInfo("en-GB");
                break;

            default:
                Console.WriteLine("Opção inválida!");
                return;
        }

        Console.WriteLine("\nValor convertido: " + valorConvertido.ToString("C", cultura));
    }
}*/ 