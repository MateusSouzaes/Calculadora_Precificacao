using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Calculadora_Precificacao.Data;

namespace Calculadora_Precificacao.Modelos
{
    internal class Tributacao_EstadoDAO
    {
        // Método para inserir uma nova tributação por estado
        public void Insert(Tributacao_Estado tributacaoEstado)
        {
            try
            {
                string sql = "INSERT INTO tributacao_estado(icms_credito, pis_credito, cofins_credito, " +
                             "fk_estado_id_estado, fk_tipo_tributacao_id_tributacao) " +
                             "VALUES (@icms_credito, @pis_credito, @cofins_credito, @fk_estado_id_estado, @fk_tipo_tributacao_id_tributacao)";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@icms_credito", tributacaoEstado.icms_credito);
                comando.Parameters.AddWithValue("@pis_credito", tributacaoEstado.pis_credito);
                comando.Parameters.AddWithValue("@cofins_credito", tributacaoEstado.cofins_credito);
                comando.Parameters.AddWithValue("@fk_estado_id_estado", tributacaoEstado.fk_estado_id_estado);
                comando.Parameters.AddWithValue("@fk_tipo_tributacao_id_tributacao", tributacaoEstado.fk_tipo_tributacao_id_tributacao);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar a tributação por estado: " + ex.Message);
            }
        }

        // Método para atualizar uma tributação por estado existente
        public void Update(Tributacao_Estado tributacaoEstado)
        {
            try
            {
                string sql = "UPDATE tributacao_estado SET icms_credito = @icms_credito, pis_credito = @pis_credito, " +
                             "cofins_credito = @cofins_credito, fk_estado_id_estado = @fk_estado_id_estado, " +
                             "fk_tipo_tributacao_id_tributacao = @fk_tipo_tributacao_id_tributacao " +
                             "WHERE id_tributacao_estado = @id_tributacao_estado";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_tributacao_estado", tributacaoEstado.id_tributacao_estado);
                comando.Parameters.AddWithValue("@icms_credito", tributacaoEstado.icms_credito);
                comando.Parameters.AddWithValue("@pis_credito", tributacaoEstado.pis_credito);
                comando.Parameters.AddWithValue("@cofins_credito", tributacaoEstado.cofins_credito);
                comando.Parameters.AddWithValue("@fk_estado_id_estado", tributacaoEstado.fk_estado_id_estado);
                comando.Parameters.AddWithValue("@fk_tipo_tributacao_id_tributacao", tributacaoEstado.fk_tipo_tributacao_id_tributacao);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar a tributação por estado: " + ex.Message);
            }
        }

        // Método para deletar uma tributação por estado
        public void Delete(int id_tributacao_estado)
        {
            try
            {
                string sql = "DELETE FROM tributacao_estado WHERE id_tributacao_estado = @id_tributacao_estado";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_tributacao_estado", id_tributacao_estado);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar a tributação por estado: " + ex.Message);
            }
        }

        // Método para buscar uma tributação por estado pelo ID
        public Tributacao_Estado BuscarID(int id_tributacao_estado)
        {
            Tributacao_Estado tributacaoEstado = new Tributacao_Estado();
            try
            {
                string sql = "SELECT * FROM tributacao_estado WHERE id_tributacao_estado = @id_tributacao_estado";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_tributacao_estado", id_tributacao_estado);

                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        tributacaoEstado = new Tributacao_Estado
                        {
                            id_tributacao_estado = dr.GetInt32("id_tributacao_estado"),
                            icms_credito = dr.GetDouble("icms_credito"),
                            pis_credito = dr.GetDouble("pis_credito"),
                            cofins_credito = dr.GetDouble("cofins_credito"),
                            fk_estado_id_estado = dr.GetInt32("fk_estado_id_estado"),
                            fk_tipo_tributacao_id_tributacao = dr.GetInt32("fk_tipo_tributacao_id_tributacao")
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar a tributação por estado: " + ex.Message);
            }
            return tributacaoEstado;
        }

        // Método para listar todas as tributação por estado
        public List<Tributacao_Estado> List()
        {
            List<Tributacao_Estado> listaTributacaoEstado = new List<Tributacao_Estado>();
            try
            {
                string sql = "SELECT * FROM tributacao_estado";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Tributacao_Estado tributacaoEstado = new Tributacao_Estado
                        {
                            id_tributacao_estado = dr.GetInt32("id_tributacao_estado"),
                            icms_credito = dr.GetDouble("icms_credito"),
                            pis_credito = dr.GetDouble("pis_credito"),
                            cofins_credito = dr.GetDouble("cofins_credito"),
                            fk_estado_id_estado = dr.GetInt32("fk_estado_id_estado"),
                            fk_tipo_tributacao_id_tributacao = dr.GetInt32("fk_tipo_tributacao_id_tributacao")
                        };
                        listaTributacaoEstado.Add(tributacaoEstado);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar a tributação por estado: " + ex.Message);
            }
            return listaTributacaoEstado;
        }
    }
}
