namespace Lista02Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
               O programa deve mostrar os dados do atleta mais novo e mais alto. */

            double athlete1_age; double athlete2_age; double athlete1_height; double athlete2_height;
            string athlete1_name;string athlete2_name;

            Console.WriteLine("Olá atleta 1, insira seu nome");
            athlete1_name = Console.ReadLine();
            Console.WriteLine("Agora, insira sua idade");
            athlete1_age = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora, insira sua altura");
            athlete1_height = double.Parse(Console.ReadLine());

            Console.WriteLine("Olá atleta 2, insira seu nome");
            athlete2_name = Console.ReadLine();
            Console.WriteLine("Agora, insira sua idade");
            athlete2_age = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora, insira sua altura");
            athlete2_height = double.Parse(Console.ReadLine());

            if (athlete1_age < athlete2_age)
            {
                Console.WriteLine($"O {athlete1_name} é o mais novo");
            }
            else if (athlete1_age > athlete2_age) {
                Console.WriteLine($"O {athlete2_name} é o mais novo");
            }
            else
            {
                Console.WriteLine($"{athlete1_name} e {athlete2_name} possuem a mesma idade");
            }

            if (athlete1_height > athlete2_height)
            {
                Console.WriteLine($"O {athlete1_name} é o mais alto");
            }

            else if (athlete1_height < athlete2_height)
            {
                Console.WriteLine($"O {athlete2_name} é o mais alto");
            }
            else {
                Console.WriteLine($"{athlete1_name} e {athlete2_name} possuem a mesma altura");
            }
        }
    }
}