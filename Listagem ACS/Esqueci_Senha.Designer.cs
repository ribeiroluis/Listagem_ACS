namespace Listagem_ACS
{
    partial class Esqueci_Senha
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
            this.tx_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_SenhaNova = new System.Windows.Forms.TextBox();
            this.tx_ConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_NomeCPF = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_CPF
            // 
            this.tx_CPF.Location = new System.Drawing.Point(14, 25);
            this.tx_CPF.Mask = "000,000,000-00";
            this.tx_CPF.Name = "tx_CPF";
            this.tx_CPF.Size = new System.Drawing.Size(121, 21);
            this.tx_CPF.TabIndex = 0;
            this.tx_CPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o CPF:";
            // 
            // tx_SenhaNova
            // 
            this.tx_SenhaNova.Location = new System.Drawing.Point(12, 104);
            this.tx_SenhaNova.Name = "tx_SenhaNova";
            this.tx_SenhaNova.PasswordChar = '*';
            this.tx_SenhaNova.Size = new System.Drawing.Size(123, 21);
            this.tx_SenhaNova.TabIndex = 2;
            // 
            // tx_ConfirmarSenha
            // 
            this.tx_ConfirmarSenha.Location = new System.Drawing.Point(12, 144);
            this.tx_ConfirmarSenha.Name = "tx_ConfirmarSenha";
            this.tx_ConfirmarSenha.PasswordChar = '*';
            this.tx_ConfirmarSenha.Size = new System.Drawing.Size(123, 21);
            this.tx_ConfirmarSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nova senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar senha:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_NomeCPF
            // 
            this.lb_NomeCPF.AutoSize = true;
            this.lb_NomeCPF.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomeCPF.ForeColor = System.Drawing.Color.Red;
            this.lb_NomeCPF.Location = new System.Drawing.Point(15, 58);
            this.lb_NomeCPF.Name = "lb_NomeCPF";
            this.lb_NomeCPF.Size = new System.Drawing.Size(52, 16);
            this.lb_NomeCPF.TabIndex = 8;
            this.lb_NomeCPF.Text = "label4";
            this.lb_NomeCPF.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "ok!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Esqueci_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 179);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lb_NomeCPF);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_ConfirmarSenha);
            this.Controls.Add(this.tx_SenhaNova);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_CPF);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Esqueci_Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esqueci_Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tx_CPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_SenhaNova;
        private System.Windows.Forms.TextBox tx_ConfirmarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_NomeCPF;
        private System.Windows.Forms.Button button3;
    }
}