namespace _1_teste
{
    partial class tx_respostidad
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
            this.tx_datanas = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_numerocont = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_ingresso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_quant = new System.Windows.Forms.NumericUpDown();
            this.tx_idadein = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_valor = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tx_formapagamento = new System.Windows.Forms.ComboBox();
            this.limpar = new System.Windows.Forms.Button();
            this.tx_cpfvalid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tx_quant)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_datanas
            // 
            this.tx_datanas.Location = new System.Drawing.Point(121, 207);
            this.tx_datanas.Name = "tx_datanas";
            this.tx_datanas.Size = new System.Drawing.Size(275, 22);
            this.tx_datanas.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 7;
            this.button1.Text = "Resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 72);
            this.label1.TabIndex = 8;
            this.label1.Text = "Xpark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(121, 116);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(252, 22);
            this.tx_nome.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(18, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "CPF:";
            // 
            // tx_cpf
            // 
            this.tx_cpf.BackColor = System.Drawing.SystemColors.Window;
            this.tx_cpf.Location = new System.Drawing.Point(121, 165);
            this.tx_cpf.Mask = "000,000,000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(117, 22);
            this.tx_cpf.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(18, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Idade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.GhostWhite;
            this.label7.Location = new System.Drawing.Point(18, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Número para Contato:";
            // 
            // tx_numerocont
            // 
            this.tx_numerocont.Location = new System.Drawing.Point(317, 256);
            this.tx_numerocont.Mask = "(99) 00000-0000";
            this.tx_numerocont.Name = "tx_numerocont";
            this.tx_numerocont.Size = new System.Drawing.Size(125, 22);
            this.tx_numerocont.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(18, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Show: ";
            // 
            // tx_ingresso
            // 
            this.tx_ingresso.FormattingEnabled = true;
            this.tx_ingresso.Location = new System.Drawing.Point(121, 300);
            this.tx_ingresso.Name = "tx_ingresso";
            this.tx_ingresso.Size = new System.Drawing.Size(180, 24);
            this.tx_ingresso.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.GhostWhite;
            this.label6.Location = new System.Drawing.Point(18, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "Quantidade:";
            // 
            // tx_quant
            // 
            this.tx_quant.Location = new System.Drawing.Point(205, 348);
            this.tx_quant.Name = "tx_quant";
            this.tx_quant.Size = new System.Drawing.Size(120, 22);
            this.tx_quant.TabIndex = 22;
            // 
            // tx_idadein
            // 
            this.tx_idadein.BackColor = System.Drawing.Color.Black;
            this.tx_idadein.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_idadein.Enabled = false;
            this.tx_idadein.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_idadein.Location = new System.Drawing.Point(434, 208);
            this.tx_idadein.Name = "tx_idadein";
            this.tx_idadein.Size = new System.Drawing.Size(366, 15);
            this.tx_idadein.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(508, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 32);
            this.label8.TabIndex = 24;
            this.label8.Text = "Total:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tx_valor
            // 
            this.tx_valor.Enabled = false;
            this.tx_valor.Location = new System.Drawing.Point(600, 348);
            this.tx_valor.Name = "tx_valor";
            this.tx_valor.Size = new System.Drawing.Size(100, 22);
            this.tx_valor.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BlueViolet;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.GhostWhite;
            this.button2.Location = new System.Drawing.Point(24, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 26;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BlueViolet;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.GhostWhite;
            this.button3.Location = new System.Drawing.Point(259, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 38);
            this.button3.TabIndex = 27;
            this.button3.Text = "Resultado";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.BlueViolet;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.GhostWhite;
            this.button4.Location = new System.Drawing.Point(690, 434);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 39);
            this.button4.TabIndex = 28;
            this.button4.Text = "Proxímo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(412, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 36);
            this.label9.TabIndex = 29;
            this.label9.Text = "Forma de Pamento:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tx_formapagamento
            // 
            this.tx_formapagamento.FormattingEnabled = true;
            this.tx_formapagamento.Items.AddRange(new object[] {
            "Cartâo Crédito ",
            "Cartão Débito",
            "Pix ",
            "Depósito ",
            "Fatura "});
            this.tx_formapagamento.Location = new System.Drawing.Point(700, 116);
            this.tx_formapagamento.Name = "tx_formapagamento";
            this.tx_formapagamento.Size = new System.Drawing.Size(121, 24);
            this.tx_formapagamento.TabIndex = 30;
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.Color.BlueViolet;
            this.limpar.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.ForeColor = System.Drawing.Color.GhostWhite;
            this.limpar.Location = new System.Drawing.Point(418, 434);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(112, 38);
            this.limpar.TabIndex = 31;
            this.limpar.Text = "Cancelar";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // tx_cpfvalid
            // 
            this.tx_cpfvalid.BackColor = System.Drawing.Color.Black;
            this.tx_cpfvalid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cpfvalid.Enabled = false;
            this.tx_cpfvalid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tx_cpfvalid.Location = new System.Drawing.Point(259, 168);
            this.tx_cpfvalid.Name = "tx_cpfvalid";
            this.tx_cpfvalid.Size = new System.Drawing.Size(366, 15);
            this.tx_cpfvalid.TabIndex = 32;
            // 
            // tx_respostidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(856, 485);
            this.Controls.Add(this.tx_cpfvalid);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.tx_formapagamento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tx_valor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tx_idadein);
            this.Controls.Add(this.tx_quant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_ingresso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_numerocont);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_datanas);
            this.ForeColor = System.Drawing.Color.GhostWhite;
            this.Name = "tx_respostidad";
            this.Text = "Pagina3";
            this.Load += new System.EventHandler(this.tx_respostidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tx_quant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tx_datanas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox tx_numerocont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tx_ingresso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown tx_quant;
        private System.Windows.Forms.TextBox tx_idadein;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tx_valor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tx_formapagamento;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.TextBox tx_cpfvalid;
    }
}