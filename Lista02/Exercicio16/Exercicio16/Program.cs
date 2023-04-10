internal class Program
{
    private static void Main(string[] args)
    {
        /* 16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
        na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
        enfrentar novamente em um novo jogo.
        ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
        ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
        plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.*/
        Console.WriteLine("Olá, bem vindo ao assistente de jogos, digite o placar da partida:");
        Console.WriteLine("Placar do time 1:");
        double team1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Placar do time 2:");
        double team2 = double.Parse(Console.ReadLine());
        if ((team2 - team1) >= 2) { Console.WriteLine("O time dois já se classificou para a próxima fase"); }
        else
        {
            Console.WriteLine("Os dois times se enfrentarão novamente");
            Console.WriteLine("Insira os placares do segundo jogo:");
            Console.WriteLine("Placar do time 1:");
            double team1_game2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Placar do time 2:");
            double team2_game2 = double.Parse(Console.ReadLine());
            if ((team1_game2 - team2_game2) > (team2_game2 - team1_game2))
            {
                Console.WriteLine("O time 1 ganhou o segundo jogo");
            }
            else { Console.WriteLine("O time 2 ganhou o segundo jogo"); }
        }
    }
}