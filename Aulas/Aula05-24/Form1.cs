namespace Aula05_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button btn = new Button();
            btn.Name = "btnDinamico";
            btn.Text = "Clique";
            btn.Click += button2_Click;

            panel1.Controls.Add(btn);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botão dinâmico clicado");
        }
    }
}