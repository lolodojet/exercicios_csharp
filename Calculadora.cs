using System;

class Calculadora{
    static void Main(){

        while (true){
            Console.WriteLine("---- CALCULADORA ----");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Resto da Divisão");
            Console.WriteLine("6 - Potência");
            Console.WriteLine("0 - Sair");

            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 0){
                Console.WriteLine("Saindo...");
                break;
            }

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (escolha){
                case 1:Console.WriteLine("Resultado: " + (num1 + num2));
                break;

                case 2:Console.WriteLine("Resultado: " + (num1 - num2));
                break;

                case 3:Console.WriteLine("Resultado: " + (num1 * num2));
                break;

                case 4:
                    if (num2 != 0)
                        Console.WriteLine("Resultado: " + (num1 / num2));
                    else
                        Console.WriteLine("Não pode dividir por zero!");
                    break;

                case 5: 
                    if (num2 != 0)
                        Console.WriteLine("Resultado: " + (num1 % num2));
                    else
                        Console.WriteLine("Não pode dividir por zero") ;
                break;

                case 6: Console.WriteLine("Resultado: "+ Math.Pow(num1, num2));
                break;
            
                default: Console.WriteLine("Opção Inválida");
                break;
            }
        }

    }
}
