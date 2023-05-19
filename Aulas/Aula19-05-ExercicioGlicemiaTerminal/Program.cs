namespace Aula19_05_ExercicioGlicemiaTerminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeArquivo;
            Console.WriteLine("Digite o caminho do arquivo com dados glicêmicos");
            nomeArquivo = Console.ReadLine();
            List<Glicemia> listaGlicemias = new List<Glicemia>();
            Persistencia.popularArquivoLista(nomeArquivo, listaGlicemias);
            Comunicacao.exibir(listaGlicemias);

            // calcular a media
            Console.WriteLine("A média glicêmica: " + Estatistica.CalcularMedia(listaGlicemias));

            //calcular a mediana - antes é preciso ordenar a lista pelo campo valor da glicemia
            Console.WriteLine("A mediana: " + Estatistica.CalcularMediana(listaGlicemias));
        }
    }
}