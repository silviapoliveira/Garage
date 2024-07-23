namespace Oficina.Forms
{
    partial class EditarMarcacao
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
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            comboBoxCliente = new ComboBox();
            comboBoxVeiculo = new ComboBox();
            listBoxDisponiveis = new ListBox();
            listBoxSeleccionados = new ListBox();
            comboBoxHoras = new ComboBox();
            dtpData = new DateTimePicker();
            btnDireita = new Button();
            btnEsquerda = new Button();
            label3 = new Label();
            lblId = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(394, 358);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 43;
            label5.Text = "Hora:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(44, 358);
            label8.Name = "label8";
            label8.Size = new Size(62, 23);
            label8.TabIndex = 44;
            label8.Text = "Data:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(394, 160);
            label7.Name = "label7";
            label7.Size = new Size(247, 23);
            label7.TabIndex = 45;
            label7.Text = "Serviços Seleccionados:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 160);
            label2.Name = "label2";
            label2.Size = new Size(211, 23);
            label2.TabIndex = 46;
            label2.Text = "Serviços Disponíveis:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 117);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 47;
            label4.Text = "Veículo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 29);
            label1.Name = "label1";
            label1.Size = new Size(36, 23);
            label1.TabIndex = 48;
            label1.Text = "ID:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Brown;
            btnGuardar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(128, 407);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(220, 40);
            btnGuardar.TabIndex = 49;
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
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(136, 70);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(562, 31);
            comboBoxCliente.TabIndex = 50;
            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;
            // 
            // comboBoxVeiculo
            // 
            comboBoxVeiculo.FormattingEnabled = true;
            comboBoxVeiculo.Location = new Point(141, 114);
            comboBoxVeiculo.Name = "comboBoxVeiculo";
            comboBoxVeiculo.Size = new Size(557, 31);
            comboBoxVeiculo.TabIndex = 51;
            // 
            // listBoxDisponiveis
            // 
            listBoxDisponiveis.Font = new Font("Century Gothic", 10.2F);
            listBoxDisponiveis.ForeColor = Color.Brown;
            listBoxDisponiveis.FormattingEnabled = true;
            listBoxDisponiveis.ItemHeight = 21;
            listBoxDisponiveis.Location = new Point(44, 193);
            listBoxDisponiveis.Name = "listBoxDisponiveis";
            listBoxDisponiveis.Size = new Size(304, 151);
            listBoxDisponiveis.TabIndex = 52;
            // 
            // listBoxSeleccionados
            // 
            listBoxSeleccionados.Font = new Font("Century Gothic", 10.2F);
            listBoxSeleccionados.ForeColor = Color.Brown;
            listBoxSeleccionados.FormattingEnabled = true;
            listBoxSeleccionados.ItemHeight = 21;
            listBoxSeleccionados.Location = new Point(394, 193);
            listBoxSeleccionados.Name = "listBoxSeleccionados";
            listBoxSeleccionados.Size = new Size(304, 151);
            listBoxSeleccionados.TabIndex = 53;
            // 
            // comboBoxHoras
            // 
            comboBoxHoras.ForeColor = Color.Brown;
            comboBoxHoras.FormattingEnabled = true;
            comboBoxHoras.Location = new Point(462, 355);
            comboBoxHoras.Name = "comboBoxHoras";
            comboBoxHoras.Size = new Size(236, 31);
            comboBoxHoras.TabIndex = 54;
            comboBoxHoras.Text = "Seleccione uma hora";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(112, 355);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(236, 32);
            dtpData.TabIndex = 55;
            // 
            // btnDireita
            // 
            btnDireita.Image = Properties.Resources.btnDireita;
            btnDireita.Location = new Point(354, 213);
            btnDireita.Name = "btnDireita";
            btnDireita.Size = new Size(35, 35);
            btnDireita.TabIndex = 56;
            btnDireita.UseVisualStyleBackColor = true;
            btnDireita.Click += btnDireita_Click;
            // 
            // btnEsquerda
            // 
            btnEsquerda.Image = Properties.Resources.btnEsquerda;
            btnEsquerda.Location = new Point(354, 289);
            btnEsquerda.Name = "btnEsquerda";
            btnEsquerda.Size = new Size(35, 35);
            btnEsquerda.TabIndex = 56;
            btnEsquerda.UseVisualStyleBackColor = true;
            btnEsquerda.Click += btnEsquerda_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 73);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 48;
            label3.Text = "Cliente:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(86, 29);
            lblId.Name = "lblId";
            lblId.Size = new Size(120, 23);
            lblId.TabIndex = 57;
            lblId.Text = "___________";
            // 
            // EditarMarcacao
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 474);
            Controls.Add(lblId);
            Controls.Add(btnEsquerda);
            Controls.Add(btnDireita);
            Controls.Add(dtpData);
            Controls.Add(comboBoxHoras);
            Controls.Add(listBoxSeleccionados);
            Controls.Add(listBoxDisponiveis);
            Controls.Add(comboBoxVeiculo);
            Controls.Add(comboBoxCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Brown;
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditarMarcacao";
            Text = "Editar Marcação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label8;
        private Label label7;
        private Label label2;
        private Label label4;
        private Label label1;
        private Button btnGuardar;
        private Button btnCancelar;
        private ComboBox comboBoxCliente;
        private ComboBox comboBoxVeiculo;
        private ListBox listBoxDisponiveis;
        private ListBox listBoxSeleccionados;
        private ComboBox comboBoxHoras;
        private DateTimePicker dtpData;
        private Button btnDireita;
        private Button btnEsquerda;
        private Label label3;
        private Label lblId;
    }
}