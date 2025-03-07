using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora_Precificacao.DAO;

namespace Calculadora_Precificacao.Modelos
{
    public class Precificacao
    {
        public int id_precificacao { get; set; }
        public double custo_compra { get; set; }
        public double frete_compra { get; set; }
        public double icms_barreira_compra { get; set; }
        public double outros_compra { get; set; }
        public double frete_venda { get; set; }
        public double comissao_venda { get; set; }
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

        public double CalcularFormula()
        {
            Tributacao_Estado trib_entrada = new Tributacao_Estado();
            PrecificacaoDAO precificacaoDAO = new PrecificacaoDAO();

            trib_entrada = precificacaoDAO.Tributacao_Entrada(id_precificacao);

            double debitos_entrada, creditos_entrada, debitos_saida, impostos_saida;

            debitos_entrada = frete_compra + icms_barreira_compra + outros_compra;
            creditos_entrada = trib_entrada.cofins_credito + trib_entrada.pis_credito + trib_entrada.icms_credito;

            impostos_saida = tipo_tributacao.icms_interno + tipo_tributacao.pis_interno + tipo_tributacao.cofins_interno;
            debitos_saida = empresa.ir_social_venda + empresa.custo_empresa + frete_venda + comissao_venda + lucro_liquido;

            formula_venda = (100 + (debitos_entrada - creditos_entrada)) / (100 - (impostos_saida + debitos_saida));
            return formula_venda;
        }

    }

}
