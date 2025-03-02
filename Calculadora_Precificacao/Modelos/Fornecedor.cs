using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Precificacao.Modelos
{
    public class Fornecedor
    {
        public int id_fornecedor {  get; set; }
        public string cnpj {  get; set; }
        public string nome_fantasia { get; set; }
        public bool suframa {  get; set; }
        public bool credito {  get; set; }
        public int fk_estado_id_estaddo {  get; set; }
        public Estado estado { get; set; }


    }
}
