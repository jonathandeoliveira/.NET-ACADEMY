using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSistemaCadastro
{
    internal class Persistencia
    {
        public static void lerArquivoParaTela(string nomeArquivo)
        {
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            do
            {
                Console.WriteLine(leitor.ReadToEnd());
            } while (!leitor.EndOfStream);
            leitor.Close();
        }
        public static void lerArquivoExibeNomes(string nomeArquivo)
        {
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            string[] vetorLinha;
            string linha;
            do
            {
                linha = leitor.ReadLine();
                vetorLinha = linha.Split(";");
                Console.WriteLine(vetorLinha[0]);
            } while (!leitor.EndOfStream);
            leitor.Close();
        }

        public static void popularArquivoLista(string nomeArquivo, List<Pessoa> lista)
        {
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            string[] vetorLinha;
            string linha;
            do
            {
                linha = leitor.ReadLine();
                vetorLinha = linha.Split(";");
                lista.Add(new Pessoa(vetorLinha[0], vetorLinha[1], vetorLinha[2]));
            } while (!leitor.EndOfStream);
            leitor.Close();
        }

        public static void exibirLista(List<Pessoa> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public static void gravarListaArquivo(List<Pessoa> lista, string nomeArquivo)
        {
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);
            foreach (var item in lista)
            {
                escritor.WriteLine($"{item.Nome};{item.Email};{item.DataNascimento};");
                escritor.Flush();
            }
            escritor.Close();
        }

        public static void atualizarPessoaArquivo(Pessoa pessoa, string nomeArquivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);

                escritor.WriteLine(pessoa.Nome + ";" + pessoa.Email + ";" + pessoa.DataNascimento);

                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }

    }
}
