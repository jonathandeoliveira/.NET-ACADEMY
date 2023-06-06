namespace ExercicioCriptografia30_05
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
            lblUser = new Label();
            txbUser = new TextBox();
            txbPassword = new TextBox();
            lblPassword = new Label();
            btnChecar = new Button();
            btnCriptografar = new Button();
            txbCheckPassword = new TextBox();
            lblCheckPassword = new Label();
            txbCheckUser = new TextBox();
            lblCheckUser = new Label();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(12, 49);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 0;
            lblUser.Text = "Usuário";
            // 
            // txbUser
            // 
            txbUser.Location = new Point(65, 46);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(100, 23);
            txbUser.TabIndex = 1;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(65, 81);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(100, 23);
            txbPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 84);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(39, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Senha";
            // 
            // btnChecar
            // 
            btnChecar.Location = new Point(610, 53);
            btnChecar.Name = "btnChecar";
            btnChecar.Size = new Size(109, 23);
            btnChecar.TabIndex = 7;
            btnChecar.Text = "Descriptografar";
            btnChecar.UseVisualStyleBackColor = true;
            btnChecar.Click += btnChecar_Click;
            // 
            // btnCriptografar
            // 
            btnCriptografar.Location = new Point(224, 49);
            btnCriptografar.Name = "btnCriptografar";
            btnCriptografar.Size = new Size(109, 23);
            btnCriptografar.TabIndex = 6;
            btnCriptografar.Text = "Criptografar";
            btnCriptografar.UseVisualStyleBackColor = true;
            btnCriptografar.Click += btnCriptografar_Click;
            // 
            // txbCheckPassword
            // 
            txbCheckPassword.Location = new Point(504, 85);
            txbCheckPassword.Name = "txbCheckPassword";
            txbCheckPassword.Size = new Size(100, 23);
            txbCheckPassword.TabIndex = 11;
            // 
            // lblCheckPassword
            // 
            lblCheckPassword.AutoSize = true;
            lblCheckPassword.Location = new Point(459, 88);
            lblCheckPassword.Name = "lblCheckPassword";
            lblCheckPassword.Size = new Size(39, 15);
            lblCheckPassword.TabIndex = 10;
            lblCheckPassword.Text = "Senha";
            // 
            // txbCheckUser
            // 
            txbCheckUser.Location = new Point(504, 50);
            txbCheckUser.Name = "txbCheckUser";
            txbCheckUser.Size = new Size(100, 23);
            txbCheckUser.TabIndex = 9;
            // 
            // lblCheckUser
            // 
            lblCheckUser.AutoSize = true;
            lblCheckUser.Location = new Point(451, 53);
            lblCheckUser.Name = "lblCheckUser";
            lblCheckUser.Size = new Size(47, 15);
            lblCheckUser.TabIndex = 8;
            lblCheckUser.Text = "Usuário";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbCheckPassword);
            Controls.Add(lblCheckPassword);
            Controls.Add(txbCheckUser);
            Controls.Add(lblCheckUser);
            Controls.Add(btnChecar);
            Controls.Add(btnCriptografar);
            Controls.Add(txbPassword);
            Controls.Add(lblPassword);
            Controls.Add(txbUser);
            Controls.Add(lblUser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private TextBox txbUser;
        private TextBox txbPassword;
        private Label lblPassword;
        private Button btnChecar;
        private Button btnCriptografar;
        private TextBox txbCheckPassword;
        private Label lblCheckPassword;
        private TextBox txbCheckUser;
        private Label lblCheckUser;
    }
}