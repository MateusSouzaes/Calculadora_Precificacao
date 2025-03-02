using Calculadora_Precificacao.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Calculadora_Precificacao.Modelos
{
    internal class PrecificacaoDAO
    {
        public void Insert(Precificacao precificacao)
        {
            try
            {
                string sql = "INSERT INTO precificacao (custo_compra, frete_compra, icms_barreira_compra, outros_compra, frete_venda, comissao_venda, lucro_liquido, preco_venda_final, formula_venda, descricao, fk_empresa_id_empresa, fk_tipo_tributacao_id_tributacao, fk_fornecedor_id_fornecedor) " +
                             "VALUES (@custo_compra, @frete_compra, @icms_barreira_compra, @outros_compra, @frete_venda, @comissao_venda, @lucro_liquido, @preco_venda_final, @formula_venda, @descricao, @fk_empresa_id_empresa, @fk_tipo_tributacao_id_tributacao, @fk_fornecedor_id_fornecedor)";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@custo_compra", precificacao.custo_compra);
                comando.Parameters.AddWithValue("@frete_compra", precificacao.frete_compra);
                comando.Parameters.AddWithValue("@icms_barreira_compra", precificacao.icms_barreira_compra);
                comando.Parameters.AddWithValue("@outros_compra", precificacao.outros_compra);
                comando.Parameters.AddWithValue("@frete_venda", precificacao.frete_venda);
                comando.Parameters.AddWithValue("@comissao_venda", precificacao.comissao_venda);
                comando.Parameters.AddWithValue("@lucro_liquido", precificacao.lucro_liquido);
                comando.Parameters.AddWithValue("@preco_venda_final", precificacao.preco_venda_final);
                comando.Parameters.AddWithValue("@formula_venda", precificacao.formula_venda);
                comando.Parameters.AddWithValue("@descricao", precificacao.descricao);
                comando.Parameters.AddWithValue("@fk_empresa_id_empresa", precificacao.fk_empresa_id_empresa);
                comando.Parameters.AddWithValue("@fk_tipo_tributacao_id_tributacao", precificacao.fk_tipo_tributacao_id_tributacao);
                comando.Parameters.AddWithValue("@fk_fornecedor_id_fornecedor", precificacao.fk_fornecedor_id_fornecedor);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar a precificação: " + ex.Message);
            }
        }

        public void Update(Precificacao precificacao)
        {
            try
            {
                string sql = "UPDATE precificacao SET custo_compra = @custo_compra, frete_compra = @frete_compra, icms_barreira_compra = @icms_barreira_compra, outros_compra = @outros_compra, frete_venda = @frete_venda, comissao_venda = @comissao_venda, lucro_liquido = @lucro_liquido, preco_venda_final = @preco_venda_final, formula_venda = @formula_venda, descricao = @descricao, fk_empresa_id_empresa = @fk_empresa_id_empresa, fk_tipo_tributacao_id_tributacao = @fk_tipo_tributacao_id_tributacao, fk_fornecedor_id_fornecedor = @fk_fornecedor_id_fornecedor WHERE id_precificacao = @id_precificacao";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_precificacao", precificacao.id_precificacao);
                comando.Parameters.AddWithValue("@custo_compra", precificacao.custo_compra);
                comando.Parameters.AddWithValue("@frete_compra", precificacao.frete_compra);
                comando.Parameters.AddWithValue("@icms_barreira_compra", precificacao.icms_barreira_compra);
                comando.Parameters.AddWithValue("@outros_compra", precificacao.outros_compra);
                comando.Parameters.AddWithValue("@frete_venda", precificacao.frete_venda);
                comando.Parameters.AddWithValue("@comissao_venda", precificacao.comissao_venda);
                comando.Parameters.AddWithValue("@lucro_liquido", precificacao.lucro_liquido);
                comando.Parameters.AddWithValue("@preco_venda_final", precificacao.preco_venda_final);
                comando.Parameters.AddWithValue("@formula_venda", precificacao.formula_venda);
                comando.Parameters.AddWithValue("@descricao", precificacao.descricao);
                comando.Parameters.AddWithValue("@fk_empresa_id_empresa", precificacao.fk_empresa_id_empresa);
                comando.Parameters.AddWithValue("@fk_tipo_tributacao_id_tributacao", precificacao.fk_tipo_tributacao_id_tributacao);
                comando.Parameters.AddWithValue("@fk_fornecedor_id_fornecedor", precificacao.fk_fornecedor_id_fornecedor);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar a precificação: " + ex.Message);
            }
        }

        public void Delete(int id_precificacao)
        {
            try
            {
                string sql = "DELETE FROM precificacao WHERE id_precificacao = @id_precificacao";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_precificacao", id_precificacao);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar a precificação: " + ex.Message);
            }
        }
        public Precificacao BuscarID(int id_precificacao)
        {
            Precificacao p = null;
            try
            {
                string sql = "SELECT * FROM precificacao WHERE id_precificacao = @id_precificacao";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_precificacao", id_precificacao);
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        p = new Precificacao
                        {
                            id_precificacao = dr.GetInt32("id_precificacao"),
                            custo_compra = dr.GetDouble("custo_compra"),
                            frete_compra = dr.GetDouble("frete_compra"),
                            icms_barreira_compra = dr.GetDouble("icms_barreira_compra"),
                            outros_compra = dr.GetDouble("outros_compra"),
                            frete_venda = dr.GetDouble("frete_venda"),
                            comissao_venda = dr.GetDouble("comissao_venda"),
                            lucro_liquido = dr.GetDouble("lucro_liquido"),
                            preco_venda_final = dr.GetDouble("preco_venda_final"),
                            formula_venda = dr.GetDouble("formula_venda"),
                            descricao = dr.GetString("descricao")
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar a precificação: " + ex.Message);
            }
            return p;
        }
        public List<Precificacao> List()
        {
            List<Precificacao> lista = new List<Precificacao>();
            try
            {
                string sql = "SELECT * FROM precificacao";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Precificacao p = new Precificacao
                        {
                            id_precificacao = dr.GetInt32("id_precificacao"),
                            custo_compra = dr.GetDouble("custo_compra"),
                            frete_compra = dr.GetDouble("frete_compra"),
                            icms_barreira_compra = dr.GetDouble("icms_barreira_compra"),
                            outros_compra = dr.GetDouble("outros_compra"),
                            frete_venda = dr.GetDouble("frete_venda"),
                            comissao_venda = dr.GetDouble("comissao_venda"),
                            lucro_liquido = dr.GetDouble("lucro_liquido"),
                            preco_venda_final = dr.GetDouble("preco_venda_final"),
                            formula_venda = dr.GetDouble("Formula_venda"),
                            descricao = dr.GetString("Descricao")
                        };
                        lista.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar as precificações: " + ex.Message);
            }
            return lista;
        }

        public Tributacao_Estado Tributacao_Entrada(int id_precificacao)
        {
            Tributacao_Estado tributacaoEstado = new Tributacao_Estado();
            try
            {
                string sql = "SELECT te.* from precificacao as p" +
                "ON Tributacao_Estado as te ON p.fk_tipo_tributacao_id_tributacao = te.fk_tipo_tributacao_id_tributacao " +
                "WHERE P.id_precificacao = @id_precificacao";
                
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_precificacao", id_precificacao);

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
                throw new Exception("Erro ao buscar a tributacao " + ex.Message);
            }
            return tributacaoEstado;
        }
    }   
}
