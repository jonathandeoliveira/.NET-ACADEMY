using System.Xml.Schema;

namespace L03P2Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
                a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura. */
            double grade, grade_sum = 0, median = 0;
            double? higher_grade = null, lower_grade = null;
            int students_count = 0, option;

            while (true)
            {
                Console.WriteLine("Olá, digite a nota do aluno:");
                grade = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota adicionada com sucesso! \n");
                grade_sum += grade;
                students_count++;
                if (grade > higher_grade || higher_grade == null) { 
                    higher_grade = grade;
                }
                else if (lower_grade > grade || lower_grade == null ) {
                    lower_grade = grade;
                }
                
                Console.WriteLine("Caso deseje adicionar outras notas, digite qualquer numero. \n Caso deseje sair, digite '-1'");
                option = int.Parse(Console.ReadLine());
                
                if (option == -1)
                {
                    break;
                }
                median = (grade_sum / students_count);           
            }
            Console.WriteLine($"A maior nota da turma é:{higher_grade}");
            Console.WriteLine($"A menor nota da turma é:{lower_grade}");
            Console.WriteLine($"A nota média da turma é de: {median}");
        }
    }
}