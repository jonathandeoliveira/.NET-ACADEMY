using System.Xml.Schema;

namespace L03P2Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
                Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
                Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
                Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
                escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
                de votos em branco.  */

            int voto_joao = 0 , voto_zeca = 0, voto_branco = 0;
            string voto;
            while (true)
            {
                Console.WriteLine("Olá cidadão, em quem deseja votar? \n JOAO \n ZECA \n BRANCO \n\n Digite seu voto:");
                voto = Console.ReadLine();
                switch (voto.ToUpper()) {
                    case "JOAO":
                        voto_joao += 1;
                        Console.WriteLine($"VOTO COMPUTADO COM SUCESSO!\n Você votou em {voto} \n");
                        break;
                    case "ZECA":
                        voto_zeca += 1;
                        Console.WriteLine($"VOTO COMPUTADO COM SUCESSO!\n Você votou em {voto} \n");
                        break;
                    case "BRANCO":
                        voto_branco += 1;
                        Console.WriteLine($"VOTO COMPUTADO COM SUCESSO!\n Você votou em {voto} \n");
                        break;
                }
                if (voto.ToUpper() == "FIM") {
                    Console.WriteLine($"CONTAGEM TOTAL DE VOTOS:\n JOAO = {voto_joao}\n ZECA = {voto_zeca} \n BRANCO = {voto_branco} \n");
                    break;
                }
            }
        }
    }
}