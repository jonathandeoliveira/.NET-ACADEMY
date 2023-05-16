namespace DesafioSistemaCadastro
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            string arquivo = "E:\\Visual Studio\\Repos\\jonathandeoliveira\\.NET-ACADEMY\\POO\\Lista01\\DesafioSistemaCadastro\\Dados.dat";
            char op;
            do 
            {
                
               
                Console.WriteLine("Olá, bem vindo!\n " +
                    "Escolha uma das seguintes opções:\n" +
                    "1- Cadastrar Pessoa | 2- Listar Pessoas | 3- Pesquisar pessoa | 4- Excluir Pessoa | 5- Sair ");
                op = Console.ReadLine()[0];
                switch (op)
                {
                    case '1':
                        Console.WriteLine("Você selecionou: 1- Cadastrar Pessoa");
                        Operacoes.Cadastrar(listaPessoas,arquivo);
                        break;

                    case '2':
                        Console.WriteLine("Você selecionou: 2- Listar Pessoas");
                        Operacoes.LerArquivo(arquivo);
                        break;
                    case '3':
                        Console.WriteLine("Você selecionou: 3- Pesquisar pessoa");
                        Operacoes.Buscar(arquivo);
                        break;

                    case '4':
                        Console.WriteLine("Você selecionou: 4- Excluir Pessoa");
                        Operacoes.Deletar(arquivo);
                        break;

                    case '5':
                        Console.WriteLine("Você selecionou: 5- Sair \n Fechando a aplicação ");
                        break;
                }
            } while (op != '5');
        }

    }
}