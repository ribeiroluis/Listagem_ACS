namespace Listagem_ACS
{
    partial class Movimento_Diario
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
            this.cb_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_medicos = new System.Windows.Forms.ComboBox();
            this.cb_horario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_prontuario = new System.Windows.Forms.TextBox();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grade_listview = new System.Windows.Forms.ListView();
            this.col_n = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_pront = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_medico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_date
            // 
            this.cb_date.Location = new System.Drawing.Point(15, 12);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(301, 23);
            this.cb_date.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Médico:";
            // 
            // cb_medicos
            // 
            this.cb_medicos.FormattingEnabled = true;
            this.cb_medicos.Location = new System.Drawing.Point(78, 50);
            this.cb_medicos.Name = "cb_medicos";
            this.cb_medicos.Size = new System.Drawing.Size(368, 24);
            this.cb_medicos.TabIndex = 2;
            this.cb_medicos.SelectedIndexChanged += new System.EventHandler(this.cb_medicos_SelectedIndexChanged);
            // 
            // cb_horario
            // 
            this.cb_horario.FormattingEnabled = true;
            this.cb_horario.Location = new System.Drawing.Point(530, 50);
            this.cb_horario.Name = "cb_horario";
            this.cb_horario.Size = new System.Drawing.Size(158, 24);
            this.cb_horario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prontuário:";
            // 
            // tx_prontuario
            // 
            this.tx_prontuario.Location = new System.Drawing.Point(99, 94);
            this.tx_prontuario.Name = "tx_prontuario";
            this.tx_prontuario.Size = new System.Drawing.Size(78, 23);
            this.tx_prontuario.TabIndex = 6;
            this.tx_prontuario.TextChanged += new System.EventHandler(this.tx_prontuario_TextChanged);
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(243, 94);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(445, 23);
            this.tx_nome.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome:";
            // 
            // grade_listview
            // 
            this.grade_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_n,
            this.col_pront,
            this.col_nome,
            this.col_hora,
            this.col_data,
            this.col_medico});
            this.grade_listview.FullRowSelect = true;
            this.grade_listview.GridLines = true;
            this.grade_listview.Location = new System.Drawing.Point(12, 175);
            this.grade_listview.Name = "grade_listview";
            this.grade_listview.Size = new System.Drawing.Size(684, 311);
            this.grade_listview.TabIndex = 9;
            this.grade_listview.UseCompatibleStateImageBehavior = false;
            this.grade_listview.View = System.Windows.Forms.View.Details;
            // 
            // col_n
            // 
            this.col_n.Text = "Nº";
            this.col_n.Width = 40;
            // 
            // col_pront
            // 
            this.col_pront.Text = "Prontuario";
            this.col_pront.Width = 80;
            // 
            // col_nome
            // 
            this.col_nome.Text = "Nome";
            this.col_nome.Width = 250;
            // 
            // col_hora
            // 
            this.col_hora.Text = "Hora";
            this.col_hora.Width = 80;
            // 
            // col_data
            // 
            this.col_data.Text = "Data";
            this.col_data.Width = 80;
            // 
            // col_medico
            // 
            this.col_medico.Text = "Médico";
            this.col_medico.Width = 150;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(530, 12);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 10;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(613, 12);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 11;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(621, 492);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_gravar.TabIndex = 12;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // Movimento_Diario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 526);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.grade_listview);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_prontuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_horario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_medicos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_date);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Movimento_Diario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimento_Diario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker cb_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_medicos;
        private System.Windows.Forms.ComboBox cb_horario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_prontuario;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView grade_listview;
        private System.Windows.Forms.ColumnHeader col_n;
        private System.Windows.Forms.ColumnHeader col_pront;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_hora;
        private System.Windows.Forms.ColumnHeader col_data;
        private System.Windows.Forms.ColumnHeader col_medico;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_gravar;
    }
}