using System.Globalization;
using System.Windows.Forms;

namespace DesafioWF_Estacionamento
{
    public partial class Form1 : Form
    {
        List<Veiculo> veiculosGaragem = new List<Veiculo>();
        List<Veiculo> veiculosSaida = new List<Veiculo>();
        int vagasTotais = 50;
        int vagasOcupadas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (Veiculo.temLugar(vagasTotais, vagasOcupadas) && !(Veiculo.jaNaGaragem(textBoxPlaca.Text, veiculosGaragem)))
            {
                Veiculo veiculo = new Veiculo(textBoxPlaca.Text, labelDataRelogio.Text, labelHoraRelogio.Text);
                veiculosGaragem.Add(veiculo);
                vagasOcupadas++;
                Persistencia.gravarArquivoVeiculosEntrada(veiculosGaragem, listBoxEntradaVeiculos);
                listBoxEntradaVeiculos.Items.Add(veiculo.Placa + " - " + veiculo.DataEntrada + " - " + veiculo.HoraEntrada.ToString("HH:mm"));
                MessageBox.Show("Veiculo adicionado na garagem");
            }
            else if (!Veiculo.temLugar(vagasTotais, vagasOcupadas))
            {
                MessageBox.Show("Garagem Lotada");
            }
            else
            {
                MessageBox.Show("Veiculo já existente na garagem");
            }

        }


        private void btnSaida_Click(object sender, EventArgs e)
        {
            string placa = textBoxPlaca.Text;
            foreach (var veiculo in veiculosGaragem)
            {
                if (veiculo.Placa == placa)
                {
                    DateOnly converte = DateOnly.Parse(labelDataRelogio.Text);
                    veiculo.DataSaida = new DateOnly(converte.Year, converte.Month, converte.Day);
                    veiculo.HoraSaida = DateTime.Parse(labelHoraRelogio.Text);
                    Veiculo.CobrarValor(veiculo);
                    Persistencia.gravarArquivoVeiculosSaida(veiculosSaida, listBoxSaidaVeiculos);
                    listBoxSaidaVeiculos.Items.Add($"{veiculo.Placa}  -  " +
                                                   $"{veiculo.HoraSaida.ToString("HH:mm")}       -     " +
                                                   $"{veiculo.TempoPermanecia}min              -          " +
                                                   $"R${veiculo.ValorCobrado},00 ");
                }
                else
                {
                    MessageBox.Show("Veiculo não encontrado na garagem");
                }
            }


        }

        private void timer1_Tick(object sender, EventArgs e) // Função para o relógio e a data
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
            this.labelHoraRelogio.Text = DateTime.Now.ToString("HH:mm:ss");
            this.labelDataRelogio.Text = DateTime.Now.ToString("d");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}