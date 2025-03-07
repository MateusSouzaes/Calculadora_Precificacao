using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora_Precificacao.Forms;
namespace Calculadora_Precificacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_calculadora_Click(object sender, EventArgs e)
        {

        }

        private void bt_fornecedor_Click(object sender, EventArgs e)
        {
            Form_Fornecedor form_fornecedor = new Form_Fornecedor();
            form_fornecedor.ShowDialog();
        }
    }
}
