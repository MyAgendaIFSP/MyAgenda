using System;
using System.Data;
using System.Data.SqlClient;

namespace MyAgenda.Dados
{
    class PomodoroAPI
    {
        private string STRING_CONEXAO = "Server=localhost;Database=my_agenda;Integrated Security=true";

        private SqlConnection _conexao = null;

        public const string strInsertPomodoro = "INSERT INTO pomodoro VALUES (@id_usuario, @tipo_sessao, @duracao_sessao, @data_sessao)";

        public PomodoroAPI()
        {
            STRING_CONEXAO = @"Data Source=tcp:allexhome.ddns.net,1433;Initial Catalog=my_agenda;MultipleActiveResultSets=true;User ID=sa;Password=mYaGeNdA2017";
        }

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

        public DataTable GetSessoesPomodoro(int usuario)
        {
            if (_abreConexao())
            {

                DataTable dt = new DataTable();
                dt.Columns.Add("Tipo da Sessão");
                dt.Columns.Add("Duração");

                SqlCommand cmd = new SqlCommand(@"select tipo_sessao = (SELECT CASE
                                                      WHEN tipo_sessao = 1 THEN 'Pomodoro'
                                                      WHEN tipo_sessao = 2 THEN 'Short Break'
                                                      WHEN tipo_sessao = 3 THEN 'Long Break'
                                                      ELSE CONVERT(VARCHAR, tipo_sessao)
                                                   END), duracao_sessao
	                                            FROM pomodoro
                                                WHERE id_usuario = @usuario", _conexao);

                cmd.Parameters.AddWithValue("@usuario", usuario);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if(rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            DataRow row = dt.NewRow();
                            
                            row[0] = rdr[0];
                            row[1] = rdr[1] + " minutos";

                            dt.Rows.Add(row);
                            row.AcceptChanges();

                        }
                    }
                }

                _fechaConexao();
                return dt;                
            }

            return null;
        }

        public DataTable GetRelatorio()
        {
            if (_abreConexao())
            {

                DataTable dt = new DataTable();
                dt.Columns.Add("Usuário");
                dt.Columns.Add("Tipo da Sessão");
                dt.Columns.Add("Duração");
                dt.Columns.Add("Data");

                SqlCommand cmd = new SqlCommand(@"select u.nome, tipo, p.duracao_sessao, p.data_sessao
                                                    from usuario as u
                                                    inner join 
                                                     (select case when tipo_sessao = 1 then 'Pomodoro'
			                                                    when tipo_sessao = 2 then 'Short Break' 
			                                                    when tipo_sessao = 3 then 'Long Break' 
			                                                    ELSE CONVERT(VARCHAR, tipo_sessao)
			                                                    end as tipo, data_sessao, duracao_sessao, id_usuario from pomodoro)
			                                                    as p
                                                    on u.id = p.id_usuario", _conexao);
                
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            DataRow row = dt.NewRow();

                            row[0] = rdr[0];
                            row[1] = rdr[1];
                            row[2] = rdr[2] + " minutos";
                            row[3] = rdr[3];

                            dt.Rows.Add(row);
                            row.AcceptChanges();

                        }
                    }
                }

                _fechaConexao();
                return dt;
            }

            return null;
        }
    }
}
