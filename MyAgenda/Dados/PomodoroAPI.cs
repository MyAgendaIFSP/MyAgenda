using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgenda.Dados
{
    class PomodoroAPI
    {
        private string STRING_CONEXAO = "Server=localhost;Database=my_agenda;Integrated Security=true";

        private SqlConnection _conexao = null;

        public const string strInsertPomodoro = "INSERT INTO pomodoro VALUES (@id_usuario, @tipo_sessao, @duracao_sessao, @data_sessao)";
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

        //Sessão de dados Pomodoro

        public void GravarPomodoro(int id_usuario, int tipo_sessao, int duracao_sessao, DateTime data_sessao)
        {
            if (_abreConexao())
            {
                SqlCommand objCommand = new SqlCommand(strInsertPomodoro, _conexao);

                objCommand.Parameters.AddWithValue("@id_usuario", id_usuario);
                objCommand.Parameters.AddWithValue("@tipo_sessao", tipo_sessao);
                objCommand.Parameters.AddWithValue("@duracao_sessao", duracao_sessao);
                objCommand.Parameters.AddWithValue("@data_sessao", data_sessao);

                objCommand.ExecuteNonQuery();

                _fechaConexao();
            }
            
        }
    }
}
