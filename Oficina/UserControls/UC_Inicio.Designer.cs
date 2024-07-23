namespace Oficina.UserControls
{
    partial class UC_Inicio
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
            label1 = new Label();
            label2 = new Label();
            lblTotalMarcacoes = new Label();
            lblTotalClientes = new Label();
            lblTotalFaturado = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(393, 113);
            label1.Name = "label1";
            label1.Size = new Size(199, 34);
            label1.TabIndex = 0;
            label1.Text = "VISÃO GERAL";
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 18);
            label2.Name = "label2";
            label2.Size = new Size(123, 54);
            label2.TabIndex = 0;
            label2.Text = "Total de Marcações";
            // 
            // lblTotalMarcacoes
            // 
            lblTotalMarcacoes.AutoSize = true;
            lblTotalMarcacoes.ForeColor = Color.White;
            lblTotalMarcacoes.Location = new Point(23, 82);
            lblTotalMarcacoes.Name = "lblTotalMarcacoes";
            lblTotalMarcacoes.Size = new Size(0, 23);
            lblTotalMarcacoes.TabIndex = 0;
            // 
            // lblTotalClientes
            // 
            lblTotalClientes.AutoSize = true;
            lblTotalClientes.ForeColor = Color.White;
            lblTotalClientes.Location = new Point(23, 82);
            lblTotalClientes.Name = "lblTotalClientes";
            lblTotalClientes.Size = new Size(0, 23);
            lblTotalClientes.TabIndex = 0;
            // 
            // lblTotalFaturado
            // 
            lblTotalFaturado.AutoSize = true;
            lblTotalFaturado.ForeColor = Color.White;
            lblTotalFaturado.Location = new Point(23, 82);
            lblTotalFaturado.Name = "lblTotalFaturado";
            lblTotalFaturado.Size = new Size(0, 23);
            lblTotalFaturado.TabIndex = 46;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Olive;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTotalMarcacoes);
            panel1.Location = new Point(367, 255);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 122);
            panel1.TabIndex = 47;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_marcacoes;
            pictureBox1.Location = new Point(162, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkKhaki;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblTotalClientes);
            panel2.Location = new Point(91, 255);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 122);
            panel2.TabIndex = 47;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_clientes;
            pictureBox2.Location = new Point(162, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 18);
            label3.Name = "label3";
            label3.Size = new Size(123, 54);
            label3.TabIndex = 0;
            label3.Text = "Total de Clientes";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkOliveGreen;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(lblTotalFaturado);
            panel4.Location = new Point(643, 255);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 122);
            panel4.TabIndex = 47;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo_faturacao;
            pictureBox4.Location = new Point(162, 29);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 48;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(23, 18);
            label7.Name = "label7";
            label7.Size = new Size(123, 54);
            label7.TabIndex = 0;
            label7.Text = "Total Faturado";
            // 
            // UC_Inicio
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Brown;
            Name = "UC_Inicio";
            Size = new Size(985, 580);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblTotalMarcacoes;
        private Label lblTotalClientes;
        private Label lblTotalFaturado;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label label7;
    }
}
