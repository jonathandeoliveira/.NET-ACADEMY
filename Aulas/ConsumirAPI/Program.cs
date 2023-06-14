
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ConsumirAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int op;
            string BaseUrl = "http://localhost:5010";
            Console.WriteLine("Consumindo a API desenvolvida");
            do 
            {
                Console.WriteLine("Informa a opção desejada:");
                Console.WriteLine("1 - Consultar todas pessoas");
                Console.WriteLine("2 - Cadastrar pessoas");
                Console.WriteLine("3 - Alterar pessoas");
                Console.WriteLine("4 - Excluir pessoas");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:

                    break;


                    case 1:
                        List<Pessoa> pessoas = new List<Pessoa>(); // receber o que eu tenho armazenado no sistema
                        HttpClient client = new HttpClient(); //instanciando um objeto para fazer o acesso via http na API
                        client.BaseAddress = new Uri(BaseUrl); // definindo o endereço da API
                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                        HttpResponseMessage resposta = await client.GetAsync("Pessoa/pessoas");

                        if (resposta.IsSuccessStatusCode) // obtive sucesso na resposta, entra no if
                        {
                            var retorno = resposta.Content.ReadAsStringAsync().Result; // obtenho o retorno de uma consulta de API;
                            pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(retorno); // pega o retorno e desserializa e armazena em uma lista
                        } 
                        else
                        {
                            Console.WriteLine("Erro:" + resposta.StatusCode.ToString());
                        }
                        foreach(Pessoa p in pessoas)
                        {
                            Console.WriteLine($"ID: {p.id}\n Nome: {p.nome}");
                        }
                    break;

                    case 2:
                        Pessoa pessoa = new Pessoa();
                        Console.WriteLine("Digite o nome da pessoa:");
                        pessoa.nome = Console.ReadLine();
                        HttpClient cliente = new HttpClient();
                        HttpResponseMessage respostaPost = await cliente.PostAsJsonAsync(BaseUrl + "/Pessoa/pessoas", pessoa);
                    break;

                    case 3:
                        Console.WriteLine("Digite o ID da pessoa que quer alterar:");
                        int idAlterar = int.Parse(Console.ReadLine());
                        Pessoa pessoaAtualizada = new Pessoa(); 
                        Console.WriteLine("Digite o novo nome da pessoa que quer alterar:");
                        pessoaAtualizada.nome = Console.ReadLine();
                        string jsonPessoaAtualizada = JsonConvert.SerializeObject(pessoaAtualizada);

                        HttpClient clienteAlterar = new HttpClient(); //instanciando um objeto para fazer o acesso via http na API
                        clienteAlterar.BaseAddress = new Uri(BaseUrl + "/Pessoa/pessoas/" + idAlterar); // definindo o endereço da API
                        clienteAlterar.DefaultRequestHeaders.Clear();
                        clienteAlterar.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                        HttpContent conteudo = new StringContent(jsonPessoaAtualizada, Encoding.UTF8, "application/json");
                        HttpResponseMessage respostaAlterada = await clienteAlterar.PutAsync("", conteudo);

                        if (respostaAlterada.IsSuccessStatusCode)
                        {
                            Console.WriteLine("Pessoa atualizada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Falha ao atualizar pessoa. Status: " + respostaAlterada.StatusCode);
                        }
                    break;

                    case 4:
                        Console.WriteLine("Digite o ID da pessoa que deseja excluir:");
                        int idDeletar = int.Parse(Console.ReadLine());
                        HttpClient clienteExcluir = new HttpClient();
                        clienteExcluir.BaseAddress = new Uri(BaseUrl + "/Pessoa/pessoas/" + idDeletar);
                        HttpResponseMessage respostaDeletar = await clienteExcluir.DeleteAsync("");

                        if (respostaDeletar.IsSuccessStatusCode)
                        {
                            Console.WriteLine("Pessoa excluída com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Falha ao excluir pessoa. Status: " + respostaDeletar.StatusCode);
                        }

                    break;

                }

            } while (op != 0);

        }
    }
}