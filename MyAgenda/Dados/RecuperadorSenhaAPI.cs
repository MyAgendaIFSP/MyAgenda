using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Dados
{
    class RecuperadorSenhaAPI
    {
        private string STRING_CONEXAO = "Server=localhost;Database=my_agenda;Integrated Security=true";

        private SqlConnection _conexao = null;

        //Constante com instruções SQL de busca de emails

        public const string strSelectEmail = "SELECT email_usuario FROM usuario";

        //Constante com instruções SQL de busca de senha

        public const string strSelectSenha = "SELECT senha_usuario FROM usuario WHERE email_usuario = @email_usuario";

        private bool _abreConexao()
        {
            if (_conexao == null)
            {
                _conexao = new SqlConnection(STRING_CONEXAO);
            }

            try
            {
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

        public bool VerificarEmail(string emailDigitado)
        {
            if (_abreConexao())
            {
                SqlCommand objCommand = new SqlCommand(strSelectEmail, _conexao);

                try
                {

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
                    _fechaConexao();
                }
            }                
            return false;
        }

        public string GetSenha(string email)
        {
            string senha;

            if (_abreConexao())
            {
                SqlCommand objCommand = new SqlCommand(strSelectSenha, _conexao);

                try
                {

                    objCommand.Parameters.AddWithValue("@email_usuario", email);

                    senha = (string)objCommand.ExecuteScalar();

                    return senha;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex);
                }
                finally
                {
                    _fechaConexao();
                }
            }
            
            return null;
        }
    }
}
