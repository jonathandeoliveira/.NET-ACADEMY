using CriptografiaSimetricaAndAssimetrica;

namespace ExercicioCriptografia30_05
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<User> usersFile = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            Simetrica s = new Simetrica();
            string senha = txbPassword.Text;
            string criptoSenha = s.EncryptData(senha, "backend>frontend");
            string usuario = txbUser.Text;
            User user = new User(usuario, criptoSenha);
            users.Add(user);
            Persistencia.gravarArquivo(users);
            MessageBox.Show("Cadastrado com Sucesso!"); 
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            Simetrica s = new Simetrica();
            Persistencia.lerArquivo(usersFile);
            string usuario = txbCheckUser.Text;
            string senha = txbCheckPassword.Text;
            string criptoSenha = s.DecryptData(senha, "backend>frontend");
           foreach (var user in users)
            {
                if (user.Password == criptoSenha && user.Login == usuario) 
                {
                    MessageBox.Show("Logado com sucesso");
                    break;
                }
                else
                {
                    MessageBox.Show("Login/Senha Incorretos ou não cadastrados na base de dados");

                }
            }
        }
    }
}