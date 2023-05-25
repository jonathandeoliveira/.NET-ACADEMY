using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWF_Estacionamento
{
    internal class Persistencia
    {
        public static void lerArquivoVeiculosEntrada(List<Veiculo> lista)
        {
            try
            {
                StreamReader leitor = new StreamReader("veiculoEntrada", Encoding.UTF8);
                string[] vetorLinha;
                string linha;
                do
                {
                    linha = leitor.ReadLine();
                    vetorLinha = linha.Split(";");
                    lista.Add(new Veiculo(vetorLinha[0], vetorLinha[1], vetorLinha[2]));
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo ou arquivo não localizado!");
            }
        }

        public static void lerArquivoVeiculosSaida(string nomeArquivo, List<Veiculo> lista)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha; //[nome, email, dataNascimento]
                string linha;
                do
                {
                    linha = leitor.ReadLine();//Leandro Di Nardo Lazarin;lazarin@ufn.edu.br;12/12/1990
                    vetorLinha = linha.Split(";"); //[Leandro Di Nardo Lazarin, lazarin@ufn.edu.br, 12/12/1990]
                    lista.Add(new Veiculo(vetorLinha[0], vetorLinha[1], vetorLinha[2]));
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo ou arquivo não localizado!");
            }
        }



        public static void gravarArquivoVeiculosEntrada(List<Veiculo> lista,ListBox listbox)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("veiculoEntrada.dat", append: true);
                foreach (var veiculo in lista)
                {
                    escritor.WriteLine(veiculo.Placa + ";" + veiculo.DataEntrada + ";" + veiculo.HoraEntrada);
                    escritor.Flush();
                    listbox.Items.Add(veiculo.Placa + " - " + veiculo.DataEntrada + " - " + veiculo.HoraEntrada);
                }
                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static void gravarArquivoVeiculosSaida(List<Veiculo> lista, string nomeArquivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo); //sempre o arquivo é criado do zero
                                                                       //StreamWriter escritor = new StreamWriter(nomeArquivo, append:true); //possibilidade de adionar dados no arquivo
                foreach (var veiculo in lista)
                {
                    escritor.WriteLine(veiculo.Placa + ";" + veiculo.DataEntrada + ";" + veiculo.DataSaida);
                    escritor.Flush();
                }
                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }


    }
}
