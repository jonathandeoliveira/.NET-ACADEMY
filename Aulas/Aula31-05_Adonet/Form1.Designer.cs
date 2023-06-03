namespace Aula31_05_Adonet
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
            btnTodos = new Button();
            txbQueryNome = new TextBox();
            dataGridView1 = new DataGridView();
            btnFiltrar = new Button();
            txbNome = new TextBox();
            lblNome = new Label();
            label2 = new Label();
            txbProfissao = new TextBox();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            labelProfissaoExcluir = new Label();
            txbProfissaoExcluir = new TextBox();
            labelNomeExcluir = new Label();
            txbNomeExcluir = new TextBox();
            btnAtualiar = new Button();
            lblProfissaoAtualizar = new Label();
            txbProfissaoAtualizar = new TextBox();
            lblNomeAtualizar = new Label();
            txbNomeAtualizar = new TextBox();
            lblIdAtualizar = new Label();
            txbIdAtualizar = new TextBox();
            lblIdExcluir = new Label();
            txbIdExcluir = new TextBox();
            lblNomeDataReader = new Label();
            txbDataReader = new TextBox();
            btnDataReader = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(23, 70);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(117, 20);
            btnTodos.TabIndex = 0;
            btnTodos.Text = "Consultar Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // txbQueryNome
            // 
            txbQueryNome.Location = new Point(23, 12);
            txbQueryNome.Name = "txbQueryNome";
            txbQueryNome.Size = new Size(158, 23);
            txbQueryNome.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(199, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(344, 178);
            dataGridView1.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(23, 41);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(23, 233);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(96, 23);
            txbNome.TabIndex = 4;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(23, 215);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 262);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Profissão:";
            // 
            // txbProfissao
            // 
            txbProfissao.Location = new Point(23, 280);
            txbProfissao.Name = "txbProfissao";
            txbProfissao.Size = new Size(96, 23);
            txbProfissao.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(23, 309);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(142, 359);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // labelProfissaoExcluir
            // 
            labelProfissaoExcluir.AutoSize = true;
            labelProfissaoExcluir.Location = new Point(142, 262);
            labelProfissaoExcluir.Name = "labelProfissaoExcluir";
            labelProfissaoExcluir.Size = new Size(58, 15);
            labelProfissaoExcluir.TabIndex = 12;
            labelProfissaoExcluir.Text = "Profissão:";
            // 
            // txbProfissaoExcluir
            // 
            txbProfissaoExcluir.Location = new Point(142, 280);
            txbProfissaoExcluir.Name = "txbProfissaoExcluir";
            txbProfissaoExcluir.Size = new Size(96, 23);
            txbProfissaoExcluir.TabIndex = 11;
            // 
            // labelNomeExcluir
            // 
            labelNomeExcluir.AutoSize = true;
            labelNomeExcluir.Location = new Point(142, 215);
            labelNomeExcluir.Name = "labelNomeExcluir";
            labelNomeExcluir.Size = new Size(43, 15);
            labelNomeExcluir.TabIndex = 10;
            labelNomeExcluir.Text = "Nome:";
            // 
            // txbNomeExcluir
            // 
            txbNomeExcluir.Location = new Point(142, 233);
            txbNomeExcluir.Name = "txbNomeExcluir";
            txbNomeExcluir.Size = new Size(96, 23);
            txbNomeExcluir.TabIndex = 9;
            // 
            // btnAtualiar
            // 
            btnAtualiar.Location = new Point(255, 359);
            btnAtualiar.Name = "btnAtualiar";
            btnAtualiar.Size = new Size(75, 23);
            btnAtualiar.TabIndex = 18;
            btnAtualiar.Text = "Atualizar";
            btnAtualiar.UseVisualStyleBackColor = true;
            btnAtualiar.Click += btnAtualiar_Click;
            // 
            // lblProfissaoAtualizar
            // 
            lblProfissaoAtualizar.AutoSize = true;
            lblProfissaoAtualizar.Location = new Point(255, 262);
            lblProfissaoAtualizar.Name = "lblProfissaoAtualizar";
            lblProfissaoAtualizar.Size = new Size(58, 15);
            lblProfissaoAtualizar.TabIndex = 17;
            lblProfissaoAtualizar.Text = "Profissão:";
            // 
            // txbProfissaoAtualizar
            // 
            txbProfissaoAtualizar.Location = new Point(255, 280);
            txbProfissaoAtualizar.Name = "txbProfissaoAtualizar";
            txbProfissaoAtualizar.Size = new Size(96, 23);
            txbProfissaoAtualizar.TabIndex = 16;
            // 
            // lblNomeAtualizar
            // 
            lblNomeAtualizar.AutoSize = true;
            lblNomeAtualizar.Location = new Point(255, 215);
            lblNomeAtualizar.Name = "lblNomeAtualizar";
            lblNomeAtualizar.Size = new Size(43, 15);
            lblNomeAtualizar.TabIndex = 15;
            lblNomeAtualizar.Text = "Nome:";
            // 
            // txbNomeAtualizar
            // 
            txbNomeAtualizar.Location = new Point(255, 233);
            txbNomeAtualizar.Name = "txbNomeAtualizar";
            txbNomeAtualizar.Size = new Size(96, 23);
            txbNomeAtualizar.TabIndex = 14;
            // 
            // lblIdAtualizar
            // 
            lblIdAtualizar.AutoSize = true;
            lblIdAtualizar.Location = new Point(255, 312);
            lblIdAtualizar.Name = "lblIdAtualizar";
            lblIdAtualizar.Size = new Size(21, 15);
            lblIdAtualizar.TabIndex = 22;
            lblIdAtualizar.Text = "ID:";
            // 
            // txbIdAtualizar
            // 
            txbIdAtualizar.Location = new Point(255, 330);
            txbIdAtualizar.Name = "txbIdAtualizar";
            txbIdAtualizar.Size = new Size(96, 23);
            txbIdAtualizar.TabIndex = 21;
            // 
            // lblIdExcluir
            // 
            lblIdExcluir.AutoSize = true;
            lblIdExcluir.Location = new Point(142, 312);
            lblIdExcluir.Name = "lblIdExcluir";
            lblIdExcluir.Size = new Size(21, 15);
            lblIdExcluir.TabIndex = 20;
            lblIdExcluir.Text = "ID:";
            // 
            // txbIdExcluir
            // 
            txbIdExcluir.Location = new Point(142, 330);
            txbIdExcluir.Name = "txbIdExcluir";
            txbIdExcluir.Size = new Size(96, 23);
            txbIdExcluir.TabIndex = 19;
            // 
            // lblNomeDataReader
            // 
            lblNomeDataReader.AutoSize = true;
            lblNomeDataReader.Location = new Point(676, 215);
            lblNomeDataReader.Name = "lblNomeDataReader";
            lblNomeDataReader.Size = new Size(21, 15);
            lblNomeDataReader.TabIndex = 25;
            lblNomeDataReader.Text = "ID:";
            // 
            // txbDataReader
            // 
            txbDataReader.Location = new Point(676, 233);
            txbDataReader.Name = "txbDataReader";
            txbDataReader.Size = new Size(96, 23);
            txbDataReader.TabIndex = 24;
            // 
            // btnDataReader
            // 
            btnDataReader.Location = new Point(676, 262);
            btnDataReader.Name = "btnDataReader";
            btnDataReader.Size = new Size(75, 23);
            btnDataReader.TabIndex = 23;
            btnDataReader.Text = "DR Filtrar";
            btnDataReader.UseVisualStyleBackColor = true;
            btnDataReader.Click += btnDataReader_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNomeDataReader);
            Controls.Add(txbDataReader);
            Controls.Add(btnDataReader);
            Controls.Add(lblIdAtualizar);
            Controls.Add(txbIdAtualizar);
            Controls.Add(lblIdExcluir);
            Controls.Add(txbIdExcluir);
            Controls.Add(btnAtualiar);
            Controls.Add(lblProfissaoAtualizar);
            Controls.Add(txbProfissaoAtualizar);
            Controls.Add(lblNomeAtualizar);
            Controls.Add(txbNomeAtualizar);
            Controls.Add(btnExcluir);
            Controls.Add(labelProfissaoExcluir);
            Controls.Add(txbProfissaoExcluir);
            Controls.Add(labelNomeExcluir);
            Controls.Add(txbNomeExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(label2);
            Controls.Add(txbProfissao);
            Controls.Add(lblNome);
            Controls.Add(txbNome);
            Controls.Add(btnFiltrar);
            Controls.Add(dataGridView1);
            Controls.Add(txbQueryNome);
            Controls.Add(btnTodos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTodos;
        private TextBox txbQueryNome;
        private DataGridView dataGridView1;
        private Button btnFiltrar;
        private TextBox txbNome;
        private Label lblNome;
        private Label label2;
        private TextBox txbProfissao;
        private Button btnCadastrar;
        private Button btnExcluir;
        private Label labelProfissaoExcluir;
        private TextBox txbProfissaoExcluir;
        private Label labelNomeExcluir;
        private TextBox txbNomeExcluir;
        private Button btnAtualiar;
        private Label lblProfissaoAtualizar;
        private TextBox txbProfissaoAtualizar;
        private Label lblNomeAtualizar;
        private TextBox txbNomeAtualizar;
        private Label lblIdAtualizar;
        private TextBox txbIdAtualizar;
        private Label lblIdExcluir;
        private TextBox txbIdExcluir;
        private Label lblNomeDataReader;
        private TextBox txbDataReader;
        private Button btnDataReader;
    }
}