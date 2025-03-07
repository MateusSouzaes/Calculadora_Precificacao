namespace Calculadora_Precificacao.Forms
{
    partial class Cadastrar_Fornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bt_empresa = new System.Windows.Forms.Button();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Fantasia = new System.Windows.Forms.TextBox();
            this.rbSuframado_nao = new System.Windows.Forms.RadioButton();
            this.rbCredito_nao = new System.Windows.Forms.RadioButton();
            this.rbCredito_sim = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEstados = new System.Windows.Forms.ComboBox();
            this.rbSuframado_sim = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(487, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cadastrar Fornecedor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_empresa
            // 
            this.bt_empresa.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_empresa.Location = new System.Drawing.Point(267, 380);
            this.bt_empresa.Name = "bt_empresa";
            this.bt_empresa.Size = new System.Drawing.Size(140, 54);
            this.bt_empresa.TabIndex = 10;
            this.bt_empresa.Text = "Salvar";
            this.bt_empresa.UseVisualStyleBackColor = false;
            this.bt_empresa.Click += new System.EventHandler(this.bt_empresa_Click);
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cnpj.Location = new System.Drawing.Point(187, 86);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(200, 40);
            this.tb_cnpj.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 89);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(81, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "CNPJ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 136);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(229, 34);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nome Fantasia";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 182);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(179, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "É Suframado?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 228);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(187, 34);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gera Crédito ?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_Fantasia
            // 
            this.tb_Fantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Fantasia.Location = new System.Drawing.Point(187, 130);
            this.tb_Fantasia.Name = "tb_Fantasia";
            this.tb_Fantasia.Size = new System.Drawing.Size(200, 40);
            this.tb_Fantasia.TabIndex = 17;
            // 
            // rbSuframado_nao
            // 
            this.rbSuframado_nao.AutoSize = true;
            this.rbSuframado_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuframado_nao.Location = new System.Drawing.Point(120, 7);
            this.rbSuframado_nao.Name = "rbSuframado_nao";
            this.rbSuframado_nao.Size = new System.Drawing.Size(76, 33);
            this.rbSuframado_nao.TabIndex = 19;
            this.rbSuframado_nao.TabStop = true;
            this.rbSuframado_nao.Text = "Não";
            this.rbSuframado_nao.UseVisualStyleBackColor = true;
            // 
            // rbCredito_nao
            // 
            this.rbCredito_nao.AutoSize = true;
            this.rbCredito_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCredito_nao.Location = new System.Drawing.Point(120, 3);
            this.rbCredito_nao.Name = "rbCredito_nao";
            this.rbCredito_nao.Size = new System.Drawing.Size(76, 33);
            this.rbCredito_nao.TabIndex = 21;
            this.rbCredito_nao.TabStop = true;
            this.rbCredito_nao.Text = "Não";
            this.rbCredito_nao.UseVisualStyleBackColor = true;
            // 
            // rbCredito_sim
            // 
            this.rbCredito_sim.AutoSize = true;
            this.rbCredito_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCredito_sim.Location = new System.Drawing.Point(15, 2);
            this.rbCredito_sim.Name = "rbCredito_sim";
            this.rbCredito_sim.Size = new System.Drawing.Size(73, 33);
            this.rbCredito_sim.TabIndex = 20;
            this.rbCredito_sim.TabStop = true;
            this.rbCredito_sim.Text = "Sim";
            this.rbCredito_sim.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 288);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(179, 34);
            this.label6.TabIndex = 22;
            this.label6.Text = "Estado";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxEstados
            // 
            this.comboBoxEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstados.FormattingEnabled = true;
            this.comboBoxEstados.Location = new System.Drawing.Point(187, 288);
            this.comboBoxEstados.Name = "comboBoxEstados";
            this.comboBoxEstados.Size = new System.Drawing.Size(200, 39);
            this.comboBoxEstados.TabIndex = 23;
            this.comboBoxEstados.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rbSuframado_sim
            // 
            this.rbSuframado_sim.AutoSize = true;
            this.rbSuframado_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuframado_sim.Location = new System.Drawing.Point(15, 7);
            this.rbSuframado_sim.Name = "rbSuframado_sim";
            this.rbSuframado_sim.Size = new System.Drawing.Size(73, 33);
            this.rbSuframado_sim.TabIndex = 18;
            this.rbSuframado_sim.TabStop = true;
            this.rbSuframado_sim.Text = "Sim";
            this.rbSuframado_sim.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSuframado_sim);
            this.panel1.Controls.Add(this.rbSuframado_nao);
            this.panel1.Location = new System.Drawing.Point(188, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 43);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbCredito_nao);
            this.panel2.Controls.Add(this.rbCredito_sim);
            this.panel2.Location = new System.Drawing.Point(188, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 38);
            this.panel2.TabIndex = 25;
            // 
            // Cadastrar_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxEstados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Fantasia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cnpj);
            this.Controls.Add(this.bt_empresa);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar_Fornecedor";
            this.Text = "Cadastrar_Fornecedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_empresa;
        private System.Windows.Forms.TextBox tb_cnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Fantasia;
        private System.Windows.Forms.RadioButton rbSuframado_nao;
        private System.Windows.Forms.RadioButton rbCredito_nao;
        private System.Windows.Forms.RadioButton rbCredito_sim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEstados;
        private System.Windows.Forms.RadioButton rbSuframado_sim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}