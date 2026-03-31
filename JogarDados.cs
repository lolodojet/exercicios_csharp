/*using System;

class Jogar{
    static void Main(){

        Random random = new Random();
        
        Console.WriteLine("Informe o nome do primeiro jogador: ");
        String jogador1 = (Console.ReadLine());

        Console.WriteLine("Informe o nome do segundo jogador: ");
        String jogador2 = (Console.ReadLine());
        
        while (jogador1 == jogador2){
            Console.WriteLine("O nome dos jogadores não podem ser iguais. Digte novamente!");

            Console.WriteLine("Primeiro jogador: ");
            jogador1 = (Console.ReadLine());
            Console.WriteLine("Segundo jogador: ");
            jogador2 = (Console.ReadLine());
        }

        int pontosJogador1 = 0;
        int pontosJogador2 = 0;
        
        for (int rodada = 1; rodada <= 3; rodada++){
            int numJogador1 = random.Next(1 ,7);
            int numJogador2 = random.Next(1, 7);

            Console.WriteLine($"Rodada: {rodada}");
            if (numJogador1 > numJogador2){
                Console.WriteLine($"{jogador1} tirou {numJogador1} e {jogador2} tirou {numJogador2}. {jogador1} venceu a rodada {rodada}!");
                pontosJogador1++;

                Console.WriteLine($"Pontos dos jogadores: {jogador1}: {pontosJogador1} pontos, {jogador2}:{pontosJogador2} pontos.");
                

            } else if (numJogador2 > numJogador1){
                Console.WriteLine($"{jogador1} tirou {numJogador1} e {jogador2} tirou {numJogador2}. {jogador2} venceu a rodada {rodada}!");
                pontosJogador2++;

                Console.WriteLine($"Pontos dos jogadores: {jogador1}: {pontosJogador1} pontos, {jogador2}:{pontosJogador2} pontos");


            } else if (numJogador1 == numJogador2){
                Console.WriteLine($"{jogador1} tirou {numJogador1} e {jogador2} tirou {numJogador2}. Empate!");
                Console.WriteLine($"Pontos dos jogadores: {jogador1}: {pontosJogador1} pontos, {jogador2}:{pontosJogador2} pontos");
            }

        }
        if (pontosJogador1 == pontosJogador2)
        {
        
            while(pontosJogador1 == pontosJogador2){
                Console.WriteLine("Empate. Vamos para o desempate, quem fizer primeiro ganha!");
                int numJogador1 = random.Next(1 ,7);
                int numJogador2 = random.Next(1, 7);

                Console.WriteLine("Rodada de desempate");
                Console.WriteLine($"{jogador1}: {numJogador1} | {jogador2}: {numJogador2}");

                if (numJogador1 > numJogador2){
                    Console.WriteLine($"{jogador1} venceu a rodada de desempate");
                    pontosJogador1++;

                } else if (numJogador2 > numJogador1){
                    Console.WriteLine($"{jogador2} venceu a rodada de desempate");
                    pontosJogador2++;

                } else{
                    Console.WriteLine("Empate! Vai mais uma...");
                }
            }
        }
            Console.WriteLine("=== PLACAR FINAL ===");
            if (pontosJogador1 > pontosJogador2) {
                Console.WriteLine($"{jogador1} com {pontosJogador1} pontos venceu!");
            } else{
                Console.WriteLine($"{jogador2} com {pontosJogador2} pontos venceu!");
            } 
    }
}


*/ 