using System.Text;

namespace DesafioWF_AlunosXYZ
{
    public partial class Form1 : Form
    {
        List<string[]> listaPessoa = new List<string[]>();
        List<Pessoa> pessoas = new List<Pessoa>();
        List<Aluno> alunos = new List<Aluno>();
        string nomeArquivo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNomeArquivo_Click(object sender, EventArgs e)
        {
            nomeArquivo = txtBoxNomeArquivo.Text;
            Persistencia.popularLista(nomeArquivo, listaPessoa);
            MessageBox.Show("Arquivo Encontrado!");
            Persistencia.popularListBox(listaPessoa, listBoxListaPessoas);

        }

        private void btnProcessarLista_Click(object sender, EventArgs e)
        {
            Persistencia.criarObjetos(listaPessoa, listBoxListaProcessada);

        }
    }
}

