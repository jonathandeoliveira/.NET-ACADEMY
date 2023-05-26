namespace DesafioWF_Estacionamento
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
            labelTitulo = new Label();
            listBoxEntradaVeiculos = new ListBox();
            listBoxSaidaVeiculos = new ListBox();
            labelEntradaVeiculos = new Label();
            labelSaidaVeiculos = new Label();
            groupBoxListasVeiculos = new GroupBox();
            textBoxPlaca = new TextBox();
            label1 = new Label();
            btnEntrada = new Button();
            btnSaida = new Button();
            labelHoraRelogio = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            labelDataRelogio = new Label();
            label2 = new Label();
            groupBoxListasVeiculos.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelTitulo.Location = new Point(235, 28);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(487, 34);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Bem vindo ao sistema de estacionamento";
            // 
            // listBoxEntradaVeiculos
            // 
            listBoxEntradaVeiculos.FormattingEnabled = true;
            listBoxEntradaVeiculos.ItemHeight = 15;
            listBoxEntradaVeiculos.Location = new Point(0, 37);
            listBoxEntradaVeiculos.Name = "listBoxEntradaVeiculos";
            listBoxEntradaVeiculos.Size = new Size(207, 379);
            listBoxEntradaVeiculos.TabIndex = 5;
            // 
            // listBoxSaidaVeiculos
            // 
            listBoxSaidaVeiculos.FormattingEnabled = true;
            listBoxSaidaVeiculos.ItemHeight = 15;
            listBoxSaidaVeiculos.Location = new Point(219, 37);
            listBoxSaidaVeiculos.Name = "listBoxSaidaVeiculos";
            listBoxSaidaVeiculos.Size = new Size(207, 379);
            listBoxSaidaVeiculos.TabIndex = 6;
            // 
            // labelEntradaVeiculos
            // 
            labelEntradaVeiculos.AutoSize = true;
            labelEntradaVeiculos.Location = new Point(39, 19);
            labelEntradaVeiculos.Name = "labelEntradaVeiculos";
            labelEntradaVeiculos.Size = new Size(93, 15);
            labelEntradaVeiculos.TabIndex = 11;
            labelEntradaVeiculos.Text = "Lista de Entrada:";
            // 
            // labelSaidaVeiculos
            // 
            labelSaidaVeiculos.AutoSize = true;
            labelSaidaVeiculos.Location = new Point(257, 19);
            labelSaidaVeiculos.Name = "labelSaidaVeiculos";
            labelSaidaVeiculos.Size = new Size(81, 15);
            labelSaidaVeiculos.TabIndex = 12;
            labelSaidaVeiculos.Text = "Lista de Saída:";
            // 
            // groupBoxListasVeiculos
            // 
            groupBoxListasVeiculos.Controls.Add(labelEntradaVeiculos);
            groupBoxListasVeiculos.Controls.Add(labelSaidaVeiculos);
            groupBoxListasVeiculos.Controls.Add(listBoxEntradaVeiculos);
            groupBoxListasVeiculos.Controls.Add(listBoxSaidaVeiculos);
            groupBoxListasVeiculos.Location = new Point(244, 92);
            groupBoxListasVeiculos.Name = "groupBoxListasVeiculos";
            groupBoxListasVeiculos.Size = new Size(425, 426);
            groupBoxListasVeiculos.TabIndex = 13;
            groupBoxListasVeiculos.TabStop = false;
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(57, 189);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(100, 23);
            textBoxPlaca.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 192);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 14;
            label1.Text = "Placa:";
            // 
            // btnEntrada
            // 
            btnEntrada.Location = new Point(21, 218);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(75, 23);
            btnEntrada.TabIndex = 16;
            btnEntrada.Text = "Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSaida
            // 
            btnSaida.Location = new Point(111, 218);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(75, 23);
            btnSaida.TabIndex = 17;
            btnSaida.Text = "Saida";
            btnSaida.UseVisualStyleBackColor = true;
            // 
            // labelHoraRelogio
            // 
            labelHoraRelogio.AutoSize = true;
            labelHoraRelogio.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelHoraRelogio.Location = new Point(48, 93);
            labelHoraRelogio.Name = "labelHoraRelogio";
            labelHoraRelogio.Size = new Size(109, 37);
            labelHoraRelogio.TabIndex = 18;
            labelHoraRelogio.Text = "relógio ";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // labelDataRelogio
            // 
            labelDataRelogio.AutoSize = true;
            labelDataRelogio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataRelogio.Location = new Point(48, 71);
            labelDataRelogio.MaximumSize = new Size(100, 50);
            labelDataRelogio.Name = "labelDataRelogio";
            labelDataRelogio.Size = new Size(99, 21);
            labelDataRelogio.TabIndex = 19;
            labelDataRelogio.Text = "Data Relógio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 171);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 20;
            label2.Text = "Cadastrar no Sistema:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(800, 572);
            Controls.Add(label2);
            Controls.Add(labelDataRelogio);
            Controls.Add(labelHoraRelogio);
            Controls.Add(btnSaida);
            Controls.Add(btnEntrada);
            Controls.Add(textBoxPlaca);
            Controls.Add(label1);
            Controls.Add(groupBoxListasVeiculos);
            Controls.Add(labelTitulo);
            Name = "Form1";
            Text = "Gerenciador de Estacionamento";
            Load += Form1_Load;
            groupBoxListasVeiculos.ResumeLayout(false);
            groupBoxListasVeiculos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private ListBox listBoxEntradaVeiculos;
        private ListBox listBoxSaidaVeiculos;
        private Label labelEntradaVeiculos;
        private Label labelSaidaVeiculos;
        private GroupBox groupBoxListasVeiculos;
        private TextBox textBoxPlaca;
        private Label label1;
        private Button btnEntrada;
        private Button btnSaida;
        private Label labelHoraRelogio;
        private System.Windows.Forms.Timer timer1;
        private Label labelDataRelogio;
        private Label label2;
    }
}