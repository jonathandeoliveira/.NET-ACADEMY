using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWF_AlunosXYZ
{
    internal class Persistencia
    {
        public static void ExibirDadosDoArquivo(string nomeArquivo)
        {
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            do
            {
                Console.WriteLine(leitor.ReadToEnd());
            } while (!leitor.EndOfStream);
            leitor.Close();
        }

        public static void popularLista(string nomeArquivo, List<string[]> lista)
        {
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            string[] vetorLinha;
            string linha;
            do
            {
                linha = leitor.ReadLine();
                vetorLinha = linha.Split('-');
                if (vetorLinha[0] != "X") // Ignora as linhas que começam por X
                {
                    lista.Add(vetorLinha);
                }
            } while (!leitor.EndOfStream);
            leitor.Close();
        }

        public static void criarObjetos(List<string[]> lista,ListBox listBox)
        {

            List<Pessoa> pessoas = new List<Pessoa>();
            List<Aluno> alunos = new List<Aluno>();
            Pessoa pessoaAtual = null;
            for (int i = 0; i < lista.Count; i++)
            {
                string[] linhaAtual = lista[i];

                if (linhaAtual[0] == "Z")
                {
                    pessoaAtual = new Pessoa(linhaAtual[1], linhaAtual[2], linhaAtual[3], linhaAtual[4], linhaAtual[5]);
                    pessoas.Add(pessoaAtual);
                    listBox.Items.Add($"Pessoa: {pessoaAtual.Nome} - Curso: Não realiza");

                }
                else if (linhaAtual[0] == "Y" && pessoaAtual != null)
                {
                    Aluno aluno = new Aluno(linhaAtual[1], linhaAtual[2], linhaAtual[3], pessoaAtual);
                    alunos.Add(aluno);
                    listBox.Items.Add($"Aluno: {aluno.Nome} - Curso: {aluno.NomeCurso}");
                }
            }

            listBox.Items.Add($"Total de Alunos Criados:{alunos.Count} ");
            listBox.Items.Add($"Total de Pessoas Criadas:{pessoas.Count} ");
        }

        public static void popularListBox(List<string[]> lista, ListBox listBox)
        {
            foreach (var item in lista)
            {
                string linha = string.Join(" ", item);
                listBox.Items.Add(linha);
            }
        }



    }
}
