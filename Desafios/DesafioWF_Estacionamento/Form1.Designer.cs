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
            textBoxPlaca = new TextBox();
            label1 = new Label();
            btnEntrada = new Button();
            btnSaida = new Button();
            labelHoraRelogio = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            labelDataRelogio = new Label();
            label2 = new Label();
            groupBoxListasVeiculos = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
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
            listBoxEntradaVeiculos.Location = new Point(0, 56);
            listBoxEntradaVeiculos.Name = "listBoxEntradaVeiculos";
            listBoxEntradaVeiculos.Size = new Size(176, 364);
            listBoxEntradaVeiculos.TabIndex = 5;
            // 
            // listBoxSaidaVeiculos
            // 
            listBoxSaidaVeiculos.FormattingEnabled = true;
            listBoxSaidaVeiculos.ItemHeight = 15;
            listBoxSaidaVeiculos.Location = new Point(208, 58);
            listBoxSaidaVeiculos.Name = "listBoxSaidaVeiculos";
            listBoxSaidaVeiculos.Size = new Size(333, 364);
            listBoxSaidaVeiculos.TabIndex = 6;
            // 
            // labelEntradaVeiculos
            // 
            labelEntradaVeiculos.AutoSize = true;
            labelEntradaVeiculos.Location = new Point(43, 6);
            labelEntradaVeiculos.Name = "labelEntradaVeiculos";
            labelEntradaVeiculos.Size = new Size(93, 15);
            labelEntradaVeiculos.TabIndex = 11;
            labelEntradaVeiculos.Text = "Lista de Entrada:";
            // 
            // labelSaidaVeiculos
            // 
            labelSaidaVeiculos.AutoSize = true;
            labelSaidaVeiculos.Location = new Point(373, 5);
            labelSaidaVeiculos.Name = "labelSaidaVeiculos";
            labelSaidaVeiculos.Size = new Size(81, 15);
            labelSaidaVeiculos.TabIndex = 12;
            labelSaidaVeiculos.Text = "Lista de Saída:";
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
            btnSaida.Click += btnSaida_Click;
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
            // groupBoxListasVeiculos
            // 
            groupBoxListasVeiculos.Controls.Add(label9);
            groupBoxListasVeiculos.Controls.Add(label8);
            groupBoxListasVeiculos.Controls.Add(label7);
            groupBoxListasVeiculos.Controls.Add(label6);
            groupBoxListasVeiculos.Controls.Add(label5);
            groupBoxListasVeiculos.Controls.Add(label4);
            groupBoxListasVeiculos.Controls.Add(label3);
            groupBoxListasVeiculos.Controls.Add(labelEntradaVeiculos);
            groupBoxListasVeiculos.Controls.Add(labelSaidaVeiculos);
            groupBoxListasVeiculos.Controls.Add(listBoxEntradaVeiculos);
            groupBoxListasVeiculos.Controls.Add(listBoxSaidaVeiculos);
            groupBoxListasVeiculos.Location = new Point(192, 71);
            groupBoxListasVeiculos.Name = "groupBoxListasVeiculos";
            groupBoxListasVeiculos.Size = new Size(607, 435);
            groupBoxListasVeiculos.TabIndex = 13;
            groupBoxListasVeiculos.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(447, 40);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 19;
            label9.Text = "Valor(R$):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(215, 40);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 18;
            label8.Text = "Placa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 40);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 17;
            label7.Text = "Horário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 40);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 16;
            label6.Text = "Permanencia (mins):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 40);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 15;
            label5.Text = "Horário:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 40);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 14;
            label4.Text = "Data:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 40);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 13;
            label3.Text = "Placa:";
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
        private TextBox textBoxPlaca;
        private Label label1;
        private Button btnEntrada;
        private Button btnSaida;
        private Label labelHoraRelogio;
        private System.Windows.Forms.Timer timer1;
        private Label labelDataRelogio;
        private Label label2;
        private GroupBox groupBoxListasVeiculos;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
    }
}