using Criptografia;
using CriptografiaSimetricaAndAssimetrica;
using System.Text;

namespace Aula30_05_Criptografia
{
    public partial class Form1 : Form
    {
        private Assimetrica a = new Assimetrica();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            Simetrica s = new Simetrica();
            string msg = txbMensagem.Text;
            string msgCripto = s.EncryptData(msg, "atos");
            lblMensagemCriptografada.Text = msgCripto;


        }

        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            Simetrica s = new Simetrica();
            string msg = lblMensagemCriptografada.Text;
            string msgDescripto = s.DecryptData(msg, "atos");
            lblMensagemDescriptografada.Text = msgDescripto;
        }

        private void btnDescriptografarArquivo_Click(object sender, EventArgs e)
        {
            Simetrica s = new Simetrica();
            StreamReader leitor = new StreamReader("dadoscripto.txt", Encoding.UTF8);
            string mensagem = leitor.ReadToEnd();
            leitor.Close();
            txbMsgArquivo.Text = mensagem;
            string mensagemDecripto = s.DecryptData(mensagem, "atos20232");
            txbMsgDecripto.Text = mensagemDecripto;
        }

        private void btnCriptoAssimetrica_Click(object sender, EventArgs e)
        {
            //Assimetrica a = new Assimetrica();
            //MessageBox.Show(a.getPublicKey());
            string msg, msgCripto;
            msg = txbMsgAssimetrica.Text;
            msgCripto = a.encrypt(msg);
            txbMsgCriptoAssimetrica.Text = msgCripto;
        }

        private void btnDescriptoAssimetrica_Click(object sender, EventArgs e)
        {
            //Assimetrica a = new Assimetrica();
            string msg, msgDescripto;
            msg = txbMsgCriptoAssimetrica.Text;
            string pbkey = a.getPublicKey();
            msgDescripto = a.decrypt(msg);

            txbMsgDescriptoAssimetrica.Text = msgDescripto;
        }

    }
}