using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using Newtonsoft.Json;
namespace Aula29_05_Serializacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serializa = textBox1.Text;
            FileStream fs = new FileStream(@"E:\Visual Studio\Repos\jonathandeoliveira\.NET-ACADEMY\Aulas\Aula29-05 Serializacao\Teste.data", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, serializa);
            fs.Close();
            MessageBox.Show("Serializado com Sucesso!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"E:\Visual Studio\Repos\jonathandeoliveira\.NET-ACADEMY\Aulas\Aula29-05 Serializacao\Teste.data", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string msgDessentrializada;
            msgDessentrializada = (string)bf.Deserialize(fs);
            fs.Close();
            MessageBox.Show("Mensagem Desserializada com Sucesso!");
            label1.Text = msgDessentrializada;

        }

        private void btnSrlzXML_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = textBoxNome.Text;
            pessoa.idade = int.Parse(textBoxIdade.Text);
            pessoa.salario = double.Parse(textBoxSalario.Text);

            FileStream fs = new FileStream(@"E:\Visual Studio\Repos\jonathandeoliveira\.NET-ACADEMY\Aulas\Aula29-05 Serializacao\TestePessoa.xml", FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            xml.Serialize(fs, pessoa);

            MessageBox.Show("Serializado em XML");
            fs.Close();
        }

        private void btnDslrXML_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"E:\Visual Studio\Repos\jonathandeoliveira\.NET-ACADEMY\Aulas\Aula29-05 Serializacao\TestePessoa.xml", FileMode.Open);
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            Pessoa pessoa = (Pessoa)xml.Deserialize(fs);
            labelNomeDeserialize.Text = pessoa.nome;
            labelIdadeDeserialize.Text = pessoa.idade.ToString();
            labelSalarioDeserialize.Text = pessoa.salario.ToString();
            MessageBox.Show("Desserializado em XML");
            fs.Close();

        }

        private void btnSerializeJSON_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = textBoxNome.Text;
            pessoa.idade = int.Parse(textBoxIdade.Text);
            pessoa.salario = double.Parse(textBoxSalario.Text);
            JsonSerializer serializer = new JsonSerializer();
            StreamWriter sw = new StreamWriter(@"E:\Visual Studio\Repos\jonathandeoliveira\.NET-ACADEMY\Aulas\Aula29-05 Serializacao\TestePessoaJSON.json");
            JsonWriter jsonWriter = new JsonTextWriter(sw);
            serializer.Serialize(jsonWriter, pessoa);
            sw.Close();
            jsonWriter.Close();
            MessageBox.Show("Serializado em JSON");


        }

        private void btnDesserializaJSON_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"E:\Visual Studio\Repos\jonathandeoliveira\.NET-ACADEMY\Aulas\Aula29-05 Serializacao\TestePessoaJSON.json");
            Pessoa pessoa = JsonConvert.DeserializeObject<Pessoa>(json);
            labelNomeDeserialize.Text = pessoa.nome;
            labelIdadeDeserialize.Text = pessoa.idade.ToString();
            labelSalarioDeserialize.Text = pessoa.salario.ToString();
        }

        private void btnSerializeSOAP_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = textBoxNome.Text;
            pessoa.idade = int.Parse(textBoxIdade.Text);
            pessoa.salario = double.Parse(textBoxSalario.Text);

            FileStream stream = new FileStream(@"E:\Visual Studio\Repos\jonathandeoliveira\.NET-ACADEMY\Aulas\Aula29-05 Serializacao\TestePessoaSOAP.data", FileMode.OpenOrCreate);
            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(stream, pessoa);
            stream.Close();
            MessageBox.Show("Serializado em SOAP");
        }

        private void btnDeserializeSOAP_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(@"E:\Visual Studio\Repos\jonathandeoliveira\.NET-ACADEMY\Aulas\Aula29-05 Serializacao\TestePessoaSOAP.data", FileMode.Open);
            SoapFormatter soap = new SoapFormatter();
            Pessoa pessoa = new Pessoa();
            pessoa = (Pessoa)soap.Deserialize(stream);
           
            labelNomeDeserialize.Text = pessoa.nome;
            labelIdadeDeserialize.Text = pessoa.idade.ToString();
            labelSalarioDeserialize.Text = pessoa.salario.ToString();
            MessageBox.Show("Desserializado em SOAP");
            stream.Close();
        }
    }
}