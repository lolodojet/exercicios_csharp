/*using System;

class Datas
{
    static void Main()
    {

        int opcaoFormato;

        while (true)
        {
            Console.WriteLine("Escolha o formato da data: ");
            Console.WriteLine("1 - Padrão do sistema");
            Console.WriteLine("2 - Formato simples (08-01-2026): ");
            Console.WriteLine("3 - Formato longo");
            Console.WriteLine("4 - Formato completo");
            Console.WriteLine("5 - RFC1123");

            Console.Write("Opção: ");

            bool valido = int.TryParse(Console.ReadLine(), out opcaoFormato);
            if (valido && opcaoFormato >= 1 && opcaoFormato <= 5)
                break;

            Console.WriteLine("Opção inválida! Tente novamente. \n");
        }

        DataConfiguracao config = new DataConfiguracao(opcaoFormato);
        Console.WriteLine("Formato escolhido: " + config.formatoEscolhido);

        Console.WriteLine("\nEscolha um evento: ");
        Console.WriteLine("1 - ENIAC");
        Console.WriteLine("2 - RFC1");
        Console.WriteLine("3 - Alan Turing");

        Console.Write("Opção: ");
        int opcaoEvento = int.Parse(Console.ReadLine());

        Console.Clear();

        switch (opcaoEvento)
        {

            case 1:
                DateTime dataEniac = new DateTime(1946, 8, 15);
                Console.WriteLine("==== ENIAC ====");
                Console.WriteLine("Data: " + config.FormatarData(dataEniac));
                Console.WriteLine("Descrição:");
                Console.WriteLine("No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro computador eletrônico do mundo.");
                break;

            case 2:
                DateTime dataRFC = new DateTime(1969, 4, 17);

                Console.WriteLine("=== RFC1 ===");
                Console.WriteLine("Data: " + config.FormatarData(dataRFC));
                Console.WriteLine("Descrição:");
                Console.WriteLine("Em 17 de abril de 1969 foi publicada a RFC1, sendo considerado o dia da internet.");
                break;

            case 3:
                DateTime dataTuring = new DateTime(1912, 6, 23);

                Console.WriteLine("=== Alan Turing ===");
                Console.WriteLine("Data: " + config.FormatarData(dataTuring));
                Console.WriteLine("Descrição:");
                Console.WriteLine("Nascimento de Alan Turing, considerado o pai da computação.");
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    
    

    DateTime hoje = DateTime.Now;
    Console.WriteLine(config.FormatarData(hoje));
    }
}

public class DataConfiguracao
{
    public int formatoEscolhido;
    public DataConfiguracao(int formato)
    {
        formatoEscolhido = formato;
    }

    public string FormatarData(DateTime data)
    {
        switch (formatoEscolhido)
        {

            case 1:
                return data.ToString();

            case 2:
                return data.ToString("dd-MM-yy");

            case 3:
                return data.ToString("dddd, d, 'de' MMMM 'de' yyyy");

            case 4:
                return data.ToString("dd-MM-yyyy HH:mm:ss");

            case 5:
                return data.ToString("R");

            default:
                return data.ToString();
        }
    }
} */ 