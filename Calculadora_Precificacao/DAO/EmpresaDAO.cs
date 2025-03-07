using Calculadora_Precificacao.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Calculadora_Precificacao.Modelos;

namespace Calculadora_Precificacao.DAO
{
    public class EmpresaDAO
    {
        public void Insert(Empresa empresa)
        {
            try
            {
                string sql = "INSERT INTO empresa(cnpj, custo_empresa, frete_saida, ir_social_venda) " +
                             "VALUES (@cnpj, @custo_empresa, @frete_saida, @ir_social_venda)";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@cnpj", empresa.cnpj);
                comando.Parameters.AddWithValue("@custo_empresa", empresa.custo_empresa);
                comando.Parameters.AddWithValue("@frete_saida", empresa.frete_saida);
                comando.Parameters.AddWithValue("@ir_social_venda", empresa.ir_social_venda);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar a empresa: " + ex.Message);
            }
        }

        public void Update(Empresa empresa)
        {
            try
            {
                string sql = "UPDATE empresa SET cnpj = @cnpj, custo_empresa = @custo_empresa, " +
                             "frete_saida = @frete_saida, ir_social_venda = @ir_social_venda " +
                             "WHERE id_empresa = @id_empresa";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_empresa", empresa.id_empresa);
                comando.Parameters.AddWithValue("@cnpj", empresa.cnpj);
                comando.Parameters.AddWithValue("@custo_empresa", empresa.custo_empresa);
                comando.Parameters.AddWithValue("@frete_saida", empresa.frete_saida);
                comando.Parameters.AddWithValue("@ir_social_venda", empresa.ir_social_venda);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar a empresa: " + ex.Message);
            }
        }

        public void Delete(int id_empresa)
        {
            try
            {
                string sql = "DELETE FROM empresa WHERE id_empresa = @id_empresa";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_empresa", id_empresa);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar a empresa: " + ex.Message);
            }
        }

        public Empresa BuscarID(int id_empresa)
        {
            Empresa e = new Empresa();
            try
            {
                string sql = "SELECT * FROM empresa WHERE id_empresa = @id_empresa";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_empresa", id_empresa);

                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        e.id_empresa = dr.GetInt32("id_empresa");
                        e.cnpj = dr.GetString("cnpj");
                        e.custo_empresa = dr.GetDouble("custo_empresa");

                        //valores podem ser nulos
                        e.frete_saida = dr.GetDouble("frete_saida");
                        e.ir_social_venda =dr.GetDouble("ir_social_venda");
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar a empresa: " + ex.Message);
            }
            return e;
        }

        public List<Empresa> List()
        {
            List<Empresa> empresa = new List<Empresa>();
            try
            {
                string sql = "SELECT * FROM empresa";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                using(MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Empresa e = new Empresa();
                        e.id_empresa = dr.GetInt32("id_empresa");
                        e.cnpj = dr.GetString("cnpj");
                        e.custo_empresa = dr.GetDouble("custo_empresa");
                        //adicionando pq eu não nomeei o commit
                        //valores podem ser nulos
                        e.frete_saida = dr.GetDouble("frete_saida");
                        e.ir_social_venda = dr.GetDouble("ir_social_venda");
                        empresa.Add(e);
                    }
                }

                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar as empresas: " + ex.Message);
            }
            return empresa;
        }
    }
}
