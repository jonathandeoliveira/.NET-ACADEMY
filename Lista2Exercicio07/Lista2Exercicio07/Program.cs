﻿namespace Lista2Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
            O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
            exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.*/
            Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();
            Console.WriteLine("Digite uma palavra");
            string palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine($"A palavra: '{palavra}' está presente na frase digitada");
            }
            else
            {
                Console.WriteLine($"A palavra: '{palavra}' não está presente na frase digitada");
            }


        }
    }
}