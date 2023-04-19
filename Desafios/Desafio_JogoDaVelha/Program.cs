using System.Security.Cryptography.X509Certificates;

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
              0,0     |   0,1     |   0,2    win condition = [00,10,20], [00,01,02], [00,11,22],[02,11,20],[01,11,21],[02,12,22],[20,21,22][10,11,12]
              1,0     |   1,1     |   1,2
              2,0     |   2,1     |   2,2
          */


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
                                        //Console.WriteLine(tabuleiro[linha, col] + "\n INPUT DO JOGADOR acima");
                                        valida = true;
                                        jogador_atual = (jogador_atual == 'X') ? 'O' : 'X';
                                    }
                                }
                            }
                        } while (!valida);
                        Console.WriteLine($" o próximo jogador é: {jogador_atual}\n");

                        for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
                        {
                            for (int col = 0; col < tabuleiro.GetLength(1); col++)
                            {
                                Console.Write(tabuleiro[linha, col] + "\t" + " | " + "\t");
                            }
                            Console.WriteLine("");
                        }
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine(" FIM DE JOGO!");
                    if(jogador_atual == 'O') { Console.WriteLine($"O vencedor foi: 'X'"); }
                    else{ Console.WriteLine($"O vencedor foi: 'O'"); }
                    break;

                case '2':
                    Console.WriteLine("Funcionalidade ainda não implementada");
                break;
            }
        }
    }
}