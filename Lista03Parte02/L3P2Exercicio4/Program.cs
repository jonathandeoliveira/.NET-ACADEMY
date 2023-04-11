namespace L3P2Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5. Modifique o programa em VS anterior para aceitar votos nulos 
            (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
            Ao final, informe o nome do candidato vencedor, o número de votos nulos 
            e o número de pessoas que votaram. */

            int voto_joao = 0, voto_zeca = 0, voto_branco = 0, voto_nulo = 0;
            string voto;
            while (true)
            {
                Console.WriteLine("Olá cidadão, em quem deseja votar? \n JOAO \n ZECA \n BRANCO \n NULO \n\n Digite seu voto:");
                voto = Console.ReadLine();
                switch (voto.ToUpper())
                {
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
                if (voto.ToUpper() != "JOAO" || voto.ToUpper() != "ZECA" || voto.ToUpper() != "BRANCO" || voto.ToUpper() != "FIM")
                {
                    voto_nulo += 1;
                    Console.WriteLine($"VOTO COMPUTADO COM SUCESSO!\n Você votou em NULO \n");
                }

                if (voto.ToUpper() == "FIM")
                {
                    Console.WriteLine($"CONTAGEM TOTAL DE VOTOS:\n JOAO = {voto_joao}\n ZECA = {voto_zeca} \n BRANCO = {voto_branco} \n NULO = {voto_nulo}");
                    if ((voto_joao > voto_zeca) && (voto_joao > voto_branco) && (voto_joao > voto_nulo)) { Console.WriteLine("O vencedor da eleição foi o JOAO"); }
                    else if ((voto_zeca > voto_joao) && (voto_zeca > voto_branco) && (voto_zeca > voto_nulo)) { Console.WriteLine("O vencedor da eleição foi o ZECA"); }
                    else if ((voto_branco > voto_joao) && (voto_branco > voto_zeca) && (voto_branco > voto_nulo)) { Console.WriteLine("O vencedor da eleição foi o BRANCO"); }
                    else{ Console.WriteLine("O vencedor da eleição foi o NULO"); }
                    break;
                }
            }
        }
    }
}