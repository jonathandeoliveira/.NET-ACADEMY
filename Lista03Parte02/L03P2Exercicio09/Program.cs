namespace L03P2Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
                o zoológico num determinado dia, imprimindo:
                Quantas pessoas tem entre 1 e 3 filhos.
                Quantas pessoas tem entre 4 e 7 filhos.
                Quantas pessoas tem mais de 8 filhos.
                Quantas pessoas não tem filhos. */

            int pessoas = 30, categoria_a = 0, categoria_b = 0, categoria_c = 0, categoria_d = 0, filhos;

            for (int i = 1; i <= pessoas; i++)
            {
                Console.WriteLine($"Olá pessoa numero {i}, você tem quantos filhos?");
                filhos = int.Parse(Console.ReadLine());
                if (filhos == 0) { categoria_a++; }
                else if (filhos >= 1 && filhos <= 3) { categoria_b++; }
                else if (filhos >= 4 && filhos <= 7) { categoria_c++; }
                else { categoria_d++; }
            }
            Console.WriteLine($"A quantidade de pessoas sem filhos é de: {categoria_a}\n");
            Console.WriteLine($"A quantidade de pessoas com 1 a 3 filhos é de: {categoria_b}\n");
            Console.WriteLine($"A quantidade de pessoas com 4 a 7 filhos é de: {categoria_c}\n");
            Console.WriteLine($"A quantidade de pessoas com mais de 8 filhos é de: {categoria_d}\n");
        }
    }

}