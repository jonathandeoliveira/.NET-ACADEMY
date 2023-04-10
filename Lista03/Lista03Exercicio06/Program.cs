using System.Runtime.Serialization;

namespace Lista03Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 6 - Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações 
                    aplicadas para aquela turma. Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final 
                    (média das notas das avaliações). */

            int alunos; int qtd_avaliacoes;
            double nota;  double soma_nota = 0; double media = 0;
          

            Console.Write("Digite o número de alunos da turma: ");
            alunos = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de avaliações aplicadas: ");
            qtd_avaliacoes = int.Parse(Console.ReadLine());

            for (int i = 1; i <=  alunos; i++)
            {

                Console.WriteLine("Digite a nota das avaliações dos alunos");
                    for (int j = 1; j <= qtd_avaliacoes; j++)
                    {
                        nota = double.Parse(Console.ReadLine());
                        soma_nota += nota;
                    }
                media = soma_nota / qtd_avaliacoes;
                Console.WriteLine($"A média do aluno {i} é de {media}");
            }
            

        }
    }
}