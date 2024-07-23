namespace Oficina.UserControls
{
    partial class UC_Funcionarios
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
            lblSalario = new Label();
            lblFuncao = new Label();
            lblNome = new Label();
            label10 = new Label();
            label9 = new Label();
            label3 = new Label();
            btnEditar = new Button();
            btnCriar = new Button();
            listBoxFuncionarios = new ListBox();
            listBoxServicos = new ListBox();
            label1 = new Label();
            label8 = new Label();
            txtNome = new TextBox();
            btnLimpar = new Button();
            btnPesquisar = new Button();
            SuspendLayout();
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(526, 159);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(0, 23);
            lblSalario.TabIndex = 10;
            // 
            // lblFuncao
            // 
            lblFuncao.AutoSize = true;
            lblFuncao.Location = new Point(537, 114);
            lblFuncao.Name = "lblFuncao";
            lblFuncao.Size = new Size(0, 23);
            lblFuncao.TabIndex = 11;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(521, 69);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 23);
            lblNome.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(439, 159);
            label10.Name = "label10";
            label10.Size = new Size(81, 23);
            label10.TabIndex = 15;
            label10.Text = "Salário:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(439, 114);
            label9.Name = "label9";
            label9.Size = new Size(89, 23);
            label9.TabIndex = 16;
            label9.Text = "Função:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(439, 69);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 17;
            label3.Text = "Nome:";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Brown;
            btnEditar.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(703, 487);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(248, 66);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar Funcionário";
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
            btnCriar.TabIndex = 5;
            btnCriar.Text = "Criar Funcionário";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // listBoxFuncionarios
            // 
            listBoxFuncionarios.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxFuncionarios.ForeColor = Color.Brown;
            listBoxFuncionarios.FormattingEnabled = true;
            listBoxFuncionarios.ItemHeight = 21;
            listBoxFuncionarios.Location = new Point(34, 66);
            listBoxFuncionarios.Name = "listBoxFuncionarios";
            listBoxFuncionarios.Size = new Size(346, 403);
            listBoxFuncionarios.TabIndex = 4;
            listBoxFuncionarios.SelectedIndexChanged += listBoxFuncionarios_SelectedIndexChanged;
            // 
            // listBoxServicos
            // 
            listBoxServicos.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxServicos.ForeColor = Color.Brown;
            listBoxServicos.FormattingEnabled = true;
            listBoxServicos.ItemHeight = 21;
            listBoxServicos.Location = new Point(439, 255);
            listBoxServicos.Name = "listBoxServicos";
            listBoxServicos.Size = new Size(509, 214);
            listBoxServicos.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(439, 202);
            label1.Name = "label1";
            label1.Size = new Size(355, 23);
            label1.TabIndex = 19;
            label1.Text = "Serviços pelos quais é responsável:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 24);
            label8.Name = "label8";
            label8.Size = new Size(257, 23);
            label8.TabIndex = 21;
            label8.Text = "Consulta de Funcionários";
            // 
            // txtNome
            // 
            txtNome.ForeColor = Color.Brown;
            txtNome.Location = new Point(34, 475);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Pesquisar por nome";
            txtNome.Size = new Size(346, 32);
            txtNome.TabIndex = 24;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Brown;
            btnLimpar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(220, 513);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(160, 40);
            btnLimpar.TabIndex = 23;
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
            btnPesquisar.TabIndex = 22;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // UC_Funcionarios
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(txtNome);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(label8);
            Controls.Add(listBoxServicos);
            Controls.Add(label1);
            Controls.Add(lblSalario);
            Controls.Add(lblFuncao);
            Controls.Add(lblNome);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(btnEditar);
            Controls.Add(btnCriar);
            Controls.Add(listBoxFuncionarios);
            Font = new Font("Century Gothic", 12F);
            ForeColor = Color.Brown;
            Name = "UC_Funcionarios";
            Size = new Size(985, 580);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSalario;
        private Label lblFuncao;
        private Label lblNome;
        private Label label10;
        private Label label9;
        private Label label3;
        private Button btnEditar;
        private Button btnCriar;
        private ListBox listBoxFuncionarios;
        private ListBox listBoxServicos;
        private Label label1;
        private Label label8;
        private TextBox txtNome;
        private Button btnLimpar;
        private Button btnPesquisar;
    }
}
