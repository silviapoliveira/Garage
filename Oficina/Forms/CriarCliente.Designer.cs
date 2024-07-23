namespace Oficina.Forms
{
    partial class CriarCliente
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            lblId = new Label();
            txtNome = new TextBox();
            txtMorada = new TextBox();
            txtTelemovel = new TextBox();
            txtEmail = new TextBox();
            txtNif = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            txtApelido = new TextBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(44, 287);
            label8.Name = "label8";
            label8.Size = new Size(47, 23);
            label8.TabIndex = 4;
            label8.Text = "NIF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(44, 244);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 5;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(44, 201);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 6;
            label6.Text = "Telemóvel:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 158);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 7;
            label5.Text = "Morada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 72);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 8;
            label4.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 29);
            label1.Name = "label1";
            label1.Size = new Size(36, 23);
            label1.TabIndex = 9;
            label1.Text = "ID:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(86, 29);
            lblId.Name = "lblId";
            lblId.Size = new Size(80, 23);
            lblId.TabIndex = 10;
            lblId.Text = "_______";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(126, 63);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(572, 32);
            txtNome.TabIndex = 1;
            // 
            // txtMorada
            // 
            txtMorada.Location = new Point(142, 155);
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(556, 32);
            txtMorada.TabIndex = 3;
            // 
            // txtTelemovel
            // 
            txtTelemovel.Location = new Point(166, 198);
            txtTelemovel.Name = "txtTelemovel";
            txtTelemovel.Size = new Size(532, 32);
            txtTelemovel.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(118, 241);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(580, 32);
            txtEmail.TabIndex = 5;
            // 
            // txtNif
            // 
            txtNif.Location = new Point(97, 284);
            txtNif.Name = "txtNif";
            txtNif.Size = new Size(240, 32);
            txtNif.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Brown;
            btnGuardar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(128, 407);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(220, 40);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Brown;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(394, 407);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(220, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 115);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 8;
            label2.Text = "Apelido:";
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(143, 112);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(555, 32);
            txtApelido.TabIndex = 2;
            // 
            // CriarCliente
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 474);
            Controls.Add(txtApelido);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtMorada);
            Controls.Add(txtNif);
            Controls.Add(txtEmail);
            Controls.Add(txtTelemovel);
            Controls.Add(txtNome);
            Controls.Add(lblId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Brown;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CriarCliente";
            Text = "Criar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label lblId;
        private TextBox txtNome;
        private TextBox txtMorada;
        private TextBox txtTelemovel;
        private TextBox txtEmail;
        private TextBox txtNif;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label2;
        private TextBox txtApelido;
    }
}