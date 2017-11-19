﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MyAgenda.Entidades;

namespace MyAgenda.Dados
{
    class TarefaAPI
    {
        const string C_CONEXAO = @"Data Source=DESKTOP-J789RM6; Initial Catalog=my_agenda; User ID=DESKTOP-J789RM6\leticiapc; Trusted_Connection=True";

        public List<Tarefa> CarregaTarefas(string listaAfazeres)
        {
            List<Tarefa> tarefas = new List<Tarefa>();

            string query = "SELECT * FROM TAREFA WHERE LISTA = @LISTA";

            SqlConnection conn = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("LISTA", listaAfazeres));

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Tarefa tarefa = new Tarefa();
                    tarefa.Lista = new ListaAfazeres();
                    tarefa.Titulo = reader["titulo"].ToString();
                    tarefa.Descricao = reader["descricao"].ToString();
                    tarefa.Data = Convert.ToDateTime(reader["mdata"].ToString());
                    tarefa.Usuario = new Usuario();
                    tarefas.Add(tarefa);
                }
            }
            catch (Exception e) {
                Console.Write(e);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return tarefas;
        }

        public void AdicionaTarefa(Tarefa tarefa)
        {
            string query = "INSERT INTO TAREFA (LISTA, USUARIO, TITULO, MDATA, DESCRICAO) VALUES (@LISTA, @USUARIO, @TITULO, @MDATA, @DESCRICAO)";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("LISTA", tarefa.Lista.Titulo));
                cmd.Parameters.Add(new SqlParameter("USUARIO", 1));
                cmd.Parameters.Add(new SqlParameter("TITULO", tarefa.Titulo));
                cmd.Parameters.Add(new SqlParameter("MDATA", tarefa.Data));
                cmd.Parameters.Add(new SqlParameter("DESCRICAO", tarefa.Descricao));

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void EditarTarefa(Tarefa tarefa)
        {
            string query = "UPDATE EVENTO SET LISTA = @LISTA, USUARIO = @USUARIO, TITULO = @TITULO, MDATA = @MDATA, DESCRICAO = @DESCRICAO WHERE TITULO = @TITULO";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("LISTA", 1));
                cmd.Parameters.Add(new SqlParameter("USUARIO", 1));
                cmd.Parameters.Add(new SqlParameter("TITULO", tarefa.Titulo));
                cmd.Parameters.Add(new SqlParameter("MDATA", tarefa.Data));
                cmd.Parameters.Add(new SqlParameter("DESCRICAO", tarefa.Descricao));
                cmd.Parameters.Add(new SqlParameter("TITULO", tarefa.Titulo));

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void ExcluirTarefa(Tarefa tarefa)
        {
            string query = "DELETE FROM TAREFA WHERE TITULO = @TITULO";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("TITULO", tarefa.Titulo));

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
