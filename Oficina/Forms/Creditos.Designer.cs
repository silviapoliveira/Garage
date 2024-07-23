namespace Oficina.Forms
{
    partial class Creditos
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
            lblId = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(221, 229);
            lblId.Name = "lblId";
            lblId.Size = new Size(226, 23);
            lblId.TabIndex = 40;
            lblId.Text = "Sílvia Pinto de Oliveira";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 102);
            label1.Name = "label1";
            label1.Size = new Size(450, 34);
            label1.TabIndex = 39;
            label1.Text = "TRABALHO DESENVOLVIDO POR:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 269);
            label2.Name = "label2";
            label2.Size = new Size(390, 23);
            label2.TabIndex = 40;
            label2.Text = "silvia.oliveira.32376@formandos.cinel.pt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(131, 229);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 40;
            label3.Text = "Autor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(131, 269);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 40;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(131, 309);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 40;
            label5.Text = "Data:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(221, 309);
            label6.Name = "label6";
            label6.Size = new Size(206, 23);
            label6.TabIndex = 40;
            label6.Text = "01 de Julho de 2024";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(131, 349);
            label7.Name = "label7";
            label7.Size = new Size(84, 23);
            label7.TabIndex = 40;
            label7.Text = "Versão:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(221, 349);
            label8.Name = "label8";
            label8.Size = new Size(37, 23);
            label8.TabIndex = 40;
            label8.Text = "1.0";
            // 
            // Creditos
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 474);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblId);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Brown;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Creditos";
            Text = "Créditos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}