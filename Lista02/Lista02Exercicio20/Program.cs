namespace Lista02Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
            plus: você pode gerar o número de forma randomica (função random c#) */
            Random random = new Random();
            int i = random.Next(1, 20);
            int chances = 3;
            
            Console.WriteLine("Olá, vamos adivinhar o número secreto? Digite um número!");
            Console.WriteLine()
        }
    }
}