using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Dados
{
    class AlteradorSenhaAPI
    {
        private string STRING_CONEXAO = "Server=localhost;Database=my_agenda;Integrated Security=true";

        private SqlConnection _conexao = null;

        public const string strUpdateSenha = "UPDATE usuario SET senha = @senha WHERE email = @email";
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

        public void AlterarSenha(string email, string senha)
        {
            if (_abreConexao())
            {
                SqlCommand objCommand = new SqlCommand(strUpdateSenha, _conexao);

                try
                {

                    objCommand.Parameters.AddWithValue("@senha", senha);
                    objCommand.Parameters.AddWithValue("@email", email);

                    objCommand.ExecuteNonQuery();

                    MessageBox.Show("Senha alterada com sucesso!");

                    _fechaConexao();

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
        }
    }
}
