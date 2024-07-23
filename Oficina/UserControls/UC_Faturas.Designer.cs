namespace Oficina.UserControls
{
    partial class UC_Faturas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxFaturas = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblNumero = new Label();
            btnEmitirFatura = new Button();
            btnImprimir = new Button();
            label6 = new Label();
            label7 = new Label();
            lblData = new Label();
            lblCliente = new Label();
            lblMorada = new Label();
            lblNif = new Label();
            listBoxServicos = new ListBox();
            label5 = new Label();
            lblTotal = new Label();
            label8 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            lblDesconto = new Label();
            txtNif = new TextBox();
            btnLimpar = new Button();
            btnPesquisar = new Button();
            SuspendLayout();
            // 
            // listBoxFaturas
            // 
            listBoxFaturas.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxFaturas.ForeColor = Color.Brown;
            listBoxFaturas.FormattingEnabled = true;
            listBoxFaturas.ItemHeight = 21;
            listBoxFaturas.Location = new Point(34, 66);
            listBoxFaturas.Name = "listBoxFaturas";
            listBoxFaturas.Size = new Size(346, 403);
            listBoxFaturas.TabIndex = 0;
            listBoxFaturas.SelectedIndexChanged += listBoxFaturas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(439, 24);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 1;
            label1.Text = "Fatura nº:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(439, 68);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 1;
            label2.Text = "Data da Fatura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(439, 112);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 1;
            label3.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(439, 156);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 1;
            label4.Text = "Morada:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(546, 24);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(0, 23);
            lblNumero.TabIndex = 1;
            // 
            // btnEmitirFatura
            // 
            btnEmitirFatura.BackColor = Color.Brown;
            btnEmitirFatura.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnEmitirFatura.ForeColor = Color.White;
            btnEmitirFatura.Location = new Point(439, 487);
            btnEmitirFatura.Name = "btnEmitirFatura";
            btnEmitirFatura.Size = new Size(248, 66);
            btnEmitirFatura.TabIndex = 2;
            btnEmitirFatura.Text = "Emitir Fatura";
            btnEmitirFatura.UseVisualStyleBackColor = false;
            btnEmitirFatura.Click += btnEmitirFatura_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.Brown;
            btnImprimir.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(703, 487);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(248, 66);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir Fatura";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.Location = new Point(439, 200);
            label6.Name = "label6";
            label6.Size = new Size(47, 23);
            label6.TabIndex = 1;
            label6.Text = "NIF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label7.Location = new Point(439, 244);
            label7.Name = "label7";
            label7.Size = new Size(197, 23);
            label7.TabIndex = 1;
            label7.Text = "Serviços prestados:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.Location = new Point(605, 68);
            lblData.Name = "lblData";
            lblData.Size = new Size(0, 23);
            lblData.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(531, 112);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(0, 23);
            lblCliente.TabIndex = 1;
            // 
            // lblMorada
            // 
            lblMorada.AutoSize = true;
            lblMorada.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMorada.Location = new Point(537, 156);
            lblMorada.Name = "lblMorada";
            lblMorada.Size = new Size(0, 23);
            lblMorada.TabIndex = 1;
            // 
            // lblNif
            // 
            lblNif.AutoSize = true;
            lblNif.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNif.Location = new Point(492, 200);
            lblNif.Name = "lblNif";
            lblNif.Size = new Size(0, 23);
            lblNif.TabIndex = 1;
            // 
            // listBoxServicos
            // 
            listBoxServicos.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxServicos.ForeColor = Color.Brown;
            listBoxServicos.FormattingEnabled = true;
            listBoxServicos.ItemHeight = 21;
            listBoxServicos.Location = new Point(439, 282);
            listBoxServicos.Name = "listBoxServicos";
            listBoxServicos.Size = new Size(512, 130);
            listBoxServicos.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(439, 430);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 1;
            label5.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(506, 430);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 23);
            lblTotal.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 24);
            label8.Name = "label8";
            label8.Size = new Size(203, 23);
            label8.TabIndex = 1;
            label8.Text = "Consulta de Faturas";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesconto.Location = new Point(506, 452);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(0, 17);
            lblDesconto.TabIndex = 1;
            // 
            // txtNif
            // 
            txtNif.ForeColor = Color.Brown;
            txtNif.Location = new Point(34, 475);
            txtNif.Name = "txtNif";
            txtNif.PlaceholderText = "Pesquisar por NIF";
            txtNif.Size = new Size(346, 32);
            txtNif.TabIndex = 11;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Brown;
            btnLimpar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(220, 513);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(160, 40);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Brown;
            btnPesquisar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(34, 513);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(160, 40);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // UC_Faturas
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(txtNif);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(lblTotal);
            Controls.Add(listBoxServicos);
            Controls.Add(btnImprimir);
            Controls.Add(btnEmitirFatura);
            Controls.Add(label7);
            Controls.Add(lblDesconto);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblData);
            Controls.Add(lblMorada);
            Controls.Add(lblNif);
            Controls.Add(lblCliente);
            Controls.Add(lblNumero);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(listBoxFaturas);
            Font = new Font("Century Gothic", 12F);
            ForeColor = Color.Brown;
            Name = "UC_Faturas";
            Size = new Size(985, 580);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxFaturas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblNumero;
        private Button btnEmitirFatura;
        private Button btnImprimir;
        private Label label6;
        private Label label7;
        private Label lblData;
        private Label lblCliente;
        private Label lblMorada;
        private Label lblNif;
        private ListBox listBoxServicos;
        private Label label5;
        private Label lblTotal;
        private Label label8;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label lblDesconto;
        private TextBox txtNif;
        private Button btnLimpar;
        private Button btnPesquisar;
    }
}
