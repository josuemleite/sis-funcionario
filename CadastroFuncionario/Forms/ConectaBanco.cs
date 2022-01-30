using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CadastroFuncionario.Forms
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=funcad");

        public string mensagem;

        public DataTable listaFuncionarios()
        {
            MySqlCommand cmd = new MySqlCommand("lista_funcionarios", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException ex)
            {
                mensagem = "Erro: " + ex.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool insereFuncionario(Funcionario f)
        {
            MySqlCommand cmd = new MySqlCommand("insere_funcionario", conexao);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("cargo", f.Cargo);
            cmd.Parameters.AddWithValue("dataAdmissao", f.DataAdmissao);
            cmd.Parameters.AddWithValue("nome", f.Nome);
            cmd.Parameters.AddWithValue("dataNascimento", f.DataNascimento);
            cmd.Parameters.AddWithValue("nacionalidade", f.Nacionalidade);
            cmd.Parameters.AddWithValue("naturalidade", f.Naturalidade);
            cmd.Parameters.AddWithValue("numCTPS", f.NumCTPS);
            cmd.Parameters.AddWithValue("remuneracao", f.Remuneracao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException ex)
            {
                mensagem = "Erro: " + ex.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool deletaFuncionario(int codFuncionario)
        {
            MySqlCommand cmd = new MySqlCommand("deleta_funcionario", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codFuncionario", codFuncionario);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                mensagem = "Erro: " + ex.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
