namespace Calculadora_Precificacao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_empresa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_fornecedor = new System.Windows.Forms.Button();
            this.bt_tributacoes = new System.Windows.Forms.Button();
            this.bt_calculadora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_empresa
            // 
            this.bt_empresa.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_empresa.Location = new System.Drawing.Point(12, 97);
            this.bt_empresa.Name = "bt_empresa";
            this.bt_empresa.Size = new System.Drawing.Size(320, 68);
            this.bt_empresa.TabIndex = 0;
            this.bt_empresa.Text = "Empresa";
            this.bt_empresa.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 21);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(343, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Precificador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_fornecedor
            // 
            this.bt_fornecedor.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fornecedor.Location = new System.Drawing.Point(12, 171);
            this.bt_fornecedor.Name = "bt_fornecedor";
            this.bt_fornecedor.Size = new System.Drawing.Size(320, 68);
            this.bt_fornecedor.TabIndex = 2;
            this.bt_fornecedor.Text = "Fornecedor";
            this.bt_fornecedor.UseVisualStyleBackColor = false;
            // 
            // bt_tributacoes
            // 
            this.bt_tributacoes.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_tributacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tributacoes.Location = new System.Drawing.Point(12, 245);
            this.bt_tributacoes.Name = "bt_tributacoes";
            this.bt_tributacoes.Size = new System.Drawing.Size(320, 68);
            this.bt_tributacoes.TabIndex = 3;
            this.bt_tributacoes.Text = "Tributacoes";
            this.bt_tributacoes.UseVisualStyleBackColor = false;
            // 
            // bt_calculadora
            // 
            this.bt_calculadora.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_calculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calculadora.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_calculadora.Location = new System.Drawing.Point(12, 457);
            this.bt_calculadora.Name = "bt_calculadora";
            this.bt_calculadora.Size = new System.Drawing.Size(320, 68);
            this.bt_calculadora.TabIndex = 6;
            this.bt_calculadora.Text = "Calculadora de Precos";
            this.bt_calculadora.UseVisualStyleBackColor = false;
            this.bt_calculadora.Click += new System.EventHandler(this.bt_calculadora_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.bt_calculadora);
            this.Controls.Add(this.bt_tributacoes);
            this.Controls.Add(this.bt_fornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_empresa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_empresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_fornecedor;
        private System.Windows.Forms.Button bt_tributacoes;
        private System.Windows.Forms.Button bt_calculadora;
    }
}

