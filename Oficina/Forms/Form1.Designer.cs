namespace Oficina
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelLeft = new Panel();
            btnCreditos = new Button();
            panelSide = new Panel();
            btnFaturas = new Button();
            btnMarcacoes = new Button();
            btnServicos = new Button();
            btnFuncionarios = new Button();
            btnVeiculos = new Button();
            btnClientes = new Button();
            btnInicio = new Button();
            panel2 = new Panel();
            label2 = new Label();
            btnMenu = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnOff = new Button();
            panel4 = new Panel();
            labelTime = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timerTime = new System.Windows.Forms.Timer(components);
            panelControls = new Panel();
            panelLeft.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Brown;
            panelLeft.Controls.Add(btnCreditos);
            panelLeft.Controls.Add(panelSide);
            panelLeft.Controls.Add(btnFaturas);
            panelLeft.Controls.Add(btnMarcacoes);
            panelLeft.Controls.Add(btnServicos);
            panelLeft.Controls.Add(btnFuncionarios);
            panelLeft.Controls.Add(btnVeiculos);
            panelLeft.Controls.Add(btnClientes);
            panelLeft.Controls.Add(btnInicio);
            panelLeft.Controls.Add(panel2);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(215, 720);
            panelLeft.TabIndex = 0;
            // 
            // btnCreditos
            // 
            btnCreditos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreditos.AutoSize = true;
            btnCreditos.BackColor = Color.White;
            btnCreditos.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreditos.ForeColor = Color.Brown;
            btnCreditos.Location = new Point(24, 685);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Size = new Size(167, 26);
            btnCreditos.TabIndex = 44;
            btnCreditos.Text = "© Sílvia Oliveira, 2024";
            btnCreditos.UseVisualStyleBackColor = false;
            btnCreditos.Click += btnCreditos_Click;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.White;
            panelSide.Location = new Point(0, 162);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(5, 60);
            panelSide.TabIndex = 1;
            // 
            // btnFaturas
            // 
            btnFaturas.FlatAppearance.BorderSize = 0;
            btnFaturas.FlatStyle = FlatStyle.Flat;
            btnFaturas.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnFaturas.ForeColor = Color.White;
            btnFaturas.Image = (Image)resources.GetObject("btnFaturas.Image");
            btnFaturas.ImageAlign = ContentAlignment.MiddleLeft;
            btnFaturas.Location = new Point(11, 636);
            btnFaturas.Name = "btnFaturas";
            btnFaturas.Size = new Size(201, 60);
            btnFaturas.TabIndex = 3;
            btnFaturas.Text = "  Faturas";
            btnFaturas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFaturas.UseVisualStyleBackColor = true;
            btnFaturas.Click += btnFaturas_Click;
            // 
            // btnMarcacoes
            // 
            btnMarcacoes.FlatAppearance.BorderSize = 0;
            btnMarcacoes.FlatStyle = FlatStyle.Flat;
            btnMarcacoes.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnMarcacoes.ForeColor = Color.White;
            btnMarcacoes.Image = (Image)resources.GetObject("btnMarcacoes.Image");
            btnMarcacoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnMarcacoes.Location = new Point(11, 557);
            btnMarcacoes.Name = "btnMarcacoes";
            btnMarcacoes.Size = new Size(201, 60);
            btnMarcacoes.TabIndex = 3;
            btnMarcacoes.Text = "  Marcações";
            btnMarcacoes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMarcacoes.UseVisualStyleBackColor = true;
            btnMarcacoes.Click += btnMarcacoes_Click;
            // 
            // btnServicos
            // 
            btnServicos.FlatAppearance.BorderSize = 0;
            btnServicos.FlatStyle = FlatStyle.Flat;
            btnServicos.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnServicos.ForeColor = Color.White;
            btnServicos.Image = (Image)resources.GetObject("btnServicos.Image");
            btnServicos.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicos.Location = new Point(11, 478);
            btnServicos.Name = "btnServicos";
            btnServicos.Size = new Size(201, 60);
            btnServicos.TabIndex = 3;
            btnServicos.Text = "  Serviços";
            btnServicos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnServicos.UseVisualStyleBackColor = true;
            btnServicos.Click += btnServicos_Click;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.FlatAppearance.BorderSize = 0;
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFuncionarios.ForeColor = Color.White;
            btnFuncionarios.Image = (Image)resources.GetObject("btnFuncionarios.Image");
            btnFuncionarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionarios.Location = new Point(11, 399);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Size = new Size(201, 60);
            btnFuncionarios.TabIndex = 3;
            btnFuncionarios.Text = "  Funcionários";
            btnFuncionarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFuncionarios.UseVisualStyleBackColor = true;
            btnFuncionarios.Click += btnFuncionarios_Click;
            // 
            // btnVeiculos
            // 
            btnVeiculos.FlatAppearance.BorderSize = 0;
            btnVeiculos.FlatStyle = FlatStyle.Flat;
            btnVeiculos.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnVeiculos.ForeColor = Color.White;
            btnVeiculos.Image = (Image)resources.GetObject("btnVeiculos.Image");
            btnVeiculos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVeiculos.Location = new Point(11, 320);
            btnVeiculos.Name = "btnVeiculos";
            btnVeiculos.Size = new Size(201, 60);
            btnVeiculos.TabIndex = 3;
            btnVeiculos.Text = "  Veículos";
            btnVeiculos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVeiculos.UseVisualStyleBackColor = true;
            btnVeiculos.Click += btnVeiculos_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(11, 241);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(201, 60);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "  Clientes";
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnInicio
            // 
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnInicio.ForeColor = Color.White;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(11, 162);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(201, 60);
            btnInicio.TabIndex = 3;
            btnInicio.Text = "  Início";
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnMenu);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 140);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 91);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 0;
            label2.Text = "Garage 87";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMenu
            // 
            btnMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnMenu.ForeColor = Color.White;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(170, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(39, 47);
            btnMenu.TabIndex = 3;
            btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += button8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnOff);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(215, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(985, 50);
            panel3.TabIndex = 1;
            // 
            // btnOff
            // 
            btnOff.Dock = DockStyle.Right;
            btnOff.FlatAppearance.BorderSize = 0;
            btnOff.FlatAppearance.MouseOverBackColor = Color.Red;
            btnOff.FlatStyle = FlatStyle.Flat;
            btnOff.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnOff.ForeColor = Color.White;
            btnOff.Image = (Image)resources.GetObject("btnOff.Image");
            btnOff.Location = new Point(939, 0);
            btnOff.Name = "btnOff";
            btnOff.Size = new Size(46, 50);
            btnOff.TabIndex = 3;
            btnOff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOff.UseVisualStyleBackColor = true;
            btnOff.Click += button9_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Brown;
            panel4.Controls.Add(labelTime);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(215, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(985, 90);
            panel4.TabIndex = 2;
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(866, 34);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(106, 23);
            labelTime.TabIndex = 0;
            labelTime.Text = "HH:MM:SS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 34);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "Benvindo!";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timerTime
            // 
            timerTime.Tick += timerTime_Tick;
            // 
            // panelControls
            // 
            panelControls.Anchor = AnchorStyles.None;
            panelControls.Location = new Point(215, 140);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(985, 580);
            panelControls.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panelControls);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panelLeft);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panel2;
        private Button btnInicio;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Panel panelSide;
        private Label label2;
        private Button btnFaturas;
        private Button btnMarcacoes;
        private Button btnServicos;
        private Button btnFuncionarios;
        private Button btnVeiculos;
        private Button btnClientes;
        private Button btnMenu;
        private Button btnOff;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTime;
        private Panel panelControls;
        private Button btnCreditos;
    }
}
