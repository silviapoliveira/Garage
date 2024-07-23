namespace Oficina.Forms
{
    partial class EditarServico
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
            comboBoxFuncionarios = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtDescricao = new TextBox();
            lblId = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBoxFuncionarios
            // 
            comboBoxFuncionarios.FormattingEnabled = true;
            comboBoxFuncionarios.Location = new Point(180, 112);
            comboBoxFuncionarios.Name = "comboBoxFuncionarios";
            comboBoxFuncionarios.Size = new Size(518, 31);
            comboBoxFuncionarios.TabIndex = 60;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Brown;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(394, 407);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(220, 40);
            btnCancelar.TabIndex = 59;
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
            btnGuardar.TabIndex = 58;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(165, 69);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(533, 32);
            txtDescricao.TabIndex = 49;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(86, 29);
            lblId.Name = "lblId";
            lblId.Size = new Size(80, 23);
            lblId.TabIndex = 57;
            lblId.Text = "_______";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 115);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 54;
            label2.Text = "Funcionário:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 72);
            label4.Name = "label4";
            label4.Size = new Size(115, 23);
            label4.TabIndex = 55;
            label4.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 29);
            label1.Name = "label1";
            label1.Size = new Size(36, 23);
            label1.TabIndex = 56;
            label1.Text = "ID:";
            // 
            // EditarServico
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 474);
            Controls.Add(comboBoxFuncionarios);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescricao);
            Controls.Add(lblId);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Brown;
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditarServico";
            Text = "Editar Servico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFuncionarios;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtDescricao;
        private Label lblId;
        private Label label2;
        private Label label4;
        private Label label1;
    }
}