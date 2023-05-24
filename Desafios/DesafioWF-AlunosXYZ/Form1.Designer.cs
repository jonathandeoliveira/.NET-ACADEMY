namespace DesafioWF_AlunosXYZ
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
            btnNomeArquivo = new Button();
            labelNomeArquivo = new Label();
            txtBoxNomeArquivo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnProcessarLista = new Button();
            listBoxListaPessoas = new ListBox();
            listBoxListaProcessada = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnNomeArquivo
            // 
            btnNomeArquivo.BackColor = SystemColors.Info;
            btnNomeArquivo.ForeColor = SystemColors.ControlText;
            btnNomeArquivo.Location = new Point(290, 50);
            btnNomeArquivo.Name = "btnNomeArquivo";
            btnNomeArquivo.Size = new Size(75, 23);
            btnNomeArquivo.TabIndex = 0;
            btnNomeArquivo.Text = "Procurar";
            btnNomeArquivo.UseVisualStyleBackColor = false;
            btnNomeArquivo.Click += btnNomeArquivo_Click;
            // 
            // labelNomeArquivo
            // 
            labelNomeArquivo.AutoSize = true;
            labelNomeArquivo.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeArquivo.Location = new Point(45, 51);
            labelNomeArquivo.Name = "labelNomeArquivo";
            labelNomeArquivo.Size = new Size(133, 18);
            labelNomeArquivo.TabIndex = 1;
            labelNomeArquivo.Text = "Nome do Arquivo:";
            // 
            // txtBoxNomeArquivo
            // 
            txtBoxNomeArquivo.Location = new Point(184, 50);
            txtBoxNomeArquivo.Name = "txtBoxNomeArquivo";
            txtBoxNomeArquivo.Size = new Size(100, 23);
            txtBoxNomeArquivo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 95);
            label2.Name = "label2";
            label2.Size = new Size(203, 18);
            label2.TabIndex = 3;
            label2.Text = "Lista de Pessoas Recebida:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(388, 95);
            label3.Name = "label3";
            label3.Size = new Size(143, 18);
            label3.TabIndex = 5;
            label3.Text = "Processando Lista:";
            // 
            // btnProcessarLista
            // 
            btnProcessarLista.BackColor = SystemColors.Info;
            btnProcessarLista.Location = new Point(126, 441);
            btnProcessarLista.Name = "btnProcessarLista";
            btnProcessarLista.Size = new Size(106, 23);
            btnProcessarLista.TabIndex = 7;
            btnProcessarLista.Text = "Processar Lista";
            btnProcessarLista.UseVisualStyleBackColor = false;
            btnProcessarLista.Click += btnProcessarLista_Click;
            // 
            // listBoxListaPessoas
            // 
            listBoxListaPessoas.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxListaPessoas.FormattingEnabled = true;
            listBoxListaPessoas.ItemHeight = 16;
            listBoxListaPessoas.Location = new Point(12, 116);
            listBoxListaPessoas.Name = "listBoxListaPessoas";
            listBoxListaPessoas.Size = new Size(318, 308);
            listBoxListaPessoas.TabIndex = 8;
            // 
            // listBoxListaProcessada
            // 
            listBoxListaProcessada.FormattingEnabled = true;
            listBoxListaProcessada.ItemHeight = 15;
            listBoxListaProcessada.Location = new Point(347, 116);
            listBoxListaProcessada.Name = "listBoxListaProcessada";
            listBoxListaProcessada.Size = new Size(318, 319);
            listBoxListaProcessada.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(403, 30);
            label1.TabIndex = 10;
            label1.Text = "Bem vindo ao Organizador de Arquivos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(807, 476);
            Controls.Add(label1);
            Controls.Add(listBoxListaProcessada);
            Controls.Add(listBoxListaPessoas);
            Controls.Add(btnProcessarLista);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxNomeArquivo);
            Controls.Add(labelNomeArquivo);
            Controls.Add(btnNomeArquivo);
            Name = "Form1";
            Text = "DesafioWF-AlunosXYZ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNomeArquivo;
        private Label labelNomeArquivo;
        private TextBox txtBoxNomeArquivo;
        private Label label2;
        private Label label3;
        private Button btnProcessarLista;
        private ListBox listBoxListaPessoas;
        private ListBox listBoxListaProcessada;
        private Label label1;
    }
}