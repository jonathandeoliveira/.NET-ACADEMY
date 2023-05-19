namespace Aula1905_WindowsForms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonGerarEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email Gerado");
            string[] vetorSobrenome = textBoxSobrenome.Text.Split(' ');
            string[] vetorNome = textBoxNome.Text.Split(' ');
            textBoxEmail.Text = vetorNome[0].ToLower() + "_" + vetorSobrenome[vetorSobrenome.Length - 1].ToLower() + "@ufn.edu.br";
            textBoxListaEmails.AppendText(textBoxEmail.Text + '\n');
            buttonLimpar.Enabled = true;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = string.Empty;
            textBoxSobrenome.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            //textBoxListaEmails.Text = string.Empty;
            buttonLimpar.Enabled = false;
        }
    }
}