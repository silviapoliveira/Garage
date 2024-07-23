namespace Oficina.Forms
{
    partial class CriarFuncionario
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
            txtApelido = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtFuncao = new TextBox();
            txtSalario = new TextBox();
            txtNome = new TextBox();
            lblId = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(143, 112);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(555, 32);
            txtApelido.TabIndex = 12;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Brown;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(394, 407);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(220, 40);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Brown;
            btnGuardar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(128, 407);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(220, 40);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtFuncao
            // 
            txtFuncao.Location = new Point(139, 155);
            txtFuncao.Name = "txtFuncao";
            txtFuncao.Size = new Size(559, 32);
            txtFuncao.TabIndex = 13;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(131, 198);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(567, 32);
            txtSalario.TabIndex = 14;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(126, 63);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(572, 32);
            txtNome.TabIndex = 11;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(86, 29);
            lblId.Name = "lblId";
            lblId.Size = new Size(80, 23);
            lblId.TabIndex = 26;
            lblId.Text = "_______";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(44, 201);
            label6.Name = "label6";
            label6.Size = new Size(81, 23);
            label6.TabIndex = 19;
            label6.Text = "Salário:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 158);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 21;
            label5.Text = "Função:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 115);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 23;
            label2.Text = "Apelido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 72);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 24;
            label4.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 29);
            label1.Name = "label1";
            label1.Size = new Size(36, 23);
            label1.TabIndex = 25;
            label1.Text = "ID:";
            // 
            // CriarFuncionario
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 474);
            Controls.Add(txtApelido);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtFuncao);
            Controls.Add(txtSalario);
            Controls.Add(txtNome);
            Controls.Add(lblId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Brown;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CriarFuncionario";
            Text = "Criar Funcionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApelido;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtFuncao;
        private TextBox txtSalario;
        private TextBox txtNome;
        private Label lblId;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label1;
    }
}