using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Precificacao.Modelos
{
    public  class Tributacao_Estado
    {
        public int id_tributacao_estado { get; set; }
        public double icms_credito { get; set; }
        public double pis_credito { get; set; }
        public double cofins_credito { get; set; }

        public int fk_estado_id_estado { get; set; }
        public Estado estado { get; set; }

        public int fk_tipo_tributacao_id_tributacao { get; set; }
        public Tipo_Tributacao tipo_tributacao { get; set; }
    }
}