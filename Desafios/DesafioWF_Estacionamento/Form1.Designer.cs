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
            labelTitulo = new Label();
            labelDia = new Label();
            labelHorario = new Label();
            textBoxDia = new TextBox();
            textBoxHorario = new TextBox();
            listBoxEntradaVeiculos = new ListBox();
            listBoxSaidaVeiculos = new ListBox();
            labelMes = new Label();
            textBoxMes = new TextBox();
            labelAno = new Label();
            textBoxAno = new TextBox();
            labelEntradaVeiculos = new Label();
            labelSaidaVeiculos = new Label();
            groupBox1 = new GroupBox();
            textBoxPlaca = new TextBox();
            label1 = new Label();
            btnEntrada = new Button();
            btnSaida = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(282, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(227, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Bem vindo ao sistema de estacionamento";
            // 
            // labelDia
            // 
            labelDia.AutoSize = true;
            labelDia.Location = new Point(33, 60);
            labelDia.Name = "labelDia";
            labelDia.Size = new Size(27, 15);
            labelDia.TabIndex = 1;
            labelDia.Text = "Dia:";
            // 
            // labelHorario
            // 
            labelHorario.AutoSize = true;
            labelHorario.Location = new Point(10, 147);
            labelHorario.Name = "labelHorario";
            labelHorario.Size = new Size(50, 15);
            labelHorario.TabIndex = 2;
            labelHorario.Text = "Horário:";
            // 
            // textBoxDia
            // 
            textBoxDia.Location = new Point(66, 57);
            textBoxDia.Name = "textBoxDia";
            textBoxDia.Size = new Size(100, 23);
            textBoxDia.TabIndex = 3;
            // 
            // textBoxHorario
            // 
            textBoxHorario.Location = new Point(66, 144);
            textBoxHorario.Name = "textBoxHorario";
            textBoxHorario.Size = new Size(100, 23);
            textBoxHorario.TabIndex = 4;
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
            // labelMes
            // 
            labelMes.AutoSize = true;
            labelMes.Location = new Point(28, 89);
            labelMes.Name = "labelMes";
            labelMes.Size = new Size(32, 15);
            labelMes.TabIndex = 7;
            labelMes.Text = "Mês:";
            // 
            // textBoxMes
            // 
            textBoxMes.Location = new Point(67, 86);
            textBoxMes.Name = "textBoxMes";
            textBoxMes.Size = new Size(100, 23);
            textBoxMes.TabIndex = 8;
            // 
            // labelAno
            // 
            labelAno.AutoSize = true;
            labelAno.Location = new Point(28, 118);
            labelAno.Name = "labelAno";
            labelAno.Size = new Size(32, 15);
            labelAno.TabIndex = 9;
            labelAno.Text = "Ano:";
            // 
            // textBoxAno
            // 
            textBoxAno.Location = new Point(67, 115);
            textBoxAno.Name = "textBoxAno";
            textBoxAno.Size = new Size(100, 23);
            textBoxAno.TabIndex = 10;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(labelEntradaVeiculos);
            groupBox1.Controls.Add(labelSaidaVeiculos);
            groupBox1.Controls.Add(listBoxEntradaVeiculos);
            groupBox1.Controls.Add(listBoxSaidaVeiculos);
            groupBox1.Location = new Point(363, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 426);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(66, 173);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(100, 23);
            textBoxPlaca.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 176);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 14;
            label1.Text = "Placa:";
            // 
            // btnEntrada
            // 
            btnEntrada.Location = new Point(38, 202);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(75, 23);
            btnEntrada.TabIndex = 16;
            btnEntrada.Text = "Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSaida
            // 
            btnSaida.Location = new Point(119, 202);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(75, 23);
            btnSaida.TabIndex = 17;
            btnSaida.Text = "Saida";
            btnSaida.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(800, 572);
            Controls.Add(btnSaida);
            Controls.Add(btnEntrada);
            Controls.Add(textBoxPlaca);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(textBoxAno);
            Controls.Add(labelAno);
            Controls.Add(textBoxMes);
            Controls.Add(labelMes);
            Controls.Add(textBoxHorario);
            Controls.Add(textBoxDia);
            Controls.Add(labelHorario);
            Controls.Add(labelDia);
            Controls.Add(labelTitulo);
            Name = "Form1";
            Text = "Gerenciador de Estacionamento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelDia;
        private Label labelHorario;
        private TextBox textBoxDia;
        private TextBox textBoxHorario;
        private ListBox listBoxEntradaVeiculos;
        private ListBox listBoxSaidaVeiculos;
        private Label labelMes;
        private TextBox textBoxMes;
        private Label labelAno;
        private TextBox textBoxAno;
        private Label labelEntradaVeiculos;
        private Label labelSaidaVeiculos;
        private GroupBox groupBox1;
        private TextBox textBoxPlaca;
        private Label label1;
        private Button btnEntrada;
        private Button btnSaida;
    }
}