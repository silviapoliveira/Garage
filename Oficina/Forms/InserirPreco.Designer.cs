namespace Oficina.Forms
{
    partial class InserirPreco
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
            lblTexto = new Label();
            txtPreco = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.Location = new Point(47, 32);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(350, 101);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Por favor insira o preço do serviço:";
            lblTexto.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(159, 165);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(125, 32);
            txtPreco.TabIndex = 1;
            txtPreco.TextAlign = HorizontalAlignment.Center;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Brown;
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(74, 288);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(120, 40);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Ok";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Brown;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(248, 288);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // InserirPreco
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(442, 362);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtPreco);
            Controls.Add(lblTexto);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Brown;
            Margin = new Padding(4, 3, 4, 3);
            Name = "InserirPreco";
            Text = "Inserir Preco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private TextBox txtPreco;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}