namespace Oficina.Forms
{
    partial class CriarMarcacao
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
            btnCancelar = new Button();
            btnGuardar = new Button();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            comboBoxCliente = new ComboBox();
            comboBoxVeiculo = new ComboBox();
            label8 = new Label();
            dtpData = new DateTimePicker();
            listBoxDisponiveis = new ListBox();
            listBoxSeleccionados = new ListBox();
            btnDireita = new Button();
            btnEsquerda = new Button();
            label5 = new Label();
            comboBoxHoras = new ComboBox();
            label6 = new Label();
            lblId = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Brown;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(394, 407);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(220, 40);
            btnCancelar.TabIndex = 45;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Brown;
            btnGuardar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(128, 407);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(220, 40);
            btnGuardar.TabIndex = 44;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(280, 289);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(394, 160);
            label7.Name = "label7";
            label7.Size = new Size(247, 23);
            label7.TabIndex = 36;
            label7.Text = "Serviços Seleccionados:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 160);
            label2.Name = "label2";
            label2.Size = new Size(211, 23);
            label2.TabIndex = 40;
            label2.Text = "Serviços Disponíveis:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 117);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 41;
            label4.Text = "Veículo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 29);
            label1.Name = "label1";
            label1.Size = new Size(36, 23);
            label1.TabIndex = 42;
            label1.Text = "ID:";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(136, 70);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(562, 31);
            comboBoxCliente.TabIndex = 48;
            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;
            // 
            // comboBoxVeiculo
            // 
            comboBoxVeiculo.FormattingEnabled = true;
            comboBoxVeiculo.Location = new Point(141, 114);
            comboBoxVeiculo.Name = "comboBoxVeiculo";
            comboBoxVeiculo.Size = new Size(557, 31);
            comboBoxVeiculo.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(44, 358);
            label8.Name = "label8";
            label8.Size = new Size(62, 23);
            label8.TabIndex = 35;
            label8.Text = "Data:";
            // 
            // dtpData
            // 
            dtpData.CalendarForeColor = Color.Brown;
            dtpData.CalendarTitleForeColor = Color.Brown;
            dtpData.Checked = false;
            dtpData.Location = new Point(112, 355);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(236, 32);
            dtpData.TabIndex = 49;
            // 
            // listBoxDisponiveis
            // 
            listBoxDisponiveis.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxDisponiveis.ForeColor = Color.Brown;
            listBoxDisponiveis.FormattingEnabled = true;
            listBoxDisponiveis.ItemHeight = 21;
            listBoxDisponiveis.Location = new Point(44, 193);
            listBoxDisponiveis.Name = "listBoxDisponiveis";
            listBoxDisponiveis.Size = new Size(304, 151);
            listBoxDisponiveis.TabIndex = 50;
            // 
            // listBoxSeleccionados
            // 
            listBoxSeleccionados.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxSeleccionados.ForeColor = Color.Brown;
            listBoxSeleccionados.FormattingEnabled = true;
            listBoxSeleccionados.ItemHeight = 21;
            listBoxSeleccionados.Location = new Point(394, 193);
            listBoxSeleccionados.Name = "listBoxSeleccionados";
            listBoxSeleccionados.Size = new Size(304, 151);
            listBoxSeleccionados.TabIndex = 51;
            // 
            // btnDireita
            // 
            btnDireita.Image = Properties.Resources.btnDireita;
            btnDireita.Location = new Point(354, 213);
            btnDireita.Name = "btnDireita";
            btnDireita.Size = new Size(35, 35);
            btnDireita.TabIndex = 52;
            btnDireita.UseVisualStyleBackColor = true;
            btnDireita.Click += btnDireita_Click;
            // 
            // btnEsquerda
            // 
            btnEsquerda.Image = Properties.Resources.btnEsquerda;
            btnEsquerda.Location = new Point(354, 289);
            btnEsquerda.Name = "btnEsquerda";
            btnEsquerda.Size = new Size(35, 35);
            btnEsquerda.TabIndex = 52;
            btnEsquerda.UseVisualStyleBackColor = true;
            btnEsquerda.Click += btnEsquerda_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(394, 358);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 35;
            label5.Text = "Hora:";
            // 
            // comboBoxHoras
            // 
            comboBoxHoras.ForeColor = Color.Brown;
            comboBoxHoras.FormattingEnabled = true;
            comboBoxHoras.Location = new Point(462, 355);
            comboBoxHoras.Name = "comboBoxHoras";
            comboBoxHoras.Size = new Size(236, 31);
            comboBoxHoras.TabIndex = 53;
            comboBoxHoras.Text = "Seleccione uma hora";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(44, 73);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 42;
            label6.Text = "Cliente:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(86, 29);
            lblId.Name = "lblId";
            lblId.Size = new Size(120, 23);
            lblId.TabIndex = 54;
            lblId.Text = "___________";
            // 
            // CriarMarcacao
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 474);
            Controls.Add(lblId);
            Controls.Add(comboBoxHoras);
            Controls.Add(btnEsquerda);
            Controls.Add(btnDireita);
            Controls.Add(listBoxSeleccionados);
            Controls.Add(listBoxDisponiveis);
            Controls.Add(dtpData);
            Controls.Add(comboBoxVeiculo);
            Controls.Add(comboBoxCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Brown;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CriarMarcacao";
            Text = "Criar Marcação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnGuardar;
        private Label label3;
        private Label label7;
        private Label label2;
        private Label label4;
        private Label label1;
        private ComboBox comboBoxCliente;
        private ComboBox comboBoxVeiculo;
        private Label label8;
        private DateTimePicker dtpData;
        private ListBox listBoxDisponiveis;
        private ListBox listBoxSeleccionados;
        private Button btnDireita;
        private Button btnEsquerda;
        private Label label5;
        private ComboBox comboBoxHoras;
        private Label label6;
        private Label lblId;
    }
}