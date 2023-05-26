using System.Globalization;

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
                Veiculo veiculo = new Veiculo(textBoxPlaca.Text, labelDataRelogio.Text, labelDataRelogio.Text);
                veiculosGaragem.Add(veiculo);
                listBoxEntradaVeiculos.Items.Add($"{veiculo.Placa}: {veiculo.DataEntrada.ToString("dd/MM/yyyy")} - {veiculo.HoraEntrada.ToString("HH:mm")}");
                vagasOcupadas++;
                //Persistencia.gravarArquivoVeiculosEntrada(veiculosGaragem, listBoxEntradaVeiculos);
                MessageBox.Show("Veiculo adionado na garagem");
            }
            else
            {
                MessageBox.Show("Veiculo já existente na garagem");
            }
        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
            this.labelHoraRelogio.Text = DateTime.Now.ToString("HH:mm");
            this.labelDataRelogio.Text = DateTime.Now.ToString("d");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}