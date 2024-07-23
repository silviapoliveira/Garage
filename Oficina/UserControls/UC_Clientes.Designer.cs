namespace Oficina.UserControls
{
    partial class UC_Clientes
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
            listBoxClientes = new ListBox();
            btnCriarCliente = new Button();
            btnEditarCliente = new Button();
            lblClienteNome = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblClienteMorada = new Label();
            lblClienteTelemovel = new Label();
            lblClienteEmail = new Label();
            lblClienteNif = new Label();
            listBoxVeiculos = new ListBox();
            label2 = new Label();
            label3 = new Label();
            btnPesquisar = new Button();
            btnLimpar = new Button();
            txtNif = new TextBox();
            SuspendLayout();
            // 
            // listBoxClientes
            // 
            listBoxClientes.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxClientes.ForeColor = Color.Brown;
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.ItemHeight = 21;
            listBoxClientes.Location = new Point(34, 66);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(346, 403);
            listBoxClientes.TabIndex = 0;
            listBoxClientes.SelectedIndexChanged += listBoxClientes_SelectedIndexChanged;
            // 
            // btnCriarCliente
            // 
            btnCriarCliente.BackColor = Color.Brown;
            btnCriarCliente.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnCriarCliente.ForeColor = Color.White;
            btnCriarCliente.Location = new Point(439, 487);
            btnCriarCliente.Name = "btnCriarCliente";
            btnCriarCliente.Size = new Size(248, 66);
            btnCriarCliente.TabIndex = 1;
            btnCriarCliente.Text = "Criar Cliente";
            btnCriarCliente.UseVisualStyleBackColor = false;
            btnCriarCliente.Click += btnCriarCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.BackColor = Color.Brown;
            btnEditarCliente.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnEditarCliente.ForeColor = Color.White;
            btnEditarCliente.Location = new Point(703, 487);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(248, 66);
            btnEditarCliente.TabIndex = 2;
            btnEditarCliente.Text = "Editar Cliente";
            btnEditarCliente.UseVisualStyleBackColor = false;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // lblClienteNome
            // 
            lblClienteNome.AutoSize = true;
            lblClienteNome.Location = new Point(521, 69);
            lblClienteNome.Name = "lblClienteNome";
            lblClienteNome.Size = new Size(0, 23);
            lblClienteNome.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(439, 69);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 3;
            label4.Text = "Nome:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(442, 114);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 3;
            label5.Text = "Morada:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(439, 159);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 3;
            label6.Text = "Telemóvel:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(439, 204);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 3;
            label7.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(439, 249);
            label8.Name = "label8";
            label8.Size = new Size(47, 23);
            label8.TabIndex = 3;
            label8.Text = "NIF:";
            // 
            // lblClienteMorada
            // 
            lblClienteMorada.AutoSize = true;
            lblClienteMorada.Location = new Point(540, 114);
            lblClienteMorada.Name = "lblClienteMorada";
            lblClienteMorada.Size = new Size(0, 23);
            lblClienteMorada.TabIndex = 3;
            // 
            // lblClienteTelemovel
            // 
            lblClienteTelemovel.AutoSize = true;
            lblClienteTelemovel.Location = new Point(561, 159);
            lblClienteTelemovel.Name = "lblClienteTelemovel";
            lblClienteTelemovel.Size = new Size(0, 23);
            lblClienteTelemovel.TabIndex = 3;
            // 
            // lblClienteEmail
            // 
            lblClienteEmail.AutoSize = true;
            lblClienteEmail.Location = new Point(513, 204);
            lblClienteEmail.Name = "lblClienteEmail";
            lblClienteEmail.Size = new Size(0, 23);
            lblClienteEmail.TabIndex = 3;
            // 
            // lblClienteNif
            // 
            lblClienteNif.AutoSize = true;
            lblClienteNif.Location = new Point(492, 249);
            lblClienteNif.Name = "lblClienteNif";
            lblClienteNif.Size = new Size(0, 23);
            lblClienteNif.TabIndex = 3;
            // 
            // listBoxVeiculos
            // 
            listBoxVeiculos.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxVeiculos.ForeColor = Color.Brown;
            listBoxVeiculos.FormattingEnabled = true;
            listBoxVeiculos.ItemHeight = 21;
            listBoxVeiculos.Location = new Point(439, 339);
            listBoxVeiculos.Name = "listBoxVeiculos";
            listBoxVeiculos.Size = new Size(509, 130);
            listBoxVeiculos.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(439, 293);
            label2.Name = "label2";
            label2.Size = new Size(347, 23);
            label2.TabIndex = 3;
            label2.Text = "Veículos registados em seu nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 24);
            label3.Name = "label3";
            label3.Size = new Size(213, 23);
            label3.TabIndex = 5;
            label3.Text = "Consulta de Clientes";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Brown;
            btnPesquisar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(34, 513);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(160, 40);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Brown;
            btnLimpar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(220, 513);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(160, 40);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtNif
            // 
            txtNif.ForeColor = Color.Brown;
            txtNif.Location = new Point(34, 475);
            txtNif.Name = "txtNif";
            txtNif.PlaceholderText = "Pesquisar por NIF";
            txtNif.Size = new Size(346, 32);
            txtNif.TabIndex = 8;
            // 
            // UC_Clientes
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(txtNif);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(label3);
            Controls.Add(listBoxVeiculos);
            Controls.Add(lblClienteNif);
            Controls.Add(lblClienteEmail);
            Controls.Add(lblClienteTelemovel);
            Controls.Add(lblClienteMorada);
            Controls.Add(lblClienteNome);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnEditarCliente);
            Controls.Add(btnCriarCliente);
            Controls.Add(listBoxClientes);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Brown;
            Name = "UC_Clientes";
            Size = new Size(985, 580);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxClientes;
        private Button btnCriarCliente;
        private Button btnEditarCliente;
        private Label lblClienteNome;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblClienteMorada;
        private Label lblClienteTelemovel;
        private Label lblClienteEmail;
        private Label lblClienteNif;
        private ListBox listBoxVeiculos;
        private Label label2;
        private Label label3;
        private Button btnPesquisar;
        private Button btnLimpar;
        private TextBox txtNif;
    }
}
