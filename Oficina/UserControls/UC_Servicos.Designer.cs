namespace Oficina.UserControls
{
    partial class UC_Servicos
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
            btnEditar = new Button();
            btnCriar = new Button();
            listBoxServicos = new ListBox();
            label2 = new Label();
            label3 = new Label();
            lblDescricao = new Label();
            lblFuncionario = new Label();
            btnEliminar = new Button();
            label8 = new Label();
            txtDescricao = new TextBox();
            btnLimpar = new Button();
            btnPesquisar = new Button();
            SuspendLayout();
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
            btnEditar.Text = "Editar Serviço";
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
            btnCriar.Text = "Criar Serviço";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // listBoxServicos
            // 
            listBoxServicos.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxServicos.ForeColor = Color.Brown;
            listBoxServicos.FormattingEnabled = true;
            listBoxServicos.ItemHeight = 21;
            listBoxServicos.Location = new Point(34, 66);
            listBoxServicos.Name = "listBoxServicos";
            listBoxServicos.Size = new Size(346, 403);
            listBoxServicos.TabIndex = 4;
            listBoxServicos.SelectedIndexChanged += listBoxServicos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(439, 68);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 8;
            label2.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(439, 112);
            label3.Name = "label3";
            label3.Size = new Size(224, 23);
            label3.TabIndex = 8;
            label3.Text = "Funcionário Atribuído:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(560, 68);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(0, 23);
            lblDescricao.TabIndex = 9;
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Location = new Point(669, 112);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(0, 23);
            lblFuncionario.TabIndex = 13;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Brown;
            btnEliminar.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(703, 406);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(248, 66);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar Serviço";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 24);
            label8.Name = "label8";
            label8.Size = new Size(214, 23);
            label8.TabIndex = 15;
            label8.Text = "Consulta de Serviços";
            // 
            // txtDescricao
            // 
            txtDescricao.ForeColor = Color.Brown;
            txtDescricao.Location = new Point(34, 475);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Pesquisar por descrição";
            txtDescricao.Size = new Size(346, 32);
            txtDescricao.TabIndex = 18;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Brown;
            btnLimpar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(220, 513);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(160, 40);
            btnLimpar.TabIndex = 17;
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
            btnPesquisar.TabIndex = 16;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // UC_Servicos
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtDescricao);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(label8);
            Controls.Add(btnEliminar);
            Controls.Add(lblFuncionario);
            Controls.Add(lblDescricao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEditar);
            Controls.Add(btnCriar);
            Controls.Add(listBoxServicos);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Brown;
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_Servicos";
            Size = new Size(985, 580);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEditar;
        private Button btnCriar;
        private ListBox listBoxServicos;
        private Label label2;
        private Label label3;
        private Label lblDescricao;
        private Label lblFuncionario;
        private Button btnEliminar;
        private Label label8;
        private TextBox txtDescricao;
        private Button btnLimpar;
        private Button btnPesquisar;
    }
}
