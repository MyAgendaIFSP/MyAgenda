using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ifalj.Controladores
{
    public class DataConnection
    {
        //Variável que recebe a String de conexão
        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        //public string strConexao = "Data Source=localhost;Initial Catalog=BD_IFALJ;Integrated Security=True";
        //public string strConexao = "Integrated Security=true;Persist Security Info=False;Initial Catalog=BD_IFALJ;Data Source=LAB-PC";

        //Constantes com instruções SQL para o CRUD de Cadastro
        public const string strDelete = "DELETE FROM usuario WHERE id_usuario = @id_usuario";
        public const string strInsert = "INSERT INTO usuario VALUES (@email_usuario, @nome_usuario, @sobrenome_usuario, @senha_usuario, @nickname_usuario)";
        public const string strSelect = "SELECT * FROM usuario";
        public const string strUpdate = "UPDATE usuario SET nome_usuario = @nome_usuario, sobrenome_usuario = @sobrenome_usuario, nickname_usuario = @nickname_usuario, email_usuario = @email_usuario, senha_usuario = @senha_usuario WHERE id_usuario = @id_usuario";

        //Constantes com instruções SQL para o CRUD de Pomodoro

        public const string strInsertPomodoro = "INSERT INTO pomodoro VALUES (@id_usuario, @tipo_sessao, @duracao_sessao, @data_sessao)";

        //Constante com instruções SQL de busca de emails

        public const string strSelectEmail = "SELECT email_usuario FROM usuario";

        //Constante com instruções SQL de busca de senha

        public const string strSelectSenha = "SELECT senha_usuario FROM usuario WHERE email_usuario = @email_usuario";

        //Sessão de dados Usuário
        public void Gravar(string nome_usuario, string sobrenome_usuario, string nickname_usuario, string email_usuario, string senha_usuario)
        {
            using(SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using(SqlCommand objCommand = new SqlCommand(strInsert, objConexao))
                {
                    objCommand.Parameters.AddWithValue("@email_usuario", email_usuario);
                    objCommand.Parameters.AddWithValue("@nome_usuario", nome_usuario);
                    objCommand.Parameters.AddWithValue("@sobrenome_usuario", sobrenome_usuario);
                    objCommand.Parameters.AddWithValue("@senha_usuario", senha_usuario);
                    objCommand.Parameters.AddWithValue("@nickname_usuario", nickname_usuario);
                    
                    objConexao.Open();

                    objCommand.ExecuteNonQuery();

                    objConexao.Close();
                }
            }
        }

        /*
        public void Atualizar(int idUsuario, string nome, string sobreNome)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strUpdate, objConexao))
                {
                    objCommand.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    objCommand.Parameters.AddWithValue("@Nome", nome);
                    objCommand.Parameters.AddWithValue("@SobreNome", sobreNome);

                    objConexao.Open();

                    objCommand.ExecuteNonQuery();

                    objConexao.Close();
                }
            }
        }

        public void Excluir(int idUsuario)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strDelete, objConexao))
                {
                    objCommand.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    objConexao.Open();

                    objCommand.ExecuteNonQuery();

                    objConexao.Close();
                }
            }
        }
        */

        //Sessão de dados Pomodoro

        public void GravarPomodoro(int id_usuario, int tipo_sessao, int duracao_sessao, DateTime data_sessao)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strInsertPomodoro, objConexao))
                {
                    objCommand.Parameters.AddWithValue("@id_usuario", id_usuario);
                    objCommand.Parameters.AddWithValue("@tipo_sessao", tipo_sessao);
                    objCommand.Parameters.AddWithValue("@duracao_sessao", duracao_sessao);
                    objCommand.Parameters.AddWithValue("@data_sessao", data_sessao);

                    objConexao.Open();

                    objCommand.ExecuteNonQuery();

                    objConexao.Close();
                }
            }
        }

        public bool VerificarEmail(string emailDigitado)
        {
            
                using (SqlConnection objConexao = new SqlConnection(strConexao))
                {
                    using (SqlCommand objCommand = new SqlCommand(strSelectEmail, objConexao))
                    {
                        try
                        {
                            objConexao.Open();

                            SqlDataReader reader = objCommand.ExecuteReader();

                            while (reader.Read())
                            {
                                if (reader["email_usuario"].ToString() == emailDigitado)
                                {
                                    return true;
                                }
                            }

                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro: " + ex);
                        }
                        finally
                        {
                            objConexao.Close();
                        }
                    }
                }
            return false;
        }

        public string GetSenha(string email)
        {
            string senha;

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strSelectSenha, objConexao))
                {

                    try
                    {
                        
                        objConexao.Open();

                        objCommand.Parameters.AddWithValue("@email_usuario", email);

                       // SqlDataReader reader = objCommand.ExecuteReader();

                        //senha = reader.ToString();

                        senha = (string)objCommand.ExecuteScalar();

                        return senha;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex);
                    }
                    finally
                    {
                        objConexao.Close();
                    }
                }
            }
            return null;
        }
    }
}
