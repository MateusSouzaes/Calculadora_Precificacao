using Calculadora_Precificacao.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Calculadora_Precificacao.Modelos;

namespace Calculadora_Precificacao.DAO
{
    internal class FornecedorDAO
    {
        public void InsertFornecedor(Fornecedor fornecedor)
        {
            try
            {
                string sql = "INSERT INTO fornecedor(cnpj, nome_fantasia, suframa, credito, fk_estado_id_estado) " +
                             "VALUES (@cnpj, @nome_fantasia, @suframa, @credito, @fk_estado_id_estado)";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                comando.Parameters.AddWithValue("@nome_fantasia", fornecedor.nome_fantasia);
                comando.Parameters.AddWithValue("@suframa", fornecedor.suframa);
                comando.Parameters.AddWithValue("@credito", fornecedor.credito);
                comando.Parameters.AddWithValue("@fk_estado_id_estado", fornecedor.fk_estado_id_estaddo);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar o fornecedor: " + ex.Message);
            }
        }

        public void Update(Fornecedor fornecedor)
        {
            try
            {
                string sql = "UPDATE fornecedor SET cnpj = @cnpj, nome_fantasia = @nome_fantasia, " +
                             "suframa = @suframa, credito = @credito, fk_estado_id_estado = @fk_estado_id_estado " +
                             "WHERE id_fornecedor = @id_fornecedor";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_fornecedor", fornecedor.id_fornecedor);
                comando.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                comando.Parameters.AddWithValue("@nome_fantasia", fornecedor.nome_fantasia);
                comando.Parameters.AddWithValue("@suframa", fornecedor.suframa);
                comando.Parameters.AddWithValue("@credito", fornecedor.credito);
                comando.Parameters.AddWithValue("@fk_estado_id_estado", fornecedor.fk_estado_id_estaddo);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o fornecedor: " + ex.Message);
            }
        }

        public void Delete(int id_fornecedor)
        {
            try
            {
                string sql = "DELETE FROM fornecedor WHERE id_fornecedor = @id_fornecedor";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar o fornecedor: " + ex.Message);
            }
        }

        public Fornecedor BuscarID(int id_fornecedor)
        {
            Fornecedor f = new Fornecedor();
            try
            {
                string sql = "SELECT * FROM fornecedor WHERE id_fornecedor = @id_fornecedor";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);

                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        f.id_fornecedor = dr.GetInt32("id_fornecedor");
                        f.cnpj = dr.GetString("cnpj");
                        f.nome_fantasia = dr.GetString("nome_fantasia");
                        f.suframa = dr.GetBoolean("suframa");
                        f.credito = dr.GetBoolean("credito");
                        f.fk_estado_id_estaddo = dr.GetInt32("fk_estado_id_estado");
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar o fornecedor: " + ex.Message);
            }
            return f;
        }

        public List<Fornecedor> List()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            try
            {
                string sql = "SELECT * FROM fornecedor";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Fornecedor f = new Fornecedor();
                        f.id_fornecedor = dr.GetInt32("id_fornecedor");
                        f.cnpj = dr.GetString("cnpj");
                        f.nome_fantasia = dr.GetString("nome_fantasia");
                        f.suframa = dr.GetBoolean("suframa");
                        f.credito = dr.GetBoolean("credito");
                        f.fk_estado_id_estaddo = dr.GetInt32("fk_estado_id_estado");

                        fornecedores.Add(f);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar os fornecedores: " + ex.Message);
            }
            return fornecedores;
        }
        
    }
}
