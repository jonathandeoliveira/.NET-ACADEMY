using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula31_05_Adonet
{
    internal class Pessoa
    {
        public int id;
        public string nome;
        public string profissao;

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction trans = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = trans;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "insert into pessoas " +
                                   "values(@nome, @profissao); ";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@profissao", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = profissao;
            try
            {
                command.ExecuteNonQuery();
                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool excluir()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction trans = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = trans;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from pessoas where id = @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = id;
            try
            {
                command.ExecuteNonQuery();
                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool atualizar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction trans = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = trans;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "update pessoas set nome = @nome, profissao = @profissao where id = @id";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@profissao", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = profissao;
            command.Parameters[2].Value = id;

            try
            {
                command.ExecuteNonQuery();
                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public Pessoa consultaPessoa(int id)
        {
            Banco bd = new Banco();
            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("select * from pessoas", cn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        this.id = reader.GetInt32(0);
                        this.nome = reader.GetString(1);
                        this.profissao = reader.GetString(2);
                        return this;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public DataTable consultaNomes(string nome)
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from pessoas where nome like '%' + @nome + '%' ";

            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = nome;
            try
            {
                command.ExecuteNonQuery(); // executa o comando
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();  // Tabela em memória
                adapter.Fill(dt); // preenche a tabela
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
    }
 }
