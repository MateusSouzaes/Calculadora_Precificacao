using Calculadora_Precificacao.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Calculadora_Precificacao.Modelos
{
    internal class EstadoDAO
    {
        public void Insert(Estado estado)
        {
            try
            {
                string sql = "INSERT INTO estado(nome, sigla) VALUES (@nome, @sigla)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", estado.nome);
                comando.Parameters.AddWithValue("@sigla", estado.sigla);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar o estado: " + ex.Message);
            }
        }

        public void Update(Estado estado)
        {
            try
            {
                string sql = "UPDATE estado SET nome = @nome, sigla = @sigla WHERE id_estado = @id_estado";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_estado", estado.id_estado);
                comando.Parameters.AddWithValue("@nome", estado.nome);
                comando.Parameters.AddWithValue("@sigla", estado.sigla);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o estado: " + ex.Message);
            }
        }

        public void Delete(int id_estado)
        {
            try
            {
                string sql = "DELETE FROM estado WHERE id_estado = @id_estado";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_estado", id_estado);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar o estado: " + ex.Message);
            }
        }

        public Estado BuscarID(int id_estado)
        {
            Estado e = new Estado();
            try
            {
                string sql = "SELECT * FROM estado WHERE id_estado = @id_estado";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_estado", id_estado);
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        e.id_estado = dr.GetInt32("id_estado");
                        e.nome = dr.GetString("nome");
                        e.sigla = dr.GetString("sigla");
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar o estado: " + ex.Message);
            }
            return e;
        }

        public List<Estado> List()
        {
            List<Estado> estados = new List<Estado>();
            try
            {
                string sql = "SELECT * FROM estado";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Estado e = new Estado();
                        e.id_estado = dr.GetInt32("id_estado");
                        e.nome = dr.GetString("nome");
                        e.sigla = dr.GetString("sigla");
                        estados.Add(e);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar os estados: " + ex.Message);
            }
            return estados;
        }
    }
}
