using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSistemaCadastro
{
    internal class Operacoes
    {
        public static bool validaNome(string nome)
        {
            string[] vetor = nome.Split();
            if (vetor.Length < 2)
            {
                return false;
            }
            return true;
        }

        public static bool validaData(string data)
        {

            string[] vetor = data.Split('/');
            if ((vetor[0].Length == 2) && (vetor[1].Length == 2) && (vetor[2].Length == 4))
            {
                return true;
            }
            return false;
        }

        public static void Cadastrar(List<Pessoa> listaPessoas, string arquivo)
        {
            string nome, dataNascimento;

            do
            {
                Console.WriteLine("Digite seu nome completo:");
                nome = Console.ReadLine();
            } while (!validaNome(nome));

            do {
                Console.WriteLine("Digite sua data de nascimento no formato dd/mm/aaaa");
                dataNascimento = Console.ReadLine();
            } while (!validaData(dataNascimento));

            Pessoa pessoa = new Pessoa(nome, dataNascimento);
            Console.WriteLine("Pessoa cadastrada:");
            Console.WriteLine($"Nome: {pessoa.Nome} | Data de nascimento: {pessoa.DataNascimento} | E-mail: {pessoa.Email} ");
            listaPessoas.Add(pessoa);

            if (!listaPessoas.Contains(pessoa))
            {
                listaPessoas.Add(pessoa);
                Persistencia.gravarListaArquivo(listaPessoas, arquivo);
                Console.WriteLine("Pessoa cadastrada na base de dados");

            }
            else
            {
                Console.WriteLine("Pessoa com este email já na base de dados");
            };
        }
        public static void LerArquivo(string nomeArquivo)
        {
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            do
            {
                Console.WriteLine(leitor.ReadToEnd());
            } while (!leitor.EndOfStream);
            leitor.Close();
        }

        public static void Buscar(string arquivo)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            Persistencia.popularArquivoLista(arquivo, listaPessoas);
            Console.WriteLine("Digite um nome para pesquisar");
            string pesquisar = Console.ReadLine();

            foreach (var item in listaPessoas)
            {
                if (pesquisar == item.Nome)
                {
                    Console.WriteLine("Pessoa encontrada no banco de dados: ");
                    Console.WriteLine($"Nome:{item.Nome} | Data de nascimento: {item.DataNascimento} | E-mail: {item.Email}");
                    break; 
                }
            }

        }

        public static void Deletar(string arquivo)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            Persistencia.popularArquivoLista(arquivo, listaPessoas);
            Console.WriteLine("Digite um nome para Deletar");
            string pesquisar = Console.ReadLine();
            bool removeu = false;

            foreach (var item in listaPessoas)
            {
                if (pesquisar == item.Nome)
                {
                    listaPessoas.Remove(item);
                    removeu = true;
                    break;
                }
            }
            if (removeu)
            {
                Persistencia.gravarListaArquivo(listaPessoas,arquivo);
                Console.WriteLine("Pessoa deletada com sucesso!");
            }
        }




    } 
}
