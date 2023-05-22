namespace Desafio_AlunosXYZ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string[]> listaPessoa = new List<string[]>();
            List<Pessoa> pessoas = new List<Pessoa>();
            List<Aluno> alunos = new List<Aluno>();
            string nomeArquivo = "E:\\Visual Studio\\Repos\\jonathandeoliveira\\.NET-ACADEMY\\Desafios\\Desafio_AlunosXYZ\\dados.txt";
            //Persistencia.ExibirDadosDoArquivo(nomeArquivo);
            //Console.WriteLine("\n\n");
            Console.WriteLine("Lista de Pessoas Recebida:");
            Persistencia.popularLista(nomeArquivo, listaPessoa);
            Persistencia.exibirLista(listaPessoa);
            Console.WriteLine("\n\n");
            Console.WriteLine("Processando lista:");
            Persistencia.criarObjetos(listaPessoa);

        }
    }
}
