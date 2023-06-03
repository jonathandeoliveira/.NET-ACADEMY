using System.Data;

namespace Aula31_05_Adonet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            Pessoa pessoa = new Pessoa();
            DataTable dt = new DataTable();
            dt = pessoa.consultaNomes(txbNome.Text);
            dataGridView1.DataSource = dt;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            string sql = "select * from pessoas where nome = '" + txbQueryNome.Text + "'";
            DataTable dt = new DataTable();
            dt = bd.executarConsultaGenerica(sql);
            dataGridView1.DataSource = dt;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = txbNome.Text;
            pessoa.profissao = txbProfissao.Text;
            if (pessoa.gravar())
            {
                MessageBox.Show("Cadastrado com sucesso!!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = txbNomeExcluir.Text;
            pessoa.profissao = txbProfissaoExcluir.Text;
            pessoa.id = int.Parse(txbIdExcluir.Text);
            if (pessoa.excluir())
            {
                MessageBox.Show("Excluido com sucesso !!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir!!");
            }
        }

        private void btnAtualiar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = txbNomeAtualizar.Text;
            pessoa.profissao = txbProfissaoAtualizar.Text;
            pessoa.id = int.Parse(txbIdAtualizar.Text);
            if (pessoa.atualizar())
            {
                MessageBox.Show("Atualizado com sucesso !!");

            }
            else
            {
                MessageBox.Show("Erro ao atualizar!!");
            }

        }

        private void btnDataReader_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p = p.consultaPessoa(int.Parse(txbDataReader.Text));
            lblNomeDataReader.Text = p.nome;
        }
    }
}