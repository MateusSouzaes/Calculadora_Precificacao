using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Calculadora_Precificacao.Data
{
    static class Conexao
    {
        static MySqlConnection _conexao;
        static string strconexao = "server=localhost;uid=root;pwd=root;database=Calculadora_Precificacao";

        public static MySqlConnection Conectar()
        {
            try
            {
                _conexao = new MySqlConnection(strconexao);
                _conexao.Open();
                Console.WriteLine("Conectado com sucesso");
                return _conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar " + ex.Message);
            }

        }
    }
}
