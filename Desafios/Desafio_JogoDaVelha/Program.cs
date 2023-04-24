using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Desafio_JogoDaVelha
{
    internal class Program
    {
        /*  
             Desenvolva um jogo da velha utilizando matrizes em C#. Faça com que cada jogador insira a sua jogada em uma interface amigavel. 
              Teste se a posição é válida e caso não seja solicite ao jogador repetir a jogada. Após cada jogada, apresente o tabuleiro com as 
              jogadas representadas por "X" e "O" e faça a verficação se algum jogador venceu.
              Caso seja empate, apresente o resultado na tela. Possilibilite que o jogo seja reinicializado sem a necessidade de reiniciar o jogo. 


              Desafio extra, pode valer por alguma atividade futura: Faça a implementação de um jogo contra o computador. Faça o possível para evitar que o jogador vença do computador. 
              Para facilitar, faça com que o computador inicie jogando.

              Prazo de entrega: 24/04
              Forma e envio: Enviar pelo chat o link do github

              Matriz e posições: 
              0,0  1    |   0,1  2   |   0,2  3   win condition = [00,10,20], [00,01,02], [00,11,22],[02,11,20],[01,11,21],[02,12,22],[20,21,22][10,11,12]
              1,0  4    |   1,1  5   |   1,2  6
              2,0  7    |   2,1  8   |   2,2  9
          */
        public static bool HardBot(char[,] matriz, int rodada_bot)
        {
            Random random = new Random();
            //int index = random.Next(0, 2);
            //int[] numero = {3, 7};
            //char numero_random = Convert.ToChar(numero[index].ToString());
            // rodada 1
            if (rodada_bot == 1)
            {
                matriz[0, 0] = 'X';
            }
            // rodada 2
            if (rodada_bot == 2  && matriz[0,0] == 'X')
            {
                bool valida = false;
                while (!valida)
                {
                    int index = random.Next(0, 2);
                    int[] numero = { 3, 7 };
                    char numero_random = Convert.ToChar(numero[index].ToString());
                    for (int linha = 0; linha < matriz.GetLength(0); linha++)
                    {
                        for (int col = 0; col < matriz.GetLength(1); col++)
                        {
                            if (matriz[linha, col] == numero_random)
                            {
                                matriz[linha, col] = 'X';
                                valida = true;
                            }
                        }
                    }
                }
            }
            // rodada 3
            if (rodada_bot == 3)
            {    
                if (matriz[2, 0] == 'X') // 1 e 7
                {
                    if (matriz[1, 0] != 'O') { matriz[1, 0] = 'X'; }
                    else if (matriz[1, 2] != 'O') { matriz[1, 2] = 'X'; }
                }
                else if (matriz[0, 2] == 'X') // 1 e 3
                {
                    if (matriz[0, 1] != 'O') { matriz[0, 1] = 'X'; }
                    else if (matriz[2, 1] != 'O') { matriz[2, 1] = 'X'; }
                    else if (matriz[1, 1] != 'O'){ matriz[1, 1] = 'X'; }
                    else
                    {
                        bool valida = true;
                        while (valida)
                        {
                            int index = random.Next(0, 10);
                            char jogador_atual = 'X';
                            char numero_random = Convert.ToChar(index.ToString());
                            for (int linha = 0; linha < matriz.GetLength(0); linha++)
                            {
                                for (int col = 0; col < matriz.GetLength(1); col++)
                                {
                                    if (matriz[linha, col] == numero_random && valida == true)
                                    {
                                        matriz[linha, col] = jogador_atual;
                                        valida = false;
                                    }
                                }
                            }
                        }
                    }

                }
            
            }

            //rodada 4
            if (rodada_bot == 4)
            {
                if (matriz[0, 0] == 'X' && matriz[2, 0] == 'X' && matriz[1, 2] == 'X') // 1 e 7 e 6
                {
                    if (matriz[1, 1] != 'O') { matriz[1, 1] = 'X'; }
                    else if (matriz[2,1] != 'O') { matriz[2, 1] = 'X'; }
                    else if (matriz[0,1] != 'O') { matriz[0, 1] = 'X'; }
                    else
                    {
                        bool valida = true;
                        while (valida)
                        {
                            int index = random.Next(0, 10);
                            char jogador_atual = 'X';
                            char numero_random = Convert.ToChar(index.ToString());
                            for (int linha = 0; linha < matriz.GetLength(0); linha++)
                            {
                                for (int col = 0; col < matriz.GetLength(1); col++)
                                {
                                    if (matriz[linha, col] == numero_random && valida == true)
                                    {
                                        matriz[linha, col] = jogador_atual;
                                        valida = false;
                                    }
                                }
                            }
                        }
                    }
                }


                else if (matriz[0, 0] == 'X' && matriz[0, 2] == 'X' && matriz[2,1] == 'X')//  1 e 3 e 8
                {
                    if (matriz[0, 1] != 'O') { matriz[0,1] = 'X' ;}
                    else if (matriz[1,2] != 'O') { matriz[1,2] = 'X';}
                    else if (matriz[1,0] != 'O') { matriz[1,0] = 'X'; }
                    else
                    {
                        bool valida = true;
                        while (valida)
                        {
                            int index = random.Next(0, 10);
                            char jogador_atual = 'X';
                            char numero_random = Convert.ToChar(index.ToString());
                            for (int linha = 0; linha < matriz.GetLength(0); linha++)
                            {
                                for (int col = 0; col < matriz.GetLength(1); col++)
                                {
                                    if (matriz[linha, col] == numero_random && valida == true)
                                    {
                                        matriz[linha, col] = jogador_atual;
                                        valida = false;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    bool valida = true;
                    while (valida)
                    {
                        int index = random.Next(0, 10);
                        char jogador_atual = 'X';
                        char numero_random = Convert.ToChar(index.ToString());
                        for (int linha = 0; linha < matriz.GetLength(0); linha++)
                        {
                            for (int col = 0; col < matriz.GetLength(1); col++)
                            {
                                if (matriz[linha, col] == numero_random && valida == true)
                                {
                                    matriz[linha, col] = jogador_atual;
                                    valida = false;
                                }
                            }
                        }
                    }
                }

            }


            if (rodada_bot == 5)
            {
                if (matriz[0, 0] == 'X' && matriz[2, 0] == 'X' && matriz[1, 2] == 'X')  // 1 e 7 e 6 e 2
                {
                    if (matriz[2, 2] != 'O' && matriz[2, 2] != 'X') { matriz[2, 2] = 'X'; }
                    else if (matriz[2, 1] != 'O' && matriz[2, 1] != 'X' ) { matriz[2, 1] = 'X'; }
                    else
                    {
                        bool valida = true;
                        while (valida)
                        {
                            int index = random.Next(0, 10);
                            char jogador_atual = 'X';
                            char numero_random = Convert.ToChar(index.ToString());
                            for (int linha = 0; linha < matriz.GetLength(0); linha++)
                            {
                                for (int col = 0; col < matriz.GetLength(1); col++)
                                {
                                    if (matriz[linha, col] == numero_random && valida == true)
                                    {
                                        matriz[linha, col] = jogador_atual;
                                        valida = false;
                                    }
                                }
                            }
                        }
                    }
                } 

                else if (matriz[0, 0] == 'X' && matriz[2, 0] == 'X' && matriz[1, 2] == 'X')  // 1 e 7 e 6 e 8
                {
                    if (matriz[2, 2] != 'O' && matriz[2, 2] != 'X') { matriz[2, 2] = 'X'; }
                    else if (matriz[2, 1] != 'O') { matriz[2, 1] = 'X'; }
                    else
                    {
                        bool valida = true;
                        while (valida)
                        {
                            int index = random.Next(0, 10);
                            char jogador_atual = 'X';
                            char numero_random = Convert.ToChar(index.ToString());
                            for (int linha = 0; linha < matriz.GetLength(0); linha++)
                            {
                                for (int col = 0; col < matriz.GetLength(1); col++)
                                {
                                    if (matriz[linha, col] == numero_random && valida == true)
                                    {
                                        matriz[linha, col] = jogador_atual;
                                        valida = false;
                                    }
                                }
                            }
                        }
                    }
                }

                else if (matriz[0, 0] == 'X' && matriz[0, 2] == 'X' && matriz[2, 1] == 'X')//  1 e 3 e 8 e 6
                {
                    if (matriz[2, 2] != 'O' && matriz[2, 2] != 'X') { matriz[2, 2] = 'X'; }
                    else if(matriz[2, 0] != 'O') { matriz[2, 0] = 'X'; }
                    else
                    {
                        bool valida = true;
                        while (valida)
                        {
                            int index = random.Next(0, 10);
                            char jogador_atual = 'X';
                            char numero_random = Convert.ToChar(index.ToString());
                            for (int linha = 0; linha < matriz.GetLength(0); linha++)
                            {
                                for (int col = 0; col < matriz.GetLength(1); col++)
                                {
                                    if (matriz[linha, col] == numero_random && valida == true)
                                    {
                                        matriz[linha, col] = jogador_atual;
                                        valida = false;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    bool valida = true;
                    while (valida)
                    {
                        int index = random.Next(0, 10);
                        char jogador_atual = 'X';
                        char numero_random = Convert.ToChar(index.ToString());
                        for (int linha = 0; linha < matriz.GetLength(0); linha++)
                        {
                            for (int col = 0; col < matriz.GetLength(1); col++)
                            {
                                if (matriz[linha, col] == numero_random && valida == true)
                                {
                                    matriz[linha, col] = jogador_atual;
                                    valida = false;
                                }
                            }
                        }
                    }
                }

            }






            return false;
        }

        public static void imprimeTabuleiro(char[,] matriz)
        {
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    Console.Write(matriz[linha, col] + "\t" + " | " + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n");

        }

        public static void easyBot(char[,] matriz) { 
        }

        public static bool WinCondition(char[,] matriz)
        {
            //Win Condition das linhas
            // Linha 1 Jogador X
            if ((matriz[0,0] == 'X' && matriz[0, 1] == 'X' && matriz[0, 2] == 'X'))              
            {           
                return true;
            }
            // Linha 1 Jogador O
            if ((matriz[0, 0] == 'O' && matriz[0, 1] == 'O' && matriz[0, 2] == 'O'))            
            {
                return true;
            }
            // Linha 2 Jogador X
            else if ((matriz[1, 0] == 'X' && matriz[1, 1] == 'X' && matriz[1, 2] == 'X'))       
            {     
                return true;
            }
            // Linha 2 Jogador O
            else if ((matriz[1, 0] == 'O' && matriz[1, 1] == 'O' && matriz[1, 2] == 'O'))       
            {
                return true;
            }
            // Linha 3 Jogador X
            else if ((matriz[2, 0] == 'X' && matriz[2, 1] == 'X' && matriz[2, 2] == 'X'))       
            {    
                return true;
            }
            // Linha 3 Jogador O
            else if ((matriz[2, 0] == 'O' && matriz[2, 1] == 'O' && matriz[2, 2] == 'O'))
            {
                return true;
            }

            // Win Condition das colunas 
            // Coluna 1 Jogador X
            else if ((matriz[0, 0] == 'X' && matriz[1,0] == 'X' && matriz[2, 0] == 'X'))        
            {
                return true;
            }
            // Coluna 1 Jogador O
            else if ((matriz[0, 0] == 'O' && matriz[1, 0] == 'O' && matriz[2, 0] == 'O'))
            {
                return true;
            }

            // Coluna 2 Jogador X
            else if ((matriz[0, 1] == 'X' && matriz[1, 1] == 'X' && matriz[2, 1] == 'X'))       
            {
                return true;
            }
            // Coluna 2 Jogador O
            else if ((matriz[0, 1] == 'O' && matriz[1, 1] == 'O' && matriz[2, 1] == 'O'))
            {
                return true;
            }
            // Coluna 3 Jogador X
            else if ((matriz[0, 2] == 'X' && matriz[1, 2] == 'X' && matriz[2, 2] == 'X'))       
            {
                return true;
            } 
            // Coluna 3 Jogador O
            else if ((matriz[0, 2] == 'O' && matriz[1, 2] == 'O' && matriz[2, 2] == 'O'))
            {
                return true;
            }
            // Win Condition das diagonais
            // Diagonal Principal do Jogador X
            else if ((matriz[0, 0] == 'X' && matriz[1, 1] == 'X' && matriz[2, 2] == 'X'))       
            {
                return true;
            }
            // Diagonal Principal do Jogador O
            else if ((matriz[0, 0] == 'O' && matriz[1, 1] == 'O' && matriz[2, 2] == 'O'))
            {
                return true;
            }
            // Diagonal Secundária do Jogador X
            else if ((matriz[2, 0] == 'X' && matriz[1, 1] == 'X' && matriz[0, 2] == 'X'))       
            {
                return true;
            }
            // Diagonal Secundária do Jogador O
            else if ((matriz[2, 0] == 'O' && matriz[1, 1] == 'O' && matriz[0, 2] == 'O'))
            {
                return true;
            }
            else { return false; }
        }

        static void Main(string[] args)
        {
            bool valida = false;
            char[,] tabuleiro = new char[3, 3];
            char menu;
            char jogador_atual = 'X';
            int rodada = 1;
            char jogada;
            Console.WriteLine("Olá, bem vindo ao jogo da velha! Selecione a opção:\n\n 1- 2 Jogadores \n 2- Jogar contra o computador");
            menu = Console.ReadLine()[0];
            switch (menu)
            {
                case '1':
                    // Gera matriz do Tabuleiro //
                    Console.WriteLine("Opção de 2 Jogadores selecionada!");
                    Console.WriteLine("------------------------------------ \n");
                    Console.WriteLine("Tabuleiro do jogo:");
                    int contador = 1;
                    for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
                    {
                        for (int col = 0; col < tabuleiro.GetLength(1); col++)
                        {
                            tabuleiro[linha, col] = Convert.ToChar(contador.ToString());
                            contador++;
                            Console.Write(tabuleiro[linha, col] + "\t" + " | " + "\t");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine("\n");
                    while (!WinCondition(tabuleiro))
                    {
                        //Inicia as rodadas
                        do // faz uma jogada e alterna o jogador
                        {
                            Console.WriteLine($"Jogada {rodada} do Jogador {jogador_atual}, escolha uma posição válida do tabuleiro acima para jogar.");
                            jogada = Console.ReadLine()[0];
                            for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
                            {
                                for (int col = 0; col < tabuleiro.GetLength(1); col++)
                                {
                                    if (tabuleiro[linha, col] == jogada)
                                    {
                                        tabuleiro[linha, col] = jogador_atual;
                                        valida = true;
                                        rodada++;
                                        jogador_atual = (jogador_atual == 'X') ? 'O' : 'X';
                                    }
                                }
                            }
                        } while (!valida);
                        Console.WriteLine($" o próximo jogador é: {jogador_atual}\n");
                        imprimeTabuleiro(tabuleiro);
                        if (rodada >= 9) { break; }
                    }
                    Console.WriteLine(" FIM DE JOGO!");
                    if (rodada >= 9 && WinCondition(tabuleiro) == false){ Console.WriteLine("EMPATE!"); }
                    else if(jogador_atual == 'O') { Console.WriteLine($"O vencedor foi: 'X'"); }
                    else{ Console.WriteLine($"O vencedor foi: 'O'"); }
                break;

                case '2':
                    // Gera matriz do Tabuleiro //
                    Console.WriteLine("Opção de 1 jogador selecionada!");
                    Console.WriteLine("Selecione a dificuldade que deseja jogar: 1- Fácil 2- Difícil");
                    char dificuldade = Console.ReadLine()[0];
                    int rodada2 = 1;
                    switch(dificuldade)
                    {
                        case '1':
                            Random random = new Random();
                            Console.WriteLine("Dificuldade: Fácil Selecionada");
                            Console.WriteLine("------------------------------------ \n");
                            Console.WriteLine("Tabuleiro do jogo:");
                            int contador2 = 1;
                            for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
                            {
                                for (int col = 0; col < tabuleiro.GetLength(1); col++)
                                {
                                    tabuleiro[linha, col] = Convert.ToChar(contador2.ToString());
                                    contador2++;
                                    Console.Write(tabuleiro[linha, col] + "\t" + " | " + "\t");
                                }
                                Console.WriteLine("");
                            }
                            Console.WriteLine("\n\n");
                            Console.WriteLine("------------------------------------ \n");

                            Console.WriteLine("Inicio de jogo: \n\n");


                            while (!WinCondition(tabuleiro))
                            {
                                valida = true;
                                do
                                {
                                    jogador_atual = 'X';
                                    for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
                                    {
                                        for (int col = 0; col < tabuleiro.GetLength(1); col++)
                                        {
                                            int rand_linha = random.Next(0, 3);
                                            int rand_col = random.Next(0, 3);
                                            if (tabuleiro[rand_linha, rand_col] != 'X' && tabuleiro[rand_linha, rand_col] != 'O' && valida == true)
                                            {
                                                tabuleiro[rand_linha, rand_col] = jogador_atual;
                                                valida = false;
                                            }
                                        }
                                    }
                                } while (valida);
                                imprimeTabuleiro(tabuleiro);
                                Console.WriteLine("\n\n");
                                do // faz uma jogada e alterna o jogador
                                {
                                    Console.WriteLine($"Vez do Jogador, escolha uma posição válida do tabuleiro acima para jogar.");
                                    jogada = Console.ReadLine()[0];
                                    jogador_atual = 'O';
                                    Console.WriteLine("\n");
                                    for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
                                    {
                                        for (int col = 0; col < tabuleiro.GetLength(1); col++)
                                        {
                                            if (tabuleiro[linha, col] == jogada)
                                            {
                                                tabuleiro[linha, col] = jogador_atual;
                                                valida = true;
                                                rodada2++;
                                            }
                                        }
                                    }
                                } while (!valida);
                                imprimeTabuleiro(tabuleiro);
                                if (rodada2 > 4) { break; }
                            }
                            Console.WriteLine(" FIM DE JOGO!");
                            if (rodada2 > 4 && WinCondition(tabuleiro) == false) { Console.WriteLine("EMPATE!"); }
                            else if (jogador_atual == 'X') { Console.WriteLine($"O vencedor foi: 'X'"); }
                            else { Console.WriteLine($"O vencedor foi: 'O'"); }
                        break; // break do case 2.1 - Vs computador Fácil

                        case '2':
                            Console.WriteLine("Dificuldade: Difícil Selecionada");
                            Console.WriteLine("------------------------------------ \n");
                            Console.WriteLine("Tabuleiro do jogo:");
                            int contador3 = 1;
                            int rodadabot = 1;
                            int rodada3 = 1;
                            for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
                            {
                                for (int col = 0; col < tabuleiro.GetLength(1); col++)
                                {
                                    tabuleiro[linha, col] = Convert.ToChar(contador3.ToString());
                                    contador3++;
                                    Console.Write(tabuleiro[linha, col] + "\t" + " | " + "\t");
                                }
                                Console.WriteLine("");
                            }
                            Console.WriteLine("\n\n");
                            Console.WriteLine("------------------------------------ \n");

                            Console.WriteLine("Inicio de jogo:");
                            while (!WinCondition(tabuleiro))
                            {
                                Console.WriteLine($"Rodada{rodadabot} do Computador");
                                HardBot(tabuleiro, rodadabot);
                                rodadabot++;
                                imprimeTabuleiro(tabuleiro);
                                if (WinCondition(tabuleiro)) { break; }
                                if (rodadabot > 5) { break; }

                                do // faz uma jogada e alterna o jogador
                                {
                                    Console.WriteLine($"Vez do Jogador, escolha uma posição válida do tabuleiro acima para jogar.");
                                    jogada = Console.ReadLine()[0];
                                    jogador_atual = 'O';
                                    Console.WriteLine("\n");
                                    for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
                                    {
                                        for (int col = 0; col < tabuleiro.GetLength(1); col++)
                                        {
                                            if (tabuleiro[linha, col] == jogada)
                                            {
                                                tabuleiro[linha, col] = jogador_atual;
                                                valida = true;
                                                rodada2++;
                                                jogador_atual = 'X';
                                            }
                                        }
                                    }
                                } while (!valida);
                                imprimeTabuleiro(tabuleiro);
                                //if (rodadabot > 5 ) { break; }
                            }
                            //imprimeTabuleiro(tabuleiro);
                            Console.WriteLine(" FIM DE JOGO!");
                            if (rodadabot > 5 && WinCondition(tabuleiro) == false) { Console.WriteLine("EMPATE!"); }
                            else if (jogador_atual == 'X') { Console.WriteLine($"O vencedor foi: 'X'"); }
                            else { Console.WriteLine($"O vencedor foi: 'O'"); }




                            break; // Break do case 2.2 - Vs computador difícil


                    }
                    break; //break do case 2
            }
        }
    }
}