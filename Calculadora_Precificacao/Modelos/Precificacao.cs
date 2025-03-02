using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Precificacao.Modelos
{
    public class Precificacao
    {
        public int id_precificacao { get; set; }
        public double custo_compra { get; set; }
        public double? frete_compra { get; set; }
        public double? icms_barreira_compra { get; set; }
        public double? outros_compra { get; set; }
        public double? frete_venda { get; set; }
        public double? comissao_venda { get; set; }
        public double lucro_liquido { get; set; }
        public double preco_venda_final { get; set; }
        public double formula_venda { get; set; }
        public string descricao { get; set; }

        public int fk_empresa_id_empresa { get; set; }
        public Empresa empresa { get; set; }

        public int fk_tipo_tributacao_id_tributacao { get; set; }
        public Tipo_Tributacao tipo_tributacao { get; set; }

        public int fk_fornecedor_id_fornecedor { get; set; }
        public Fornecedor fornecedor { get; set; }
    }
}
