using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWF_Estacionamento
{
    internal class Veiculo
    {
        public DateOnly DataEntrada;
        public DateTime HoraEntrada;
        public DateOnly DataSaida;
        public DateTime HoraSaida;
        public double TempoPermanecia;
        public double ValorCobrado;
        public string Placa;
  
        public Veiculo(string placa)
        {
            Placa = placa;
            if (placa.Length == 7)
            {
                Placa = placa;
            }
            else
            {
                throw new ArgumentException("A placa deve ter " + 7 + " dígitos.");
            }
        }

        public Veiculo(string placa, string dataEntrada, string horaEntrada) : this(placa)
        {
            DateOnly converte = DateOnly.Parse(dataEntrada);
            DataEntrada = new DateOnly (converte.Year, converte.Month, converte.Day);
            HoraEntrada = DateTime.Parse(horaEntrada);

        }

        public static bool temLugar(int vagasTotais, int vagasOcupadas)
        {
            if (vagasTotais > vagasOcupadas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool jaNaGaragem(string placa, List<Veiculo> veiculosGaragem) // (string placa, ListBox veiculosGaragem) -- Segunda opção para verificar se ja esta na garagem
        {                                                                           // veiculosGaragem.Items.Contains(placa);
            foreach (var veiculo in veiculosGaragem)   
            {
                if (veiculo.Placa == placa)
                {
                    return true;
                }
            }
            return false;
        }

        public static void CobrarValor(Veiculo veiculo,ListBox listbox, List<Veiculo> listaSaida, List<Veiculo> listaEntrada)
        {
            DateTime entrada = veiculo.HoraEntrada;
            DateTime saida = veiculo.HoraSaida;
            TimeSpan permanencia =  saida - entrada;
            veiculo.TempoPermanecia = (int)Math.Ceiling(permanencia.TotalMinutes);
            int horas = (int)Math.Ceiling(permanencia.TotalMinutes / 60);
            int valor = (horas * 5);
            MessageBox.Show($"Tempo de permanencia:{horas} horas \n Valor cobrado:{valor}");
            veiculo.ValorCobrado = valor;
            listbox.Items.Add($"{veiculo.Placa}  -  " +
                                                  $"{veiculo.HoraSaida.ToString("HH:mm")}       -     " +
                                                  $"{veiculo.TempoPermanecia}min              -          " +
                                                  $"R${veiculo.ValorCobrado},00 ");
            
            listaEntrada.Remove(veiculo);
            listaSaida.Add(veiculo);
        }
    }
}
