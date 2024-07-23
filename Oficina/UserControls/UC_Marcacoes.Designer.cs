namespace Oficina.UserControls
{
    partial class UC_Marcacoes
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
            btnEliminar = new Button();
            lblVeiculo = new Label();
            lblCliente = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEditar = new Button();
            btnCriar = new Button();
            listBoxMarcacoes = new ListBox();
            listBoxServicos = new ListBox();
            label4 = new Label();
            lblData = new Label();
            label8 = new Label();
            txtCliente = new TextBox();
            btnLimpar = new Button();
            btnPesquisar = new Button();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Brown;
            btnEliminar.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(703, 406);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(247, 66);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar Marcação";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblVeiculo
            // 
            lblVeiculo.AutoSize = true;
            lblVeiculo.Location = new Point(536, 112);
            lblVeiculo.Name = "lblVeiculo";
            lblVeiculo.Size = new Size(0, 23);
            lblVeiculo.TabIndex = 25;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(531, 68);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(0, 23);
            lblCliente.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(439, 156);
            label3.Name = "label3";
            label3.Size = new Size(206, 23);
            label3.TabIndex = 22;
            label3.Text = "Serviços solicitados:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(439, 112);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 23;
            label2.Text = "Veículo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(439, 68);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 24;
            label1.Text = "Cliente:";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Brown;
            btnEditar.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(703, 487);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(248, 66);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar Marcação";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.Brown;
            btnCriar.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnCriar.ForeColor = Color.White;
            btnCriar.Location = new Point(439, 487);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(248, 66);
            btnCriar.TabIndex = 16;
            btnCriar.Text = "Criar Marcação";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // listBoxMarcacoes
            // 
            listBoxMarcacoes.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxMarcacoes.ForeColor = Color.Brown;
            listBoxMarcacoes.FormattingEnabled = true;
            listBoxMarcacoes.ItemHeight = 21;
            listBoxMarcacoes.Location = new Point(34, 66);
            listBoxMarcacoes.Name = "listBoxMarcacoes";
            listBoxMarcacoes.Size = new Size(346, 403);
            listBoxMarcacoes.TabIndex = 15;
            listBoxMarcacoes.SelectedIndexChanged += listBoxMarcacoes_SelectedIndexChanged;
            // 
            // listBoxServicos
            // 
            listBoxServicos.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxServicos.ForeColor = Color.Brown;
            listBoxServicos.FormattingEnabled = true;
            listBoxServicos.ItemHeight = 21;
            listBoxServicos.Location = new Point(439, 195);
            listBoxServicos.Name = "listBoxServicos";
            listBoxServicos.Size = new Size(511, 130);
            listBoxServicos.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(439, 334);
            label4.Name = "label4";
            label4.Size = new Size(133, 23);
            label4.TabIndex = 23;
            label4.Text = "Data e Hora:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(578, 334);
            lblData.Name = "lblData";
            lblData.Size = new Size(0, 23);
            lblData.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 24);
            label8.Name = "label8";
            label8.Size = new Size(245, 23);
            label8.TabIndex = 32;
            label8.Text = "Consulta de Marcações";
            // 
            // txtCliente
            // 
            txtCliente.ForeColor = Color.Brown;
            txtCliente.Location = new Point(34, 475);
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Pesquisar por cliente";
            txtCliente.Size = new Size(346, 32);
            txtCliente.TabIndex = 35;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Brown;
            btnLimpar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(220, 513);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(160, 40);
            btnLimpar.TabIndex = 34;
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
            btnPesquisar.TabIndex = 33;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // UC_Marcacoes
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(txtCliente);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(label8);
            Controls.Add(listBoxServicos);
            Controls.Add(btnEliminar);
            Controls.Add(lblData);
            Controls.Add(lblVeiculo);
            Controls.Add(lblCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEditar);
            Controls.Add(btnCriar);
            Controls.Add(listBoxMarcacoes);
            Font = new Font("Century Gothic", 12F);
            ForeColor = Color.Brown;
            Name = "UC_Marcacoes";
            Size = new Size(985, 580);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Label lblVeiculo;
        private Label lblCliente;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEditar;
        private Button btnCriar;
        private ListBox listBoxMarcacoes;
        private ListBox listBoxServicos;
        private Label label4;
        private Label lblData;
        private Label label8;
        private TextBox txtCliente;
        private Button btnLimpar;
        private Button btnPesquisar;
    }
}
