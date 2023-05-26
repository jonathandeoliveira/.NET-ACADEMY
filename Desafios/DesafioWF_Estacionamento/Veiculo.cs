using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWF_Estacionamento
{
    internal class Veiculo
    {
        public string Placa; //-> 7 caracteres
        public DateOnly DataEntrada;
        public DateTime HoraEntrada;
        public DateTime DataSaida;
        public DateTime HoraSaida;
        public double TempoPermanecia;
        public double ValorCobrado;

        public Veiculo(string placa)
        {
            Placa = placa;
        }

        public Veiculo(string placa, string dataEntrada, string horaEntrada) : this(placa)
        {
            DataEntrada = DateOnly.Parse(dataEntrada);
            HoraEntrada = DateTime.Parse(horaEntrada);
        }

        public static void gerarDataHora(TextBox data, TextBox horario) 
        {
            var cultureInfo = new CultureInfo("pt-BR");
 
        }

        public static void jaCadastrada(string placa, ListBox garagem)
        {
            garagem.Items.Contains(placa);
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

        public static bool jaNaGaragem(string placa, List<Veiculo> veiculosGaragem) // (string placa, ListBox veiculosGaragem)
        {
            foreach (var veiculo in veiculosGaragem)   // veiculosGaragem.Items.Contains(placa);
            {
                if (veiculo.Placa == placa)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
