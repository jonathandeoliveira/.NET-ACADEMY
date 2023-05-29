namespace Aula29_05_Serializacao
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            labelSerializarBinario = new Label();
            textBoxNome = new TextBox();
            textBoxIdade = new TextBox();
            textBoxSalario = new TextBox();
            labelNome = new Label();
            labelIdade = new Label();
            labelSalario = new Label();
            btnSrlzXML = new Button();
            btnDslrXML = new Button();
            label2 = new Label();
            labelSalarioDeserialize = new Label();
            labelNomeDeserialize = new Label();
            labelIdadeDeserialize = new Label();
            label3 = new Label();
            btnDesserializaJSON = new Button();
            btnSerializeJSON = new Button();
            btnDeserializeSOAP = new Button();
            btnSerializeSOAP = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(157, 58);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 0;
            button1.Text = "Serializar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 95);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(157, 87);
            button2.Name = "button2";
            button2.Size = new Size(86, 23);
            button2.TabIndex = 3;
            button2.Text = "Desserializar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelSerializarBinario
            // 
            labelSerializarBinario.AutoSize = true;
            labelSerializarBinario.Location = new Point(145, 31);
            labelSerializarBinario.Name = "labelSerializarBinario";
            labelSerializarBinario.Size = new Size(113, 15);
            labelSerializarBinario.TabIndex = 4;
            labelSerializarBinario.Text = "Serializar em Binário";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(348, 58);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 5;
            // 
            // textBoxIdade
            // 
            textBoxIdade.Location = new Point(348, 87);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(100, 23);
            textBoxIdade.TabIndex = 6;
            // 
            // textBoxSalario
            // 
            textBoxSalario.Location = new Point(348, 116);
            textBoxSalario.Name = "textBoxSalario";
            textBoxSalario.Size = new Size(100, 23);
            textBoxSalario.TabIndex = 7;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(304, 62);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 8;
            labelNome.Text = "Nome";
            // 
            // labelIdade
            // 
            labelIdade.AutoSize = true;
            labelIdade.Location = new Point(304, 91);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(36, 15);
            labelIdade.TabIndex = 9;
            labelIdade.Text = "Idade";
            // 
            // labelSalario
            // 
            labelSalario.AutoSize = true;
            labelSalario.Location = new Point(304, 119);
            labelSalario.Name = "labelSalario";
            labelSalario.Size = new Size(42, 15);
            labelSalario.TabIndex = 10;
            labelSalario.Text = "Salario";
            // 
            // btnSrlzXML
            // 
            btnSrlzXML.Location = new Point(469, 58);
            btnSrlzXML.Name = "btnSrlzXML";
            btnSrlzXML.Size = new Size(86, 23);
            btnSrlzXML.TabIndex = 11;
            btnSrlzXML.Text = "Serializar";
            btnSrlzXML.UseVisualStyleBackColor = true;
            btnSrlzXML.Click += btnSrlzXML_Click;
            // 
            // btnDslrXML
            // 
            btnDslrXML.Location = new Point(469, 95);
            btnDslrXML.Name = "btnDslrXML";
            btnDslrXML.Size = new Size(86, 23);
            btnDslrXML.TabIndex = 12;
            btnDslrXML.Text = "Desserializar";
            btnDslrXML.UseVisualStyleBackColor = true;
            btnDslrXML.Click += btnDslrXML_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 31);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 13;
            label2.Text = "Serializar em XML";
            // 
            // labelSalarioDeserialize
            // 
            labelSalarioDeserialize.AutoSize = true;
            labelSalarioDeserialize.Location = new Point(377, 197);
            labelSalarioDeserialize.Name = "labelSalarioDeserialize";
            labelSalarioDeserialize.Size = new Size(42, 15);
            labelSalarioDeserialize.TabIndex = 14;
            labelSalarioDeserialize.Text = "Salario";
            // 
            // labelNomeDeserialize
            // 
            labelNomeDeserialize.AutoSize = true;
            labelNomeDeserialize.Location = new Point(377, 142);
            labelNomeDeserialize.Name = "labelNomeDeserialize";
            labelNomeDeserialize.Size = new Size(40, 15);
            labelNomeDeserialize.TabIndex = 15;
            labelNomeDeserialize.Text = "Nome";
            // 
            // labelIdadeDeserialize
            // 
            labelIdadeDeserialize.AutoSize = true;
            labelIdadeDeserialize.Location = new Point(377, 168);
            labelIdadeDeserialize.Name = "labelIdadeDeserialize";
            labelIdadeDeserialize.Size = new Size(36, 15);
            labelIdadeDeserialize.TabIndex = 16;
            labelIdadeDeserialize.Text = "Idade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(578, 31);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 19;
            label3.Text = "Serializar em JSON";
            // 
            // btnDesserializaJSON
            // 
            btnDesserializaJSON.Location = new Point(591, 95);
            btnDesserializaJSON.Name = "btnDesserializaJSON";
            btnDesserializaJSON.Size = new Size(86, 23);
            btnDesserializaJSON.TabIndex = 18;
            btnDesserializaJSON.Text = "Desserializar";
            btnDesserializaJSON.UseVisualStyleBackColor = true;
            btnDesserializaJSON.Click += btnDesserializaJSON_Click;
            // 
            // btnSerializeJSON
            // 
            btnSerializeJSON.Location = new Point(591, 58);
            btnSerializeJSON.Name = "btnSerializeJSON";
            btnSerializeJSON.Size = new Size(86, 23);
            btnSerializeJSON.TabIndex = 17;
            btnSerializeJSON.Text = "Serializar";
            btnSerializeJSON.UseVisualStyleBackColor = true;
            btnSerializeJSON.Click += btnSerializeJSON_Click;
            // 
            // btnDeserializeSOAP
            // 
            btnDeserializeSOAP.Location = new Point(712, 94);
            btnDeserializeSOAP.Name = "btnDeserializeSOAP";
            btnDeserializeSOAP.Size = new Size(86, 23);
            btnDeserializeSOAP.TabIndex = 21;
            btnDeserializeSOAP.Text = "Desserializar";
            btnDeserializeSOAP.UseVisualStyleBackColor = true;
            btnDeserializeSOAP.Click += btnDeserializeSOAP_Click;
            // 
            // btnSerializeSOAP
            // 
            btnSerializeSOAP.Location = new Point(712, 57);
            btnSerializeSOAP.Name = "btnSerializeSOAP";
            btnSerializeSOAP.Size = new Size(86, 23);
            btnSerializeSOAP.TabIndex = 20;
            btnSerializeSOAP.Text = "Serializar";
            btnSerializeSOAP.UseVisualStyleBackColor = true;
            btnSerializeSOAP.Click += btnSerializeSOAP_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(712, 31);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 22;
            label4.Text = "Serializar em SOAP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1070, 240);
            Controls.Add(label4);
            Controls.Add(btnDeserializeSOAP);
            Controls.Add(btnSerializeSOAP);
            Controls.Add(label3);
            Controls.Add(btnDesserializaJSON);
            Controls.Add(btnSerializeJSON);
            Controls.Add(labelIdadeDeserialize);
            Controls.Add(labelNomeDeserialize);
            Controls.Add(labelSalarioDeserialize);
            Controls.Add(label2);
            Controls.Add(btnDslrXML);
            Controls.Add(btnSrlzXML);
            Controls.Add(labelSalario);
            Controls.Add(labelIdade);
            Controls.Add(labelNome);
            Controls.Add(textBoxSalario);
            Controls.Add(textBoxIdade);
            Controls.Add(textBoxNome);
            Controls.Add(labelSerializarBinario);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Label labelSerializarBinario;
        private TextBox textBoxNome;
        private TextBox textBoxIdade;
        private TextBox textBoxSalario;
        private Label labelNome;
        private Label labelIdade;
        private Label labelSalario;
        private Button btnSrlzXML;
        private Button btnDslrXML;
        private Label label2;
        private Label labelSalarioDeserialize;
        private Label labelNomeDeserialize;
        private Label labelIdadeDeserialize;
        private Label label3;
        private Button btnDesserializaJSON;
        private Button btnSerializeJSON;
        private Button btnDeserializeSOAP;
        private Button btnSerializeSOAP;
        private Label label4;
    }
}