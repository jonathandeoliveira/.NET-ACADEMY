namespace DesafioWF_Estacionamento
{
    public partial class Form1 : Form
    {
        List<Veiculo> veiculosGaragem = new List<Veiculo>();
        List<Veiculo> veiculosSaida = new List<Veiculo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo(textBoxPlaca.Text, DateTime.Now, DateTime.Now.Hour.ToString); ;
            veiculosGaragem.Add(veiculo);
            listBoxEntradaVeiculos.Items.Add($"{veiculo.Placa} - {veiculo.DataEntrada} - {veiculo.HoraEntrada}");
        }
    }
}