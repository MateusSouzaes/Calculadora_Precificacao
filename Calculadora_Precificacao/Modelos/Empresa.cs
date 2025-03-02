using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Precificacao.Modelos
{
    public class Empresa
    {
        public int id_empresa { get; set; }
        public string cnpj { get; set; }
        public double custo_empresa { get; set; }
        public double frete_saida { get; set; }
        public double ir_social_venda {  get; set; }

    }
}
