namespace Oficina.Forms
{
    partial class EditarVeiculo
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
            comboBoxMes = new ComboBox();
            comboBoxAno = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtMatricula = new TextBox();
            txtTipo = new TextBox();
            lblId = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            comboBoxClientes = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // comboBoxMes
            // 
            comboBoxMes.FormattingEnabled = true;
            comboBoxMes.Location = new Point(106, 284);
            comboBoxMes.Name = "comboBoxMes";
            comboBoxMes.Size = new Size(151, 31);
            comboBoxMes.TabIndex = 44;
            // 
            // comboBoxAno
            // 
            comboBoxAno.FormattingEnabled = true;
            comboBoxAno.Location = new Point(106, 241);
            comboBoxAno.Name = "comboBoxAno";
            comboBoxAno.Size = new Size(151, 31);
            comboBoxAno.TabIndex = 45;
            comboBoxAno.SelectedIndexChanged += comboBoxAno_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Brown;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(394, 407);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(220, 40);
            btnCancelar.TabIndex = 43;
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
            btnGuardar.TabIndex = 42;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(129, 112);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(569, 32);
            txtMarca.TabIndex = 31;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(141, 155);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(557, 32);
            txtModelo.TabIndex = 32;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(157, 198);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(541, 32);
            txtMatricula.TabIndex = 33;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(105, 69);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(593, 32);
            txtTipo.TabIndex = 30;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(86, 29);
            lblId.Name = "lblId";
            lblId.Size = new Size(80, 23);
            lblId.TabIndex = 41;
            lblId.Text = "_______";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(44, 287);
            label8.Name = "label8";
            label8.Size = new Size(56, 23);
            label8.TabIndex = 34;
            label8.Text = "Mês:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(44, 244);
            label7.Name = "label7";
            label7.Size = new Size(56, 23);
            label7.TabIndex = 35;
            label7.Text = "Ano:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(44, 201);
            label6.Name = "label6";
            label6.Size = new Size(107, 23);
            label6.TabIndex = 36;
            label6.Text = "Matrícula:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 158);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 37;
            label5.Text = "Modelo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 115);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 38;
            label2.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 72);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 39;
            label4.Text = "Tipo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 29);
            label1.Name = "label1";
            label1.Size = new Size(36, 23);
            label1.TabIndex = 40;
            label1.Text = "ID:";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(412, 241);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(286, 31);
            comboBoxClientes.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(280, 244);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 46;
            label3.Text = "Proprietário:";
            // 
            // EditarVeiculo
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 474);
            Controls.Add(comboBoxClientes);
            Controls.Add(label3);
            Controls.Add(comboBoxMes);
            Controls.Add(comboBoxAno);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(txtMatricula);
            Controls.Add(txtTipo);
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
            Name = "EditarVeiculo";
            Text = "Editar Veiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMes;
        private ComboBox comboBoxAno;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtMatricula;
        private TextBox txtTipo;
        private Label lblId;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label1;
        private ComboBox comboBoxClientes;
        private Label label3;
    }
}