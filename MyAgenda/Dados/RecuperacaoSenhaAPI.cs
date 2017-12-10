using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Dados
{
    class RecuperacaoSenhaAPI
    {
        private string STRING_CONEXAO = "Server=localhost;Database=my_agenda;Integrated Security=true";

        private SqlConnection _conexao = null;

        /// <summary>
        /// Abre a conexão com o banco de dados
        /// </summary>
        /// <returns></returns>
        private bool _abreConexao()
        {
            if (_conexao == null)
            {
                _conexao = new SqlConnection(STRING_CONEXAO);
            }

            try
            {
                //throw new NotImplementedException();
                _conexao.Open();
                return true;
            }
            catch
            {

                if (_conexao.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    try
                    {
                        _conexao = new SqlConnection("Server=localhost;Database=my_agenda;MultipleActiveResultSets=true;Integrated Security=true");
                        _conexao.Open();
                        return true;
                    }
                    catch { }
                }

                return false;
            }
        }

        /// <summary>
        /// Fecha a conexão com o banco de dados
        /// </summary>
        /// <returns></returns>
        private bool _fechaConexao()
        {
            try
            {
                _conexao.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        //Constante com instruções SQL de busca de emails

        public const string strSelectEmail = "SELECT email_usuario FROM usuario";

        //Constante com instruções SQL de busca de senha

        public const string strSelectSenha = "SELECT senha_usuario FROM usuario WHERE email_usuario = @email_usuario";

        public bool VerificarEmail(string emailDigitado)
        {

            using (SqlConnection objConexao = new SqlConnection(_conexao.ToString()))
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

            using (SqlConnection objConexao = new SqlConnection(_conexao.ToString()))
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
