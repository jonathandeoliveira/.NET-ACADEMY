using System.Data.Common;

namespace Lista03P2Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
                ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
                Considerar nota 7,0 como mínima para aprovação. */ 

            int count = 1;
            double nota, media = 0;
            while (count <= 4) {
                Console.WriteLine($"Digite a nota {count} do aluno:");
                nota = double.Parse( Console.ReadLine());
                if (count == 1)
                {
                    media += (nota * 2);
                }
                else if (count == 2)
                {
                    media += nota ;
                }
                else if (count == 3)
                {
                    media += (nota * 2);
                }
                else
                {
                    media += (nota * 4);
                }
                count++;
            }
            media = (media / 9);
            if (media >= 7.0){ Console.WriteLine($"Média de: {media}. Aluno Aprovado!");}
            else { Console.WriteLine($"Média de: {media}. Aluno Reprovado.");}
             
        }
    }
}