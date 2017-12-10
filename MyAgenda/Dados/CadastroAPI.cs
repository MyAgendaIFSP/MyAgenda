using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgenda.Dados
{
    class CadastroAPI
    {
        private string STRING_CONEXAO = "Server=localhost;Database=my_agenda;Integrated Security=true";

        public const string strInsert = "INSERT INTO usuario VALUES (@email_usuario, @nome_usuario, @sobrenome_usuario, @senha_usuario, @nickname_usuario)";

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

        //Sessão de dados Usuário
        public void Gravar(string nome_usuario, string sobrenome_usuario, string nickname_usuario, string email_usuario, string senha_usuario)
        {
            using (SqlConnection objConexao = new SqlConnection(_conexao.ToString()))
            {
                using (SqlCommand objCommand = new SqlCommand(strInsert, objConexao))
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
    }
}
