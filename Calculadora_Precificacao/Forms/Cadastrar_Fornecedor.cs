using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora_Precificacao.DAO;
using Calculadora_Precificacao.Modelos;

namespace Calculadora_Precificacao.Forms
{
    public partial class Cadastrar_Fornecedor : Form
    {
        
        List<Estado> estados = new List<Estado>();
        EstadoDAO est = new EstadoDAO();
        FornecedorDAO fornecedor_dao = new FornecedorDAO();
        public Cadastrar_Fornecedor()
        {
            InitializeComponent();
            estados = est.ListarEstado();

            foreach (Estado estado in estados)
            {
                comboBoxEstados.Items.Add(estado.nome);
            }

        }
        
        

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void bt_empresa_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.cnpj = tb_cnpj.Text;
            fornecedor.nome_fantasia = tb_Fantasia.Text;
            if(rbCredito_nao.Checked)
            {
                fornecedor.credito = false;
            }
            else
            {
                fornecedor.credito = true;
            }
            if (rbSuframado_nao.Checked)
            {
                fornecedor.suframa = false;
            }
            else
            {
                fornecedor.suframa = true;
            }
            
            fornecedor.estado = est.BuscarIDEstado(comboBoxEstados.SelectedIndex+1);
            fornecedor_dao.InsertFornecedor(fornecedor);
            

        }
    }
}
