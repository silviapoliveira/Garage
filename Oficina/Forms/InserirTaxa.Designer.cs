namespace Oficina.Forms
{
    partial class InserirTaxa
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
            btnConfirmar = new Button();
            txtTaxa = new TextBox();
            lblTexto = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Brown;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(248, 291);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Brown;
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(74, 291);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(120, 40);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Ok";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtTaxa
            // 
            txtTaxa.Location = new Point(159, 168);
            txtTaxa.Name = "txtTaxa";
            txtTaxa.Size = new Size(125, 32);
            txtTaxa.TabIndex = 5;
            txtTaxa.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTexto
            // 
            lblTexto.Location = new Point(47, 32);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(335, 101);
            lblTexto.TabIndex = 4;
            lblTexto.Text = "Por favor insira a taxa do serviço:";
            lblTexto.TextAlign = ContentAlignment.TopCenter;
            // 
            // InserirTaxa
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(442, 362);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtTaxa);
            Controls.Add(lblTexto);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Brown;
            Margin = new Padding(4, 3, 4, 3);
            Name = "InserirTaxa";
            Text = "Inserir Taxa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnConfirmar;
        private TextBox txtTaxa;
        private Label lblTexto;
    }
}