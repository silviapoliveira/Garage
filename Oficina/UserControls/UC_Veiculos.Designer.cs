namespace Oficina.UserControls
{
    partial class UC_Veiculos
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
            lblVeiculoAno = new Label();
            lblVeiculoMatricula = new Label();
            lblVeiculoModelo = new Label();
            lblVeiculoMarca = new Label();
            lblVeiculoTipo = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnEditarVeiculo = new Button();
            btnCriarVeiculo = new Button();
            listBoxVeiculos = new ListBox();
            label2 = new Label();
            lblVeiculoMes = new Label();
            label3 = new Label();
            lblProprietario = new Label();
            label9 = new Label();
            txtMatricula = new TextBox();
            btnLimpar = new Button();
            btnPesquisar = new Button();
            SuspendLayout();
            // 
            // lblVeiculoAno
            // 
            lblVeiculoAno.AutoSize = true;
            lblVeiculoAno.Location = new Point(501, 249);
            lblVeiculoAno.Name = "lblVeiculoAno";
            lblVeiculoAno.Size = new Size(0, 23);
            lblVeiculoAno.TabIndex = 8;
            // 
            // lblVeiculoMatricula
            // 
            lblVeiculoMatricula.AutoSize = true;
            lblVeiculoMatricula.Location = new Point(552, 204);
            lblVeiculoMatricula.Name = "lblVeiculoMatricula";
            lblVeiculoMatricula.Size = new Size(0, 23);
            lblVeiculoMatricula.TabIndex = 9;
            // 
            // lblVeiculoModelo
            // 
            lblVeiculoModelo.AutoSize = true;
            lblVeiculoModelo.Location = new Point(536, 159);
            lblVeiculoModelo.Name = "lblVeiculoModelo";
            lblVeiculoModelo.Size = new Size(0, 23);
            lblVeiculoModelo.TabIndex = 10;
            // 
            // lblVeiculoMarca
            // 
            lblVeiculoMarca.AutoSize = true;
            lblVeiculoMarca.Location = new Point(524, 114);
            lblVeiculoMarca.Name = "lblVeiculoMarca";
            lblVeiculoMarca.Size = new Size(0, 23);
            lblVeiculoMarca.TabIndex = 11;
            // 
            // lblVeiculoTipo
            // 
            lblVeiculoTipo.AutoSize = true;
            lblVeiculoTipo.Location = new Point(500, 69);
            lblVeiculoTipo.Name = "lblVeiculoTipo";
            lblVeiculoTipo.Size = new Size(0, 23);
            lblVeiculoTipo.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(439, 249);
            label8.Name = "label8";
            label8.Size = new Size(56, 23);
            label8.TabIndex = 13;
            label8.Text = "Ano:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(439, 204);
            label7.Name = "label7";
            label7.Size = new Size(107, 23);
            label7.TabIndex = 14;
            label7.Text = "Matrícula:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(439, 159);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 15;
            label6.Text = "Modelo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(439, 114);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 16;
            label5.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(439, 69);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 17;
            label4.Text = "Tipo:";
            // 
            // btnEditarVeiculo
            // 
            btnEditarVeiculo.BackColor = Color.Brown;
            btnEditarVeiculo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnEditarVeiculo.ForeColor = Color.White;
            btnEditarVeiculo.Location = new Point(703, 487);
            btnEditarVeiculo.Name = "btnEditarVeiculo";
            btnEditarVeiculo.Size = new Size(248, 66);
            btnEditarVeiculo.TabIndex = 6;
            btnEditarVeiculo.Text = "Editar Veículo";
            btnEditarVeiculo.UseVisualStyleBackColor = false;
            btnEditarVeiculo.Click += btnEditarVeiculo_Click;
            // 
            // btnCriarVeiculo
            // 
            btnCriarVeiculo.BackColor = Color.Brown;
            btnCriarVeiculo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnCriarVeiculo.ForeColor = Color.White;
            btnCriarVeiculo.Location = new Point(439, 487);
            btnCriarVeiculo.Name = "btnCriarVeiculo";
            btnCriarVeiculo.Size = new Size(248, 66);
            btnCriarVeiculo.TabIndex = 5;
            btnCriarVeiculo.Text = "Criar Veículo";
            btnCriarVeiculo.UseVisualStyleBackColor = false;
            btnCriarVeiculo.Click += btnCriarVeiculo_Click;
            // 
            // listBoxVeiculos
            // 
            listBoxVeiculos.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxVeiculos.ForeColor = Color.Brown;
            listBoxVeiculos.FormattingEnabled = true;
            listBoxVeiculos.ItemHeight = 21;
            listBoxVeiculos.Location = new Point(34, 66);
            listBoxVeiculos.Name = "listBoxVeiculos";
            listBoxVeiculos.Size = new Size(346, 403);
            listBoxVeiculos.TabIndex = 4;
            listBoxVeiculos.SelectedIndexChanged += listBoxVeiculos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(439, 291);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 13;
            label2.Text = "Mês:";
            // 
            // lblVeiculoMes
            // 
            lblVeiculoMes.AutoSize = true;
            lblVeiculoMes.Location = new Point(501, 291);
            lblVeiculoMes.Name = "lblVeiculoMes";
            lblVeiculoMes.Size = new Size(0, 23);
            lblVeiculoMes.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(439, 334);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 13;
            label3.Text = "Proprietário:";
            // 
            // lblProprietario
            // 
            lblProprietario.AutoSize = true;
            lblProprietario.Location = new Point(571, 334);
            lblProprietario.Name = "lblProprietario";
            lblProprietario.Size = new Size(0, 23);
            lblProprietario.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.Location = new Point(34, 24);
            label9.Name = "label9";
            label9.Size = new Size(218, 23);
            label9.TabIndex = 19;
            label9.Text = "Consulta de Veículos";
            // 
            // txtMatricula
            // 
            txtMatricula.ForeColor = Color.Brown;
            txtMatricula.Location = new Point(34, 475);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Pesquisar por matrícula";
            txtMatricula.Size = new Size(346, 32);
            txtMatricula.TabIndex = 22;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Brown;
            btnLimpar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(220, 513);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(160, 40);
            btnLimpar.TabIndex = 21;
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
            btnPesquisar.TabIndex = 20;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // UC_Veiculos
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(txtMatricula);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(label9);
            Controls.Add(lblProprietario);
            Controls.Add(lblVeiculoMes);
            Controls.Add(lblVeiculoAno);
            Controls.Add(lblVeiculoMatricula);
            Controls.Add(lblVeiculoModelo);
            Controls.Add(lblVeiculoMarca);
            Controls.Add(label3);
            Controls.Add(lblVeiculoTipo);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnEditarVeiculo);
            Controls.Add(btnCriarVeiculo);
            Controls.Add(listBoxVeiculos);
            Font = new Font("Century Gothic", 12F);
            ForeColor = Color.Brown;
            Name = "UC_Veiculos";
            Size = new Size(985, 580);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblVeiculoAno;
        private Label lblVeiculoMatricula;
        private Label lblVeiculoModelo;
        private Label lblVeiculoMarca;
        private Label lblVeiculoTipo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnEditarVeiculo;
        private Button btnCriarVeiculo;
        private ListBox listBoxVeiculos;
        private Label label2;
        private Label lblVeiculoMes;
        private Label label3;
        private Label lblProprietario;
        private Label label9;
        private TextBox txtMatricula;
        private Button btnLimpar;
        private Button btnPesquisar;
    }
}
