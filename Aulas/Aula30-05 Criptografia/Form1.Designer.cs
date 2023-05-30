namespace Aula30_05_Criptografia
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
            lblMensagem = new Label();
            txbMensagem = new TextBox();
            btnCriptografar = new Button();
            lblCriptografada = new Label();
            lblMensagemCriptografada = new Label();
            btnDescriptografar = new Button();
            lblDescriptografada = new Label();
            lblMensagemDescriptografada = new Label();
            lblMensagemArquivo = new Label();
            lblArquivoDecodificado = new Label();
            txbMsgArquivo = new TextBox();
            txbMsgDecripto = new TextBox();
            labelSimetrica = new Label();
            labelAssimetrica = new Label();
            lblDescriptoAssimetrica = new Label();
            btnDescriptoAssimetrica = new Button();
            lblCriptoAssimetrica = new Label();
            btnCriptoAssimetrica = new Button();
            txbMsgAssimetrica = new TextBox();
            lblMsgAssimetrica = new Label();
            txbMsgDescriptoAssimetrica = new TextBox();
            txbMsgCriptoAssimetrica = new TextBox();
            btnDescriptografarArquivo = new Button();
            SuspendLayout();
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(17, 44);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(69, 15);
            lblMensagem.TabIndex = 0;
            lblMensagem.Text = "Mensagem:";
            // 
            // txbMensagem
            // 
            txbMensagem.Location = new Point(92, 40);
            txbMensagem.Name = "txbMensagem";
            txbMensagem.Size = new Size(191, 23);
            txbMensagem.TabIndex = 1;
            // 
            // btnCriptografar
            // 
            btnCriptografar.Location = new Point(289, 40);
            btnCriptografar.Name = "btnCriptografar";
            btnCriptografar.Size = new Size(109, 23);
            btnCriptografar.TabIndex = 2;
            btnCriptografar.Text = "Criptografar";
            btnCriptografar.UseVisualStyleBackColor = true;
            btnCriptografar.Click += btnCriptografar_Click;
            // 
            // lblCriptografada
            // 
            lblCriptografada.AutoSize = true;
            lblCriptografada.Location = new Point(12, 80);
            lblCriptografada.Name = "lblCriptografada";
            lblCriptografada.Size = new Size(83, 15);
            lblCriptografada.TabIndex = 3;
            lblCriptografada.Text = "Criptografada:";
            // 
            // lblMensagemCriptografada
            // 
            lblMensagemCriptografada.AutoSize = true;
            lblMensagemCriptografada.Location = new Point(101, 80);
            lblMensagemCriptografada.Name = "lblMensagemCriptografada";
            lblMensagemCriptografada.Size = new Size(66, 15);
            lblMensagemCriptografada.TabIndex = 4;
            lblMensagemCriptografada.Text = "Mensagem";
            // 
            // btnDescriptografar
            // 
            btnDescriptografar.Location = new Point(289, 76);
            btnDescriptografar.Name = "btnDescriptografar";
            btnDescriptografar.Size = new Size(109, 23);
            btnDescriptografar.TabIndex = 5;
            btnDescriptografar.Text = "Descriptografar";
            btnDescriptografar.UseVisualStyleBackColor = true;
            btnDescriptografar.Click += btnDescriptografar_Click;
            // 
            // lblDescriptografada
            // 
            lblDescriptografada.AutoSize = true;
            lblDescriptografada.Location = new Point(0, 119);
            lblDescriptografada.Name = "lblDescriptografada";
            lblDescriptografada.Size = new Size(100, 15);
            lblDescriptografada.TabIndex = 6;
            lblDescriptografada.Text = "Descriptografada:";
            // 
            // lblMensagemDescriptografada
            // 
            lblMensagemDescriptografada.AutoSize = true;
            lblMensagemDescriptografada.Location = new Point(106, 119);
            lblMensagemDescriptografada.Name = "lblMensagemDescriptografada";
            lblMensagemDescriptografada.Size = new Size(66, 15);
            lblMensagemDescriptografada.TabIndex = 7;
            lblMensagemDescriptografada.Text = "Mensagem";
            // 
            // lblMensagemArquivo
            // 
            lblMensagemArquivo.AutoSize = true;
            lblMensagemArquivo.Location = new Point(530, 9);
            lblMensagemArquivo.Name = "lblMensagemArquivo";
            lblMensagemArquivo.Size = new Size(129, 15);
            lblMensagemArquivo.TabIndex = 8;
            lblMensagemArquivo.Text = "Mensagem do arquivo:";
            // 
            // lblArquivoDecodificado
            // 
            lblArquivoDecodificado.AutoSize = true;
            lblArquivoDecodificado.Location = new Point(530, 90);
            lblArquivoDecodificado.Name = "lblArquivoDecodificado";
            lblArquivoDecodificado.Size = new Size(146, 15);
            lblArquivoDecodificado.TabIndex = 10;
            lblArquivoDecodificado.Text = "Arquivo Descriptografado:";
            // 
            // txbMsgArquivo
            // 
            txbMsgArquivo.Location = new Point(418, 27);
            txbMsgArquivo.Multiline = true;
            txbMsgArquivo.Name = "txbMsgArquivo";
            txbMsgArquivo.Size = new Size(370, 54);
            txbMsgArquivo.TabIndex = 12;
            // 
            // txbMsgDecripto
            // 
            txbMsgDecripto.Location = new Point(418, 108);
            txbMsgDecripto.Multiline = true;
            txbMsgDecripto.Name = "txbMsgDecripto";
            txbMsgDecripto.Size = new Size(370, 51);
            txbMsgDecripto.TabIndex = 13;
            // 
            // labelSimetrica
            // 
            labelSimetrica.AutoSize = true;
            labelSimetrica.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelSimetrica.Location = new Point(2, -2);
            labelSimetrica.Name = "labelSimetrica";
            labelSimetrica.Size = new Size(203, 28);
            labelSimetrica.TabIndex = 15;
            labelSimetrica.Text = "Criptografia Simétrica";
            // 
            // labelAssimetrica
            // 
            labelAssimetrica.AutoSize = true;
            labelAssimetrica.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelAssimetrica.Location = new Point(17, 178);
            labelAssimetrica.Name = "labelAssimetrica";
            labelAssimetrica.Size = new Size(221, 28);
            labelAssimetrica.TabIndex = 16;
            labelAssimetrica.Text = "Criptografia Assimétrica";
            // 
            // lblDescriptoAssimetrica
            // 
            lblDescriptoAssimetrica.AutoSize = true;
            lblDescriptoAssimetrica.Location = new Point(2, 366);
            lblDescriptoAssimetrica.Name = "lblDescriptoAssimetrica";
            lblDescriptoAssimetrica.Size = new Size(100, 15);
            lblDescriptoAssimetrica.TabIndex = 23;
            lblDescriptoAssimetrica.Text = "Descriptografada:";
            // 
            // btnDescriptoAssimetrica
            // 
            btnDescriptoAssimetrica.Location = new Point(530, 265);
            btnDescriptoAssimetrica.Name = "btnDescriptoAssimetrica";
            btnDescriptoAssimetrica.Size = new Size(109, 23);
            btnDescriptoAssimetrica.TabIndex = 22;
            btnDescriptoAssimetrica.Text = "Descriptografar";
            btnDescriptoAssimetrica.UseVisualStyleBackColor = true;
            btnDescriptoAssimetrica.Click += btnDescriptoAssimetrica_Click;
            // 
            // lblCriptoAssimetrica
            // 
            lblCriptoAssimetrica.AutoSize = true;
            lblCriptoAssimetrica.Location = new Point(17, 251);
            lblCriptoAssimetrica.Name = "lblCriptoAssimetrica";
            lblCriptoAssimetrica.Size = new Size(83, 15);
            lblCriptoAssimetrica.TabIndex = 20;
            lblCriptoAssimetrica.Text = "Criptografada:";
            // 
            // btnCriptoAssimetrica
            // 
            btnCriptoAssimetrica.Location = new Point(356, 209);
            btnCriptoAssimetrica.Name = "btnCriptoAssimetrica";
            btnCriptoAssimetrica.Size = new Size(109, 23);
            btnCriptoAssimetrica.TabIndex = 19;
            btnCriptoAssimetrica.Text = "Criptografar";
            btnCriptoAssimetrica.UseVisualStyleBackColor = true;
            btnCriptoAssimetrica.Click += btnCriptoAssimetrica_Click;
            // 
            // txbMsgAssimetrica
            // 
            txbMsgAssimetrica.Location = new Point(106, 209);
            txbMsgAssimetrica.Name = "txbMsgAssimetrica";
            txbMsgAssimetrica.Size = new Size(244, 23);
            txbMsgAssimetrica.TabIndex = 18;
            // 
            // lblMsgAssimetrica
            // 
            lblMsgAssimetrica.AutoSize = true;
            lblMsgAssimetrica.Location = new Point(31, 217);
            lblMsgAssimetrica.Name = "lblMsgAssimetrica";
            lblMsgAssimetrica.Size = new Size(69, 15);
            lblMsgAssimetrica.TabIndex = 17;
            lblMsgAssimetrica.Text = "Mensagem:";
            // 
            // txbMsgDescriptoAssimetrica
            // 
            txbMsgDescriptoAssimetrica.Location = new Point(108, 350);
            txbMsgDescriptoAssimetrica.Multiline = true;
            txbMsgDescriptoAssimetrica.Name = "txbMsgDescriptoAssimetrica";
            txbMsgDescriptoAssimetrica.Size = new Size(416, 61);
            txbMsgDescriptoAssimetrica.TabIndex = 26;
            // 
            // txbMsgCriptoAssimetrica
            // 
            txbMsgCriptoAssimetrica.Location = new Point(106, 238);
            txbMsgCriptoAssimetrica.Multiline = true;
            txbMsgCriptoAssimetrica.Name = "txbMsgCriptoAssimetrica";
            txbMsgCriptoAssimetrica.Size = new Size(418, 106);
            txbMsgCriptoAssimetrica.TabIndex = 25;
            // 
            // btnDescriptografarArquivo
            // 
            btnDescriptografarArquivo.Location = new Point(530, 165);
            btnDescriptografarArquivo.Name = "btnDescriptografarArquivo";
            btnDescriptografarArquivo.Size = new Size(155, 22);
            btnDescriptografarArquivo.TabIndex = 27;
            btnDescriptografarArquivo.Text = "Descriptografar Arquivo";
            btnDescriptografarArquivo.UseVisualStyleBackColor = true;
            btnDescriptografarArquivo.Click += btnDescriptografarArquivo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDescriptografarArquivo);
            Controls.Add(txbMsgDescriptoAssimetrica);
            Controls.Add(txbMsgCriptoAssimetrica);
            Controls.Add(lblDescriptoAssimetrica);
            Controls.Add(btnDescriptoAssimetrica);
            Controls.Add(lblCriptoAssimetrica);
            Controls.Add(btnCriptoAssimetrica);
            Controls.Add(txbMsgAssimetrica);
            Controls.Add(lblMsgAssimetrica);
            Controls.Add(labelAssimetrica);
            Controls.Add(labelSimetrica);
            Controls.Add(txbMsgDecripto);
            Controls.Add(txbMsgArquivo);
            Controls.Add(lblArquivoDecodificado);
            Controls.Add(lblMensagemArquivo);
            Controls.Add(lblMensagemDescriptografada);
            Controls.Add(lblDescriptografada);
            Controls.Add(btnDescriptografar);
            Controls.Add(lblMensagemCriptografada);
            Controls.Add(lblCriptografada);
            Controls.Add(btnCriptografar);
            Controls.Add(txbMensagem);
            Controls.Add(lblMensagem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensagem;
        private TextBox txbMensagem;
        private Button btnCriptografar;
        private Label lblCriptografada;
        private Label lblMensagemCriptografada;
        private Button btnDescriptografar;
        private Label lblDescriptografada;
        private Label lblMensagemDescriptografada;
        private Label lblMensagemArquivo;
        private Label lblArquivoDecodificado;
        private TextBox txbMsgArquivo;
        private TextBox txbMsgDecripto;
        private Label labelSimetrica;
        private Label labelAssimetrica;
        private Label lblDescriptoAssimetrica;
        private Button btnDescriptoAssimetrica;
        private Label lblCriptoAssimetrica;
        private Button btnCriptoAssimetrica;
        private TextBox txbMsgAssimetrica;
        private Label lblMsgAssimetrica;
        private TextBox txbMsgDescriptoAssimetrica;
        private TextBox txbMsgCriptoAssimetrica;
        private Button btnDescriptografarArquivo;
    }
}