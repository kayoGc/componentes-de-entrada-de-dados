
namespace componentes_de_entrada_de_dados
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.op1 = new System.Windows.Forms.RadioButton();
            this.op2 = new System.Windows.Forms.RadioButton();
            this.op3 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(25, 138);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(145, 20);
            this.txtCPF.TabIndex = 0;
            this.txtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCPF_MaskInputRejected);
            // 
            // txtEstado
            // 
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.txtEstado.Location = new System.Drawing.Point(25, 217);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(145, 21);
            this.txtEstado.TabIndex = 1;
            this.txtEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F);
            this.lblNome.Location = new System.Drawing.Point(21, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(145, 22);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Digite Seu Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F);
            this.txtNome.Location = new System.Drawing.Point(25, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(131, 27);
            this.txtNome.TabIndex = 4;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F);
            this.lblCPF.Location = new System.Drawing.Point(22, 101);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(134, 22);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "Digite Seu CPF";
            this.lblCPF.Click += new System.EventHandler(this.lblCPF_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F);
            this.lblEstado.Location = new System.Drawing.Point(21, 180);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(156, 22);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Qual Seu Estado?";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.op3);
            this.groupBox.Controls.Add(this.op2);
            this.groupBox.Controls.Add(this.op1);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.9F);
            this.groupBox.Location = new System.Drawing.Point(26, 257);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 130);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Estado Civil";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Location = new System.Drawing.Point(17, 24);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(96, 22);
            this.op1.TabIndex = 0;
            this.op1.TabStop = true;
            this.op1.Text = "Casado(a)";
            this.op1.UseVisualStyleBackColor = true;
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Location = new System.Drawing.Point(17, 47);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(95, 22);
            this.op2.TabIndex = 1;
            this.op2.TabStop = true;
            this.op2.Text = "Solteiro(a)";
            this.op2.UseVisualStyleBackColor = true;
            // 
            // op3
            // 
            this.op3.AutoSize = true;
            this.op3.Location = new System.Drawing.Point(17, 70);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(80, 22);
            this.op3.TabIndex = 2;
            this.op3.TabStop = true;
            this.op3.Text = "Viuvo(a)";
            this.op3.UseVisualStyleBackColor = true;
            this.op3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(402, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCPF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton op3;
        private System.Windows.Forms.RadioButton op2;
        private System.Windows.Forms.RadioButton op1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

