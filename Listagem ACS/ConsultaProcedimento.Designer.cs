namespace Listagem_ACS
{
    partial class ConsultaProcedimento
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
            this.cb_Grupo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_FormasdeOrganizacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_subGrupo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tx_NomeProcedimento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_procedimento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lv_CodigoNome = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Grupo
            // 
            this.cb_Grupo.FormattingEnabled = true;
            this.cb_Grupo.Location = new System.Drawing.Point(177, 27);
            this.cb_Grupo.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Grupo.Name = "cb_Grupo";
            this.cb_Grupo.Size = new System.Drawing.Size(635, 24);
            this.cb_Grupo.TabIndex = 0;
            this.cb_Grupo.SelectedIndexChanged += new System.EventHandler(this.cb_Grupo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_FormasdeOrganizacao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_subGrupo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_Grupo);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(847, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estrutura";
            // 
            // cb_FormasdeOrganizacao
            // 
            this.cb_FormasdeOrganizacao.FormattingEnabled = true;
            this.cb_FormasdeOrganizacao.Location = new System.Drawing.Point(177, 94);
            this.cb_FormasdeOrganizacao.Margin = new System.Windows.Forms.Padding(4);
            this.cb_FormasdeOrganizacao.Name = "cb_FormasdeOrganizacao";
            this.cb_FormasdeOrganizacao.Size = new System.Drawing.Size(635, 24);
            this.cb_FormasdeOrganizacao.TabIndex = 5;
            this.cb_FormasdeOrganizacao.SelectedIndexChanged += new System.EventHandler(this.cb_FormasdeOrganizacao_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Forma de Organização:";
            // 
            // cb_subGrupo
            // 
            this.cb_subGrupo.FormattingEnabled = true;
            this.cb_subGrupo.Location = new System.Drawing.Point(177, 60);
            this.cb_subGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.cb_subGrupo.Name = "cb_subGrupo";
            this.cb_subGrupo.Size = new System.Drawing.Size(635, 24);
            this.cb_subGrupo.TabIndex = 3;
            this.cb_subGrupo.SelectedIndexChanged += new System.EventHandler(this.cb_subGrupo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sub-Grupo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grupo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tx_NomeProcedimento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tx_procedimento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 156);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(847, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procedimento";
            // 
            // tx_NomeProcedimento
            // 
            this.tx_NomeProcedimento.Location = new System.Drawing.Point(177, 61);
            this.tx_NomeProcedimento.Margin = new System.Windows.Forms.Padding(4);
            this.tx_NomeProcedimento.Name = "tx_NomeProcedimento";
            this.tx_NomeProcedimento.Size = new System.Drawing.Size(635, 23);
            this.tx_NomeProcedimento.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nome:";
            // 
            // tx_procedimento
            // 
            this.tx_procedimento.Location = new System.Drawing.Point(177, 30);
            this.tx_procedimento.Margin = new System.Windows.Forms.Padding(4);
            this.tx_procedimento.Name = "tx_procedimento";
            this.tx_procedimento.Size = new System.Drawing.Size(217, 23);
            this.tx_procedimento.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Procedimento:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(726, 287);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lv_CodigoNome
            // 
            this.lv_CodigoNome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_CodigoNome.FullRowSelect = true;
            this.lv_CodigoNome.GridLines = true;
            this.lv_CodigoNome.Location = new System.Drawing.Point(7, 322);
            this.lv_CodigoNome.Margin = new System.Windows.Forms.Padding(4);
            this.lv_CodigoNome.Name = "lv_CodigoNome";
            this.lv_CodigoNome.Size = new System.Drawing.Size(856, 275);
            this.lv_CodigoNome.TabIndex = 8;
            this.lv_CodigoNome.UseCompatibleStateImageBehavior = false;
            this.lv_CodigoNome.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 700;
            // 
            // ConsultaProcedimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 604);
            this.Controls.Add(this.lv_CodigoNome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultaProcedimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaProcedimento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Grupo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_FormasdeOrganizacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_subGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tx_NomeProcedimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_procedimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lv_CodigoNome;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}