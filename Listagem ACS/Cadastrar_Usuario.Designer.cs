namespace Listagem_ACS
{
    partial class Cadastrar_Usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.tx_Prontuario = new System.Windows.Forms.TextBox();
            this.tx_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.botao_sair = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar_toolstrip = new System.Windows.Forms.ToolStripProgressBar();
            this.label_toolstrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_CartaoSus = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Enderecos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_Numero = new System.Windows.Forms.TextBox();
            this.tx_Complemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botao_inserir = new System.Windows.Forms.Button();
            this.radio_Antigo = new System.Windows.Forms.RadioButton();
            this.radio_Novo = new System.Windows.Forms.RadioButton();
            this.tx_Bairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.botao_editar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tx_data = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tx_Microarea = new System.Windows.Forms.TextBox();
            this.tx_ACS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prontuário:";
            // 
            // tx_Prontuario
            // 
            this.tx_Prontuario.BackColor = System.Drawing.SystemColors.Info;
            this.tx_Prontuario.ForeColor = System.Drawing.Color.Black;
            this.tx_Prontuario.Location = new System.Drawing.Point(95, 9);
            this.tx_Prontuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tx_Prontuario.Name = "tx_Prontuario";
            this.tx_Prontuario.Size = new System.Drawing.Size(106, 22);
            this.tx_Prontuario.TabIndex = 1;            
            // 
            // tx_Nome
            // 
            this.tx_Nome.BackColor = System.Drawing.SystemColors.Info;
            this.tx_Nome.ForeColor = System.Drawing.Color.Black;
            this.tx_Nome.Location = new System.Drawing.Point(95, 40);
            this.tx_Nome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tx_Nome.Name = "tx_Nome";
            this.tx_Nome.Size = new System.Drawing.Size(380, 22);
            this.tx_Nome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone:";
            // 
            // tx_Telefone
            // 
            this.tx_Telefone.BackColor = System.Drawing.SystemColors.Info;
            this.tx_Telefone.ForeColor = System.Drawing.Color.Black;
            this.tx_Telefone.Location = new System.Drawing.Point(512, 96);
            this.tx_Telefone.Mask = "0000-0000";
            this.tx_Telefone.Name = "tx_Telefone";
            this.tx_Telefone.Size = new System.Drawing.Size(88, 22);
            this.tx_Telefone.TabIndex = 9;
            this.tx_Telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // botao_sair
            // 
            this.botao_sair.Location = new System.Drawing.Point(524, 172);
            this.botao_sair.Name = "botao_sair";
            this.botao_sair.Size = new System.Drawing.Size(102, 23);
            this.botao_sair.TabIndex = 12;
            this.botao_sair.Text = "Sair";
            this.botao_sair.UseVisualStyleBackColor = true;
            this.botao_sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar_toolstrip,
            this.label_toolstrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 213);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(736, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar_toolstrip
            // 
            this.progressBar_toolstrip.Name = "progressBar_toolstrip";
            this.progressBar_toolstrip.Size = new System.Drawing.Size(100, 16);
            // 
            // label_toolstrip
            // 
            this.label_toolstrip.Name = "label_toolstrip";
            this.label_toolstrip.Size = new System.Drawing.Size(66, 17);
            this.label_toolstrip.Text = "Gravando...";
            this.label_toolstrip.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "CNS:";
            // 
            // tx_CartaoSus
            // 
            this.tx_CartaoSus.BackColor = System.Drawing.Color.White;
            this.tx_CartaoSus.ForeColor = System.Drawing.Color.Black;
            this.tx_CartaoSus.Location = new System.Drawing.Point(402, 9);
            this.tx_CartaoSus.Mask = "000-0000-0000-0000";
            this.tx_CartaoSus.Name = "tx_CartaoSus";
            this.tx_CartaoSus.Size = new System.Drawing.Size(157, 22);
            this.tx_CartaoSus.TabIndex = 2;
            this.tx_CartaoSus.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Endereço:";
            // 
            // cb_Enderecos
            // 
            this.cb_Enderecos.ForeColor = System.Drawing.Color.Black;
            this.cb_Enderecos.FormattingEnabled = true;
            this.cb_Enderecos.Location = new System.Drawing.Point(95, 68);
            this.cb_Enderecos.Name = "cb_Enderecos";
            this.cb_Enderecos.Size = new System.Drawing.Size(490, 22);
            this.cb_Enderecos.TabIndex = 5;
            this.cb_Enderecos.SelectedIndexChanged += new System.EventHandler(this.cb_Enderecos_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Numero:";
            // 
            // tx_Numero
            // 
            this.tx_Numero.BackColor = System.Drawing.Color.White;
            this.tx_Numero.ForeColor = System.Drawing.Color.Black;
            this.tx_Numero.Location = new System.Drawing.Point(661, 71);
            this.tx_Numero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tx_Numero.Name = "tx_Numero";
            this.tx_Numero.Size = new System.Drawing.Size(63, 22);
            this.tx_Numero.TabIndex = 6;
            this.tx_Numero.TextChanged += new System.EventHandler(this.tx_Numero_TextChanged);
            // 
            // tx_Complemento
            // 
            this.tx_Complemento.BackColor = System.Drawing.Color.White;
            this.tx_Complemento.ForeColor = System.Drawing.Color.Black;
            this.tx_Complemento.Location = new System.Drawing.Point(370, 96);
            this.tx_Complemento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tx_Complemento.Name = "tx_Complemento";
            this.tx_Complemento.Size = new System.Drawing.Size(61, 22);
            this.tx_Complemento.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Comp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(38, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "Preenchimento obrigatório";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(11, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 17;
            // 
            // botao_inserir
            // 
            this.botao_inserir.Enabled = false;
            this.botao_inserir.Location = new System.Drawing.Point(308, 172);
            this.botao_inserir.Name = "botao_inserir";
            this.botao_inserir.Size = new System.Drawing.Size(102, 23);
            this.botao_inserir.TabIndex = 10;
            this.botao_inserir.Text = "Inserir";
            this.botao_inserir.UseVisualStyleBackColor = true;
            this.botao_inserir.Click += new System.EventHandler(this.button2_Click);
            // 
            // radio_Antigo
            // 
            this.radio_Antigo.AutoSize = true;
            this.radio_Antigo.Checked = true;
            this.radio_Antigo.Location = new System.Drawing.Point(208, 10);
            this.radio_Antigo.Name = "radio_Antigo";
            this.radio_Antigo.Size = new System.Drawing.Size(65, 18);
            this.radio_Antigo.TabIndex = 19;
            this.radio_Antigo.TabStop = true;
            this.radio_Antigo.Text = "Antigo";
            this.radio_Antigo.UseVisualStyleBackColor = true;
            this.radio_Antigo.CheckedChanged += new System.EventHandler(this.radio_Antigo_CheckedChanged);
            // 
            // radio_Novo
            // 
            this.radio_Novo.AutoSize = true;
            this.radio_Novo.Location = new System.Drawing.Point(279, 10);
            this.radio_Novo.Name = "radio_Novo";
            this.radio_Novo.Size = new System.Drawing.Size(57, 18);
            this.radio_Novo.TabIndex = 20;
            this.radio_Novo.Text = "Novo";
            this.radio_Novo.UseVisualStyleBackColor = true;
            // 
            // tx_Bairro
            // 
            this.tx_Bairro.BackColor = System.Drawing.Color.White;
            this.tx_Bairro.ForeColor = System.Drawing.Color.Black;
            this.tx_Bairro.Location = new System.Drawing.Point(95, 96);
            this.tx_Bairro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tx_Bairro.Name = "tx_Bairro";
            this.tx_Bairro.Size = new System.Drawing.Size(219, 22);
            this.tx_Bairro.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 21;
            this.label9.Text = "Bairro:";
            // 
            // botao_editar
            // 
            this.botao_editar.Enabled = false;
            this.botao_editar.Location = new System.Drawing.Point(416, 172);
            this.botao_editar.Name = "botao_editar";
            this.botao_editar.Size = new System.Drawing.Size(102, 23);
            this.botao_editar.TabIndex = 11;
            this.botao_editar.Text = "Editar";
            this.botao_editar.UseVisualStyleBackColor = true;
            this.botao_editar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 14);
            this.label10.TabIndex = 23;
            this.label10.Text = "Data de Nascimento:";
            // 
            // tx_data
            // 
            this.tx_data.BackColor = System.Drawing.SystemColors.Info;
            this.tx_data.ForeColor = System.Drawing.Color.Black;
            this.tx_data.Location = new System.Drawing.Point(633, 40);
            this.tx_data.Mask = "00/00/0000";
            this.tx_data.Name = "tx_data";
            this.tx_data.Size = new System.Drawing.Size(91, 22);
            this.tx_data.TabIndex = 4;
            this.tx_data.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 14);
            this.label11.TabIndex = 24;
            this.label11.Text = "Microárea:";
            // 
            // tx_Microarea
            // 
            this.tx_Microarea.BackColor = System.Drawing.Color.White;
            this.tx_Microarea.Location = new System.Drawing.Point(95, 125);
            this.tx_Microarea.Name = "tx_Microarea";
            this.tx_Microarea.ReadOnly = true;
            this.tx_Microarea.Size = new System.Drawing.Size(70, 22);
            this.tx_Microarea.TabIndex = 25;
            // 
            // tx_ACS
            // 
            this.tx_ACS.BackColor = System.Drawing.Color.White;
            this.tx_ACS.Location = new System.Drawing.Point(233, 125);
            this.tx_ACS.Name = "tx_ACS";
            this.tx_ACS.ReadOnly = true;
            this.tx_ACS.Size = new System.Drawing.Size(198, 22);
            this.tx_ACS.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(190, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 14);
            this.label12.TabIndex = 26;
            this.label12.Text = "ACS:";
            // 
            // Cadastrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(736, 235);
            this.ControlBox = false;
            this.Controls.Add(this.tx_ACS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tx_Microarea);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tx_data);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.botao_editar);
            this.Controls.Add(this.tx_Bairro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radio_Novo);
            this.Controls.Add(this.radio_Antigo);
            this.Controls.Add(this.botao_inserir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tx_Complemento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx_Numero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_Enderecos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_CartaoSus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.botao_sair);
            this.Controls.Add(this.tx_Telefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_Prontuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Cadastrar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar_Usuario";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_Prontuario;
        private System.Windows.Forms.TextBox tx_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tx_Telefone;
        private System.Windows.Forms.Button botao_sair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar_toolstrip;
        private System.Windows.Forms.ToolStripStatusLabel label_toolstrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tx_CartaoSus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Enderecos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_Numero;
        private System.Windows.Forms.TextBox tx_Complemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botao_inserir;
        private System.Windows.Forms.RadioButton radio_Antigo;
        private System.Windows.Forms.RadioButton radio_Novo;
        private System.Windows.Forms.TextBox tx_Bairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button botao_editar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox tx_data;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tx_Microarea;
        private System.Windows.Forms.TextBox tx_ACS;
        private System.Windows.Forms.Label label12;
    }
}