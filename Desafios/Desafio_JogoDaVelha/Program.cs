using System.Security.Cryptography.X509Certificates;

namespace Desafio_JogoDaVelha
{
    internal class Program
    {
        /*public static void WinCondition(string[] player1, string[] player2)
        {
            if (player1.Length == 3 && player1 == {'00','01','20'} ) { }
        }*/

        static void Main(string[] args)
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





            bool fimdejogo = false;

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
                    while (true) { 
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
                        Console.WriteLine($"Jogada {rodada} do Jogador X, escolha uma posição do tabuleiro acima para jogar.");
                        jogada = Console.ReadLine()[0];

                        fimdejogo = true;
                        break;
                    }
                break;

                case '2':
                    Console.WriteLine("Funcionalidade ainda não implementada");
                break;
            }
        }
    }
}