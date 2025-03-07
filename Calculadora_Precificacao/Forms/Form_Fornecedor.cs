using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Precificacao.Forms
{
    public partial class Form_Fornecedor : Form
    {
        public Form_Fornecedor()
        {
            InitializeComponent();
        }

        private void bt_empresa_Click(object sender, EventArgs e)
        {
            Cadastrar_Fornecedor cadastrar = new Cadastrar_Fornecedor();
            cadastrar.ShowDialog();
        }
    }
}
