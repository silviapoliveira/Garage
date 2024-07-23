namespace Oficina.Forms
{
    partial class EmitirFatura
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            comboBoxMarcacao = new ComboBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblData = new Label();
            lblCliente = new Label();
            lblVeiculo = new Label();
            label9 = new Label();
            dgvServicos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 1;
            label1.Text = "Marcação:";
            // 
            // comboBoxMarcacao
            // 
            comboBoxMarcacao.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxMarcacao.ForeColor = Color.Brown;
            comboBoxMarcacao.FormattingEnabled = true;
            comboBoxMarcacao.Location = new Point(168, 25);
            comboBoxMarcacao.Margin = new Padding(2);
            comboBoxMarcacao.Name = "comboBoxMarcacao";
            comboBoxMarcacao.Size = new Size(530, 31);
            comboBoxMarcacao.TabIndex = 8;
            comboBoxMarcacao.SelectedIndexChanged += comboBoxMarcacao_SelectedIndexChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Brown;
            btnConfirmar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(128, 407);
            btnConfirmar.Margin = new Padding(2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(220, 40);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Brown;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(394, 407);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(220, 40);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 82);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(235, 23);
            label2.TabIndex = 2;
            label2.Text = "Detalhes da Marcação";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 119);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 3;
            label3.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 153);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 4;
            label4.Text = "Veículo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 221);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(167, 19);
            label5.TabIndex = 9;
            label5.Text = "Serviços Prestados:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.Location = new Point(161, 187);
            lblData.Margin = new Padding(2, 0, 2, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(253, 21);
            lblData.TabIndex = 5;
            lblData.Text = "___________________________";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(120, 119);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(298, 21);
            lblCliente.TabIndex = 6;
            lblCliente.Text = "________________________________";
            // 
            // lblVeiculo
            // 
            lblVeiculo.AutoSize = true;
            lblVeiculo.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVeiculo.Location = new Point(126, 151);
            lblVeiculo.Name = "lblVeiculo";
            lblVeiculo.Size = new Size(289, 21);
            lblVeiculo.TabIndex = 6;
            lblVeiculo.Text = "_______________________________";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(44, 187);
            label9.Name = "label9";
            label9.Size = new Size(112, 19);
            label9.TabIndex = 6;
            label9.Text = "Data e Hora:";
            // 
            // dgvServicos
            // 
            dgvServicos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServicos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvServicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Brown;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvServicos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvServicos.GridColor = Color.White;
            dgvServicos.Location = new Point(44, 253);
            dgvServicos.Name = "dgvServicos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Brown;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvServicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvServicos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Brown;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvServicos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvServicos.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServicos.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvServicos.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvServicos.RowTemplate.DefaultCellStyle.ForeColor = Color.Brown;
            dgvServicos.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvServicos.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgvServicos.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvServicos.Size = new Size(654, 138);
            dgvServicos.TabIndex = 11;
            // 
            // EmitirFatura
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 475);
            Controls.Add(dgvServicos);
            Controls.Add(label9);
            Controls.Add(lblVeiculo);
            Controls.Add(lblCliente);
            Controls.Add(lblData);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(comboBoxMarcacao);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Brown;
            Margin = new Padding(4, 2, 4, 2);
            Name = "EmitirFatura";
            Text = "Emitir Fatura";
            ((System.ComponentModel.ISupportInitialize)dgvServicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxMarcacao;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblData;
        private Label lblCliente;
        private Label lblVeiculo;
        private Label label9;
        private DataGridView dgvServicos;
    }
}