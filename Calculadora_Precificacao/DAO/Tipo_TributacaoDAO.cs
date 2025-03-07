using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Calculadora_Precificacao.Data;
using Calculadora_Precificacao.Modelos;

namespace Calculadora_Precificacao.DAO
{
    internal class Tipo_TributacaoDAO
    {
        
        public void Insert(Tipo_Tributacao tipoTributacao)
        {
            try
            {
                string sql = "INSERT INTO tipo_tributacao(descricao, icms_interno, pis_interno, cofins_interno) " +
                             "VALUES (@descricao, @icms_interno, @pis_interno, @cofins_interno)";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@descricao", tipoTributacao.descricao);
                comando.Parameters.AddWithValue("@icms_interno", tipoTributacao.icms_interno);
                comando.Parameters.AddWithValue("@pis_interno", tipoTributacao.pis_interno);
                comando.Parameters.AddWithValue("@cofins_interno", tipoTributacao.cofins_interno);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar o tipo de tributação: " + ex.Message);
            }
        }

        public void Update(Tipo_Tributacao tipoTributacao)
        {
            try
            {
                string sql = "UPDATE tipo_tributacao SET descricao = @descricao, icms_interno = @icms_interno, " +
                             "pis_interno = @pis_interno, cofins_interno = @cofins_interno " +
                             "WHERE id_tributacao = @id_tributacao";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_tributacao", tipoTributacao.id_tributacao);
                comando.Parameters.AddWithValue("@descricao", tipoTributacao.descricao);
                comando.Parameters.AddWithValue("@icms_interno", tipoTributacao.icms_interno);
                comando.Parameters.AddWithValue("@pis_interno", tipoTributacao.pis_interno);
                comando.Parameters.AddWithValue("@cofins_interno", tipoTributacao.cofins_interno);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o tipo de tributação: " + ex.Message);
            }
        }


        public void Delete(int id_tributacao)
        {
            try
            {
                string sql = "DELETE FROM tipo_tributacao WHERE id_tributacao = @id_tributacao";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_tributacao", id_tributacao);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar o tipo de tributação: " + ex.Message);
            }
        }

        public Tipo_Tributacao BuscarID(int id_tributacao)
        {
            Tipo_Tributacao tipo = null;
            try
            {
                string sql = "SELECT * FROM tipo_tributacao WHERE id_tributacao = @id_tributacao";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_tributacao", id_tributacao);

                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        tipo = new Tipo_Tributacao
                        {
                            id_tributacao = dr.GetInt32("id_tributacao"),
                            descricao = dr.GetString("descricao"),
                            icms_interno = dr.GetDouble("icms_interno"),
                            pis_interno = dr.GetDouble("pis_interno"),
                            cofins_interno = dr.GetDouble("cofins_interno")
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar o tipo de tributação: " + ex.Message);
            }
            return tipo;
        }

        public List<Tipo_Tributacao> List()
        {
            List<Tipo_Tributacao> listaTipoTributacao = new List<Tipo_Tributacao>();
            try
            {
                string sql = "SELECT * FROM tipo_tributacao";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Tipo_Tributacao tipo = new Tipo_Tributacao
                        {
                            id_tributacao = dr.GetInt32("id_tributacao"),
                            descricao = dr.GetString("descricao"),
                            icms_interno = dr.GetDouble("icms_interno"),
                            pis_interno = dr.GetDouble("pis_interno"),
                            cofins_interno = dr.GetDouble("cofins_interno")
                        };
                        listaTipoTributacao.Add(tipo);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar os tipos de tributação: " + ex.Message);
            }
            return listaTipoTributacao;
        }
    }
}
