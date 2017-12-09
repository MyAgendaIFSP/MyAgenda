using MyAgenda.Modelos.Chat;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MyAgenda.Dados
{
    public class ChatAPI
    {

        private string STRING_CONEXAO = "Server=localhost;Database=my_agenda;Integrated Security=true";
        
        private SqlConnection _conexao = null;

        public enum EDirecao { ENVIADA, RECEBIDA, NENHUM }

        public enum EEstadoMensagem { ENTREGUE, NAO_ENTREGUE }
        
        public ChatAPI()
        {
            STRING_CONEXAO = @"Data Source=tcp:allexhome.ddns.net,1433;Initial Catalog=my_agenda;MultipleActiveResultSets=true;User ID=sa;Password=mYaGeNdA2017";
        }

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

        /// <summary>
        /// Recupera um conversa existente ou cria uma nova
        /// </summary>
        /// <param name="idUsuario">Usuário que inicio a conversa</param>
        /// <param name="idContato">Contato que receberá a conversa</param>
        /// <param name="conversaNova">Indica se a conversa é nova ou já existente</param>
        /// <returns></returns>
        public int AbreConversa(int idUsuario, int idContato, ref bool conversaNova)
        {
            if (_abreConexao())
            {
                SqlCommand cmd = new SqlCommand("select id from conversa where (usuario_criador = @usuario and usuario_dest = @contato) or (usuario_criador = @contato and usuario_dest = @usuario)", _conexao);
                cmd.Parameters.AddWithValue("@usuario", idUsuario);
                cmd.Parameters.AddWithValue("@contato", idContato);

                object retorno = cmd.ExecuteScalar();
                int id =  (retorno != null) ? (int)retorno : 0;

                if(id <= 0)
                {
                    id = _criaConversa(idUsuario, idContato);
                    conversaNova = true;
                }
                else
                {
                    conversaNova = false;
                }
                
                _fechaConexao();

                return id;
            }

            conversaNova = false;
            return 0;
        }

        /// <summary>
        /// Carrega as mensagens de uma conversa
        /// </summary>
        /// <param name="conversaId">conversa que as mensagens serão carregadas</param>
        /// <returns>lista contendo as mensagens</returns>
        public List<MensagemModelo> CarregaMensagens(int conversaId)
         {
            if (_abreConexao())
            {
                List<MensagemModelo> itens = new List<MensagemModelo>();

                SqlCommand cmd = new SqlCommand("select * from mensagem where mensagem.conversa = @conversa order by data;", _conexao);
                cmd.Parameters.AddWithValue("@conversa", conversaId);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        int destino = (int)rdr["destinatario"];
                        string texto = rdr["texto"].ToString();
                        DateTime data = DateTime.Parse(rdr["data"].ToString());
                        EEstadoMensagem estado = (EEstadoMensagem)((int)rdr["estado"]);

                        itens.Add(new MensagemModelo(texto, estado, data, destino));
                    }

                }

                _fechaConexao();

                return itens;
            }

            return null;
        }

        /// <summary>
        /// Registra uma mensagem no banco de dados
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="conversaId"></param>
        /// <returns></returns>
        public bool RegistraMensagem(MensagemModelo msg, int conversaId)
        {
            if (_abreConexao())
            {
                SqlCommand cmd = new SqlCommand("insert into mensagem values (@conversa, @destino, @msg, @estado, @data);", _conexao);
                cmd.Parameters.AddWithValue("@conversa", conversaId);
                cmd.Parameters.AddWithValue("@destino", msg.Destinatario);
                cmd.Parameters.AddWithValue("@msg", msg.Texto);
                cmd.Parameters.AddWithValue("@estado", (int) EEstadoMensagem.NAO_ENTREGUE);
                cmd.Parameters.AddWithValue("@data", msg.Data);

                int res = cmd.ExecuteNonQuery();

                _fechaConexao();

                return res > 0;
            }

            return false;
        }

        /// <summary>
        /// Busca a última mensagem da conversa
        /// </summary>
        /// <param name="conversaId">id da conversa para buscar a mensagem</param>
        /// <param name="usuarioId">id do usuario buscando</param>
        /// <returns></returns>
        public MensagemModelo MensagemNova(int conversaId, int usuarioId)
        {
            if (_abreConexao())
            {
                MensagemModelo msg = null;

                SqlCommand cmd = new SqlCommand("select * from mensagem where estado = @estado and destinatario = @destino;", _conexao);
                cmd.Parameters.AddWithValue("@estado", EEstadoMensagem.NAO_ENTREGUE);
                cmd.Parameters.AddWithValue("@destino", usuarioId);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (!rdr.HasRows)
                    {
                        _fechaConexao();
                        return null;
                    }

                    while (rdr.Read())
                    {
                        int destino = (int)rdr["destinatario"];
                        string texto = rdr["texto"].ToString();
                        DateTime data = DateTime.Parse(rdr["data"].ToString());
                        EEstadoMensagem estado = (EEstadoMensagem)((int)rdr["estado"]);

                        msg = new MensagemModelo(texto, estado, data, destino);
                    }

                }

                _fechaConexao();
                return msg;                
            }

            return null;
        }

        /// <summary>
        /// Busca uma mensagem recebida de qualquer conversa que o usuário esteja
        /// </summary>
        /// <param name="usuarioId">id do usuário</param>
        /// <returns></returns>
        public List<MensagemModelo> MensagemNova(int usuarioId)
        {
            if (_abreConexao())
            {
                List<MensagemModelo> msgs = new List<MensagemModelo>();

                SqlCommand cmd = new SqlCommand(@"select destinatario, texto, mensagem.estado, mensagem.[data], nome from mensagem, usuario, conversa
                                                    where destinatario = @usuario
                                                    and mensagem.estado = @estado
                                                    and mensagem.conversa = conversa.id
                                                    and usuario.id != mensagem.destinatario
                                                    and(usuario.id = conversa.usuario_criador
                                                    or usuario.id = conversa.usuario_dest)
                                                    order by mensagem.[data];", _conexao);
                cmd.Parameters.AddWithValue("@estado", EEstadoMensagem.NAO_ENTREGUE);
                cmd.Parameters.AddWithValue("@usuario", usuarioId);

                try
                {

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (!rdr.HasRows)
                        {
                            _fechaConexao();
                            return null;
                        }

                        while (rdr.Read())
                        {
                            int destino = (int)rdr["destinatario"];
                            string texto = rdr["texto"].ToString();
                            string autor = rdr["nome"].ToString();
                            DateTime data = DateTime.Parse(rdr["data"].ToString());
                            EEstadoMensagem estado = (EEstadoMensagem)((int)rdr["estado"]);

                            msgs.Add(new MensagemModelo(autor, texto, estado, data, destino));
                        }

                    }
                }
                catch
                {
                    _fechaConexao();
                    return null;
                }

                _fechaConexao();
                return msgs;
            }

            return null;
        }

        /// <summary>
        /// Marca uma mensagem como lida no banco de dados
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="conversaId"></param>
        /// <returns></returns>
        public bool AtualizaEstadoMensagem(MensagemModelo msg, int conversaId)
        {
            if (_abreConexao())
            {
                SqlCommand cmd = new SqlCommand("update mensagem set estado = @estado where conversa = @conversa and destinatario = @destino and texto like @msg and estado = 1;", _conexao);
                cmd.Parameters.AddWithValue("@estado", EEstadoMensagem.ENTREGUE);
                cmd.Parameters.AddWithValue("@conversa", conversaId);
                cmd.Parameters.AddWithValue("@destino", msg.Destinatario);
                cmd.Parameters.AddWithValue("@msg", msg.Texto);
                cmd.Parameters.AddWithValue("@data", msg.Data);

                int res = cmd.ExecuteNonQuery();

                _fechaConexao();
                return res > 0;
            }

            return false;
        }

        private int _criaConversa(int idUsuario, int idContato)
        {
            if (_abreConexao())
            {
                SqlCommand cmd = new SqlCommand("NovaConversa", _conexao);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", idUsuario);
                cmd.Parameters.AddWithValue("@contato", idContato);

                SqlParameter output = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                output.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                int id = (output.Value != null) ? (int)output.Value : 0;

                _fechaConexao();

                return id;
            }
            
            return 0;
        }
    }
}
