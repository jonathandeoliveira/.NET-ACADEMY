using AulaEntityFramework.DataModels;
using Microsoft.EntityFrameworkCore;

namespace AulaEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite: \n" +
                              "1 para criar uma pessoa\n" +
                              "2 para alterar o nome da pessoa\n" +
                              "3 para inserir um email\n" +
                              "4 para excluir uma pessoa\n" +
                              "5 para consultar tudo\n" +
                              "6 para consultar pelo ID");
            int op = int.Parse(Console.ReadLine());
            Contexto contexto = new Contexto();
            switch (op)
            {
                case 1:
                    try
                    {
                        //um modo de fazer
                         Console.WriteLine("Insira o nome da pessoa");
                        Pessoa pessoa = new Pessoa();
                        pessoa.nome = Console.ReadLine();
                      /*Console.WriteLine("Inisira um Email");
                        string emailTemp = Console.ReadLine();
                        pessoa.emails = new List<Email>();
                        {
                            new Email()
                            {
                                email = emailTemp
                            };
                        }*/

                        Email e = new Email();
                        Console.WriteLine("Insira um Email");
                        e.email = Console.ReadLine();
                        pessoa.emails = new List<Email>();
                        pessoa.emails.Add(e);;

                        contexto.Pessoas.Add(pessoa);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                break;

                case 2:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa:");
                        int idPessoa = int.Parse(Console.ReadLine());

                        Pessoa? pAlt = contexto.Pessoas.Find(idPessoa);

                        Console.WriteLine("Informe o nome correto:");
                        pAlt.nome = Console.ReadLine();

                        contexto.Pessoas.Update(pAlt);
                        contexto.SaveChanges();

                        Console.WriteLine("Nome alterado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                break;

                case 3:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa:");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa? p = contexto.Pessoas.Find(id);

                        Console.WriteLine("Informe o novo email:");

                        Email e = new Email();
                        e.email = Console.ReadLine();

                        p.emails.Add(e);

                        contexto.Pessoas.Update(p);
                        contexto.SaveChanges();

                        Console.WriteLine("Email inserido com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                break;

                case 4:
                    try
                    {
                        Console.WriteLine("Informe o ID para exclusão:");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.Pessoas.Find(id);

                        Console.WriteLine("Confirmar a exclusão de " + p.nome);
                        Console.WriteLine("E dos seus emails?");

                        foreach (Email item in p.emails)
                        {
                            Console.WriteLine("\t" + item.email);
                        }

                        Console.WriteLine("1 para SIM e 2 para NÃO");

                        if (int.Parse(Console.ReadLine()) == 1)
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                break;

                case 5:
                    try
                    {

                        List<Pessoa> pessoas = (from Pessoa p in contexto.Pessoas select p).Include(pes => pes.emails).ToList<Pessoa>();
                        foreach (Pessoa item in pessoas)
                        {
                            Console.WriteLine(item.nome);
                            foreach (Email itemE in item.emails)
                            {

                                Console.WriteLine("\t" + itemE.email);

                            }
                            Console.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                break;

                case 6:
                    try
                    {
                        Console.WriteLine("Informe o ID da Pessoa:");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa pessoa = contexto.Pessoas.Include(p => p.emails).FirstOrDefault(x => x.id == id);
                        Console.WriteLine($"{pessoa.id} - {pessoa.nome}");
                        foreach( Email item in pessoa.emails)
                        {
                            Console.WriteLine("\t" + item.email);
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                default:

                break;
            }
        }
    }
}