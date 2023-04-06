namespace Lista02Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
            seu peso ideal, utilizando as seguintes fórmulas:
            Para homens: (72.7 * h) - 58
            Para mulheres: (62.1 * h) - 44.7*/

            double h; double peso;
            Console.WriteLine("Olá! Digite sua altura:");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Você é homem ou mulher? escolhe entre H ou M ");
            char sex= Console.ReadLine().ToUpper()[0];
            
            switch (sex)
            {
                case 'H':
                    peso = (72.7 * h)-58; 
                    Console.WriteLine($"Seu peso ideal é:{peso}");
                break;

                case 'M':
                    peso = (62.1 * h) - 44.7;
                    Console.WriteLine($"Seu peso ideal é:{peso}");
                break;

                default:
                    Console.WriteLine("Sexo Inválido");
                break;
            }

        }
    }
}