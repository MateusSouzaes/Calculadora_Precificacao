using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Precificacao.Modelos
{
    public class Tipo_Tributacao
    {
        public int id_tributacao {  get; set; }
        public string descricao { get; set; }
        public double icms_interno { get; set; }
        public double pis_interno { get; set; }
        public double cofins_interno { get; set; }



    }
}
