using System.Net.Http.Headers;

namespace L03P2Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
                Número de pessoas do sexo masculino.
                Número de pessoas do sexo feminino.
                Número de pessoas com idade inferior a 30 anos.
                Número de pessoas com idade superior a 60 anos.
                Média de idade das mulheres. */

            int qty = 50, age, sex, male = 0, female = 0, female_ages = 0, median, under_thirty= 0, between = 0, above_sixty = 0 ;
            string name;

            for (int i = 1; i <= qty ; i++)
            {
                Console.WriteLine($"Olá, pessoa você é a pessoa número: {i}");
                Console.WriteLine("Por favor, digite seu nome:");
                name = Console.ReadLine();
                Console.WriteLine("Por favor, informe seu sexo: \n Feminino = 1 \n Masculino = 2");
                sex = int.Parse(Console.ReadLine());
                if (sex == 1)
                {
                    female++;
                    Console.WriteLine("Por favor, nos informe sua idade:");
                    age = int.Parse(Console.ReadLine());
                    female_ages += age;
                    if (age < 30) { under_thirty++; }
                    else if (age > 60) { above_sixty++;}
                    else { between++;}
                }
                else if (sex == 2)
                {
                    male++;
                    Console.WriteLine("Por favor, nos informe sua idade:");
                    age = int.Parse(Console.ReadLine());
                    if (age < 30) { under_thirty++; }
                    else if (age > 60) { above_sixty++; }
                    else { between++; }
                }
            }
            median = (female_ages / qty);
            Console.WriteLine($"O número total de pessoas do sexo feminino é de:{female}");
            Console.WriteLine($"O número total de pessoas do sexo masculino é de:{male}");
            Console.WriteLine($"O número total de pessoas com idade inferior a 30 anos é de:{under_thirty}");
            Console.WriteLine($"O número total de pessoas com idade entre 30 e 60 anos é de:{between}");
            Console.WriteLine($"O número total de pessoas com idade acima de 60 anos é de:{above_sixty}");
            Console.WriteLine($"A média de idade entre as mulheres é de:{median}");
        }
    }
}