using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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



        public static void gravarArquivoVeiculosEntrada(List<Veiculo> lista, ListBox listbox)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("veiculoEntrada.dat", append: true);
                foreach (var veiculo in lista)
                {
                    escritor.WriteLine(veiculo.Placa + ";" + veiculo.DataEntrada + ";" + veiculo.HoraEntrada.ToString("HH:mm"));
                    escritor.Flush();
                }
                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static void gravarArquivoVeiculosSaida(List<Veiculo> lista, ListBox listbox)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("veiculoSaida.dat",append: true); //sempre o arquivo é criado do zero
                                                                       //StreamWriter escritor = new StreamWriter(nomeArquivo, append:true); //possibilidade de adionar dados no arquivo
                foreach (var veiculo in lista)
                {
                    escritor.WriteLine(veiculo.Placa + ";" + veiculo.DataEntrada + ";" + veiculo.HoraEntrada.ToString("HH:mm") + ";" + veiculo.TempoPermanecia + ";" + veiculo.ValorCobrado);
                    /*listbox.Items.Add($"{veiculo.Placa}  -  " +
                                                   $"{veiculo.HoraSaida.ToString("HH:mm")}       -     " +
                                                   $"{veiculo.TempoPermanecia}min              -          " +
                                                   $"R${veiculo.ValorCobrado},00 ");
                    lista.Remove(veiculo);*/
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
