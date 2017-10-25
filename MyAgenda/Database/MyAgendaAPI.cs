﻿using MyAgenda.Controladores.MatrizTempo;
using MyAgenda.Modelos.Geral;
using MyAgenda.Modelos.MatrizTempo;
using MyAgenda.Seguranca;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MyAgenda.Database
{
    public class MyAgendaAPI
    {
        private readonly string STRING_CONEXAO = "Server=localhost;Database=my_agenda;Integrated Security=true";

        private static MyAgendaAPI _instancia = null;

        private SqlConnection _conexao = null;

        public static MyAgendaAPI GetInstance()
        {
            if(_instancia == null)
            {
                _instancia = new MyAgendaAPI();
            }

            return _instancia;
        }

        private MyAgendaAPI()
        {
            IpFixoSqnApi.Api server = new IpFixoSqnApi.Api();
            string maq = server.AuthUsuario("allex123", "123456");
            string ip = server.GetAddress(maq);
            
            STRING_CONEXAO = @"Data Source=tcp:" + ip + @";Initial Catalog=my_agenda;MultipleActiveResultSets=true;User ID=sa;Password=mYaGeNdA2017";
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
                if(_conexao.State == System.Data.ConnectionState.Open)
                {
                    return true;
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
        /// Obtém o modelo de um usuário
        /// </summary>
        /// <param name="email">email do usuário</param>
        /// <returns></returns>
        private UsuarioModel _getUsuario(string email)
        {
            if (_abreConexao())
            {
                int id = _getUserId(email);
                UsuarioModel usuario = null;
                MatrizController matriz;

                if (id < 0)
                {
                    return null;
                }

                SqlCommand cmd = new SqlCommand("GetModeloUsuario", _conexao);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user_id", id);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    try
                    {
                        while (rdr.Read())
                        {
                            int uid = (int)rdr["id"];
                            int matrizId = (int)rdr["matriz"];
                            string nome = rdr["nome"].ToString();
                            string d = rdr["matriz_inicializacao"].ToString();
                            DateTime dtNasc = DateTime.Parse(rdr["data_nascimento"].ToString());
                            DateTime matInit = DateTime.Parse(rdr["matriz_inicializacao"].ToString());
                            DateTime matUtili = DateTime.Parse(rdr["matriz_ulti_utilizacao"].ToString());

                            matriz = MatrizController.GetInstance(matrizId, matInit, matUtili);
                            usuario = new UsuarioModel(uid, nome, dtNasc, matriz);
                        }
                    }
                    catch { }
                }
                _fechaConexao();

                return usuario;
            }

            return null;
        }

        /// <summary>
        /// Obtém o id do usuário
        /// </summary>
        /// <param name="email">email do usuário</param>
        /// <returns></returns>
        private int _getUserId(string email)
        {
            SqlCommand cmd = new SqlCommand("SELECT id FROM usuario WHERE email LIKE @email;", _conexao);
            cmd.Parameters.AddWithValue("@email", email);

            int id = (int)cmd.ExecuteScalar();

            return id;
        }

        /// <summary>
        /// Obtém o salt da senha do usuário no banco de dados
        /// </summary>
        /// <param name="email">email do usuário</param>
        /// <returns></returns>
        private string _getSalt(string email)
        {
            if (_abreConexao())
            {

                SqlCommand cmd = new SqlCommand("SELECT salt FROM usuario WHERE email LIKE @email;", _conexao);
                cmd.Parameters.AddWithValue("@email", email);

                string salt = (string)cmd.ExecuteScalar();

                _fechaConexao();
                return salt;
            }

            return null;
        }

        /// <summary>
        /// Obtém a senha do usuário no banco de dados
        /// </summary>
        /// <param name="email">email do usuário</param>
        /// <returns></returns>
        private string _getSenha(string email)
        {
            if (_abreConexao())
            {

                SqlCommand cmd = new SqlCommand("SELECT senha FROM usuario WHERE email LIKE @email;", _conexao);
                cmd.Parameters.AddWithValue("@email", email);

                string senha = (string)cmd.ExecuteScalar();

                _fechaConexao();
                return senha;
            }

            return null;
        }

        /// <summary>
        /// Verifica se o email existe nos registros
        /// </summary>
        /// <param name="email">email a ser verificado</param>
        /// <returns></returns>
        public bool EmailExiste(string email)
        {
            if (_abreConexao())
            {

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM usuario WHERE email LIKE @email;", _conexao);
                cmd.Parameters.AddWithValue("@email", email);

                int qtd = (int)cmd.ExecuteScalar();

                _fechaConexao();

                return qtd > 0;
            }

            return false;
        }

        /// <summary>
        /// Autentica um usuário no sistema
        /// </summary>
        /// <param name="email">email do usuario</param>
        /// <param name="senha">senha do usuario</param>
        /// <returns>Modelo do usuário</returns>
        public UsuarioModel AutenticaUsuario(string email, string senha)
        {
            Criptografia cripto = new Criptografia();
            bool autorizado = cripto.VerificaSenha(_getSenha(email), senha, _getSalt(email));

            if (autorizado)
            {
                UsuarioModel u = _getUsuario(email);
                return u;
            }

            return null;
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
                    // iterate through results, printing each to console
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
                int matId = m.GetModel().Id;

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
                int matId = m.GetModel().Id;

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
                cmd.Parameters.AddWithValue("@estado", (ativo)? 1 : 0);

                int qtd = cmd.ExecuteNonQuery();

                _fechaConexao();

                return qtd > 0;
            }

            _fechaConexao();

            return false;
        }
    }
}
