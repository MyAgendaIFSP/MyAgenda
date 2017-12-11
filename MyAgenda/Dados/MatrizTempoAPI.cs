using MyAgenda.Componentes.MatrizTempo;
using MyAgenda.Controladores.Geral;
using MyAgenda.Controladores.MatrizTempo;
using MyAgenda.Modelos.MatrizTempo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgenda.Dados
{
    public class MatrizTempoAPI
    {
        private readonly string STRING_CONEXAO = "Server=localhost;Database=my_agenda;Integrated Security=true";

        private static MatrizTempoAPI _instancia = null;

        private SqlConnection _conexao = null;

        public static MatrizTempoAPI GetInstance()
        {
            if (_instancia == null)
            {
                _instancia = new MatrizTempoAPI();
            }

            return _instancia;
        }

        private MatrizTempoAPI()
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

        public MatrizController GetMatriz(int usuario)
        {
            if (_abreConexao())
            {
                MatrizController matriz = null;

                SqlCommand cmd = new SqlCommand(@"select matriz_tempo.id, ultima_utilizacao, inicializacao from matriz_tempo
                                                    inner join usuario on usuario.matriz_tempo = matriz_tempo.id
                                                    where usuario.id = @usuario;", _conexao);

                cmd.Parameters.AddWithValue("@usuario", usuario);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    try
                    {
                        while (rdr.Read())
                        {
                            int id = (int)rdr["id"];
                            DateTime matInit = rdr.GetDateTime(rdr.GetOrdinal("inicializacao"));
                            DateTime matUtili = rdr.GetDateTime(rdr.GetOrdinal("ultima_utilizacao")); 

                            matriz = MatrizController.GetInstance(id, matInit, matUtili);
                        }
                    }
                    catch { }
                }

                _fechaConexao();

                return matriz;
            }

            return null;
        }

        public void VerificaMatriz()
        {
            if (_abreConexao())
            {
                UsuarioController u = UsuarioController.GetInstance();
                SqlCommand cmd = new SqlCommand("select matriz_tempo from usuario where id = @usuario", _conexao);
                cmd.Parameters.AddWithValue("@usuario", u.GetModelo().Id);

                object res = cmd.ExecuteScalar();

                if(String.IsNullOrEmpty(res.ToString()))
                {
                    _criaMatriz(u.GetModelo().Id);
                }
                else
                {
                    u.GetModelo().MatrizTempo = _buscaMatriz(u.GetModelo().Id);
                }

                _fechaConexao();
            }
        }

        private MatrizController _buscaMatriz(int matId)
        {
            if (_abreConexao())
            {
                MatrizController mat = MatrizController.GetInstance();
                
                SqlCommand cmd = new SqlCommand("select * from matriz_tempo where id = @matriz", _conexao);
                cmd.Parameters.AddWithValue("@matriz", matId);
                
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    try
                    {
                        while (rdr.Read())
                        {
                            int id = (int)rdr["id"];
                            DateTime dtUltUtil = DateTime.Parse(rdr["ultima_utilizacao"].ToString());
                            DateTime dtInit = DateTime.Parse(rdr["inicializacao"].ToString());

                            mat.SetMatriz(id, dtInit, dtUltUtil);
                        }
                    } catch { }
                }

                _fechaConexao();
                return mat;
            }

            return null;
        }

        private bool _criaMatriz(int usuario)
        {
            if (_abreConexao())
            {
                SqlCommand cmd = new SqlCommand("NovaMatrizTempo", _conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);

                SqlParameter output = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                output.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                int res = (output.Value != null) ? (int)output.Value : 0;

                if(res > 0)
                {
                    UsuarioController u = UsuarioController.GetInstance();
                    u.GetModelo().MatrizTempo = MatrizController.GetInstance(res, DateTime.Now, DateTime.Now);
                }

                _fechaConexao();

                return res > 0;
            }

            return false;
        }

        /// <summary>
        /// Carrega os itens da matriz do tempo especificada
        /// </summary>
        /// <param name="matrizId">id da matriz</param>
        /// <returns></returns>
        public List<ItemMatrizController> CarregaItensMatriz(int matrizId)
        {
            if (_abreConexao())
            {
                List<ItemMatrizController> itens = new List<ItemMatrizController>();

                SqlCommand cmd = new SqlCommand("GetItensMatriz", _conexao);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@matriz_id", matrizId);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        int id = (int)rdr["id"];
                        Componentes.MatrizTempo.Matriz.EQuadrante quadrante = (Componentes.MatrizTempo.Matriz.EQuadrante)((int)rdr["quadrante"] - 1);
                        string titulo = rdr["titulo"].ToString();
                        string descricao = rdr["descricao"].ToString();
                        bool ativo = (bool)rdr["ativo"];
                        DateTime dtAdd = DateTime.Parse(rdr["data_adicao"].ToString());

                        itens.Add(new ItemMatrizController(new ItemMatrizModel(id, titulo, descricao, quadrante, ativo, dtAdd)));
                    }

                }

                _fechaConexao();

                return itens;
            }

            return null;
        }

        /// <summary>
        /// Atualiza a data do último acesso da matriz do tempo
        /// </summary>
        /// <param name="idMatriz">id da matriz</param>
        /// <returns></returns>
        public bool AtualizaUltimoAcessoMatriz(int idMatriz)
        {
            if (_abreConexao())
            {

                SqlCommand cmd = new SqlCommand("UPDATE matriz_tempo SET ultima_utilizacao = @data WHERE matriz_tempo.id = @id;", _conexao);
                cmd.Parameters.AddWithValue("@id", idMatriz);
                cmd.Parameters.AddWithValue("@data", DateTime.Now);

                int qtd = cmd.ExecuteNonQuery();

                _fechaConexao();

                return qtd > 0;
            }

            return false;
        }

        /// <summary>
        /// Adiciona um item novo à matriz do tempo
        /// </summary>
        /// <param name="item">modelo do item que será adicionado</param>
        /// <returns></returns>
        public bool AdicionaItemMatriz(ItemMatrizModel item)
        {
            if (_abreConexao())
            {
                MatrizController m = MatrizController.GetInstance();
                int matId = m.GetModelo().Id;

                SqlCommand cmd = new SqlCommand("NovoItemMatriz", _conexao);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@quadrante", ((int)item.Quadrante) + 1);
                cmd.Parameters.AddWithValue("@titulo", item.Titulo);
                cmd.Parameters.AddWithValue("@mat_id", matId);
                cmd.Parameters.AddWithValue("@descricao", item.Descricao);

                SqlParameter output = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                output.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                int ultId = (int)output.Value;
                item.Id = ultId;

                _fechaConexao();

                return ultId > 0;
            }

            return false;
        }

        /// <summary>
        /// Remove permanentemente um item da matriz do tempo
        /// </summary>
        /// <param name="itemId">id do item que será removido</param>
        /// <returns></returns>
        public bool RemoveItemMatriz(int itemId)
        {

            if (_abreConexao())
            {
                MatrizController m = MatrizController.GetInstance();
                int matId = m.GetModelo().Id;

                SqlCommand cmd = new SqlCommand("DELETE FROM item_matriz WHERE id = @item", _conexao);
                cmd.Parameters.AddWithValue("@item", itemId);

                int qtd = cmd.ExecuteNonQuery();

                _fechaConexao();

                return qtd > 0;
            }

            _fechaConexao();

            return false;
        }

        /// <summary>
        /// Marca um item da matriz do tempo como inativo
        /// </summary>
        /// <param name="itemId">id do item</param>
        /// <returns></returns>
        public bool MarcarItemMatrizInativo(int itemId)
        {
            return _alteraEstadoItem(itemId, false);
        }

        /// <summary>
        /// Marca um item da matriz do tempo como ativo
        /// </summary>
        /// <param name="itemId">id do item</param>
        /// <returns></returns>
        public bool MarcarItemMatrizAtivo(int itemId)
        {
            return _alteraEstadoItem(itemId, true);
        }

        /// <summary>
        /// Altera o estado de um item no banco de dados (ativo/inativo)
        /// </summary>
        /// <param name="itemId">id do item</param>
        /// <param name="ativo">estado (ativo=true,inativo=fase)</param>
        /// <returns></returns>
        private bool _alteraEstadoItem(int itemId, bool ativo)
        {
            if (_abreConexao())
            {
                SqlCommand cmd = new SqlCommand("UPDATE item_matriz SET ativo = @estado WHERE id = @item;", _conexao);
                cmd.Parameters.AddWithValue("@item", itemId);
                cmd.Parameters.AddWithValue("@estado", (ativo) ? 1 : 0);

                int qtd = cmd.ExecuteNonQuery();

                _fechaConexao();

                return qtd > 0;
            }

            _fechaConexao();

            return false;
        }

        /// <summary>
        /// Move um item do quadrante atual para um outro quadrante
        /// </summary>
        /// <param name="itemId">item que será movido</param>
        /// <param name="quadrante">novo quadrante do item</param>
        /// <returns></returns>
        public bool MoverItem(int itemId, Matriz.EQuadrante quadrante)
        {
            if (_abreConexao())
            {
                SqlCommand cmd = new SqlCommand("UPDATE item_matriz SET quadrante = @quadrante WHERE id = @item;", _conexao);
                cmd.Parameters.AddWithValue("@item", itemId);
                cmd.Parameters.AddWithValue("@quadrante", ((int)quadrante) + 1);

                int qtd = cmd.ExecuteNonQuery();

                _fechaConexao();

                return qtd > 0;
            }

            _fechaConexao();

            return false;
        }
    }
}
