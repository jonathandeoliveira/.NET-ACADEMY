using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWF_Estacionamento
{
    internal class Veiculo
    {
        public string Placa; //-> 7 caracteres -> verificar jaNaGaragem
        public DateTime DataEntrada;
        public string HoraEntrada;
        public DateTime DataSaida;
        public string HoraSaida;
        public double TempoPermanecia;
        public double ValorCobrado;

        public Veiculo(string placa)
        {
            Placa = placa;
        }

        public Veiculo(string placa, DateTime dataEntrada, string horaEntrada) : this(placa)
        {
            DataEntrada = dataEntrada;
            HoraEntrada = horaEntrada;
        }

        public static void gerarData() 
        {
        }

        public static void jaCadastrada(string placa)
        {
        }

        public static void temLugar(int vagaRestantes)
        {

        }

        public static void jaNaGaragem(string placa, ListBox listBox)
        {
        }

    }
}
