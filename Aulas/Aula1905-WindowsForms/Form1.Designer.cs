namespace Aula1905_WindowsForms
{
    partial class FormPrincipal
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
            buttonGerarEmail = new Button();
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelSobrenome = new Label();
            textBoxSobrenome = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            textBoxListaEmails = new RichTextBox();
            buttonLimpar = new Button();
            SuspendLayout();
            // 
            // buttonGerarEmail
            // 
            buttonGerarEmail.BackColor = SystemColors.GradientActiveCaption;
            buttonGerarEmail.Location = new Point(12, 200);
            buttonGerarEmail.Name = "buttonGerarEmail";
            buttonGerarEmail.Size = new Size(286, 23);
            buttonGerarEmail.TabIndex = 0;
            buttonGerarEmail.Text = "Gerar Email";
            buttonGerarEmail.UseVisualStyleBackColor = false;
            buttonGerarEmail.Click += buttonGerarEmail_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 34);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.BackColor = SystemColors.Info;
            textBoxNome.Location = new Point(12, 52);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(286, 23);
            textBoxNome.TabIndex = 2;
            // 
            // labelSobrenome
            // 
            labelSobrenome.AutoSize = true;
            labelSobrenome.Location = new Point(12, 91);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(68, 15);
            labelSobrenome.TabIndex = 3;
            labelSobrenome.Text = "Sobrenome";
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.BackColor = SystemColors.Info;
            textBoxSobrenome.Location = new Point(12, 109);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(286, 23);
            textBoxSobrenome.TabIndex = 4;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 153);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = SystemColors.Info;
            textBoxEmail.Enabled = false;
            textBoxEmail.Location = new Point(12, 171);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(286, 23);
            textBoxEmail.TabIndex = 6;
            textBoxEmail.TabStop = false;
            // 
            // textBoxListaEmails
            // 
            textBoxListaEmails.BackColor = SystemColors.Info;
            textBoxListaEmails.Enabled = false;
            textBoxListaEmails.ForeColor = Color.Black;
            textBoxListaEmails.Location = new Point(348, 10);
            textBoxListaEmails.Name = "textBoxListaEmails";
            textBoxListaEmails.Size = new Size(210, 213);
            textBoxListaEmails.TabIndex = 7;
            textBoxListaEmails.Text = "";
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = SystemColors.GradientActiveCaption;
            buttonLimpar.Enabled = false;
            buttonLimpar.Location = new Point(12, 229);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(286, 23);
            buttonLimpar.TabIndex = 8;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = false;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 423);
            Controls.Add(buttonLimpar);
            Controls.Add(textBoxListaEmails);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxSobrenome);
            Controls.Add(labelSobrenome);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(buttonGerarEmail);
            Name = "FormPrincipal";
            Text = "Titulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGerarEmail;
        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelSobrenome;
        private TextBox textBoxSobrenome;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private RichTextBox textBoxListaEmails;
        private Button buttonLimpar;
    }
}