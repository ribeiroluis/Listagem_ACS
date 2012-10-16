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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Painel_RegistraMovimento = new System.Windows.Forms.Panel();
            this.DataGrind_Registro = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radio_novo = new System.Windows.Forms.RadioButton();
            this.radio_Antigo = new System.Windows.Forms.RadioButton();
            this.cb_Horas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.date_DataConsulta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Medicos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_Prontuario = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar_tollstrip = new System.Windows.Forms.ToolStripProgressBar();
            this.label_tollstrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Painel_RegistraMovimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrind_Registro)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Painel_RegistraMovimento
            // 
            this.Painel_RegistraMovimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Painel_RegistraMovimento.Controls.Add(this.DataGrind_Registro);
            this.Painel_RegistraMovimento.Controls.Add(this.radio_novo);
            this.Painel_RegistraMovimento.Controls.Add(this.radio_Antigo);
            this.Painel_RegistraMovimento.Controls.Add(this.cb_Horas);
            this.Painel_RegistraMovimento.Controls.Add(this.label5);
            this.Painel_RegistraMovimento.Controls.Add(this.button3);
            this.Painel_RegistraMovimento.Controls.Add(this.button2);
            this.Painel_RegistraMovimento.Controls.Add(this.button1);
            this.Painel_RegistraMovimento.Controls.Add(this.label4);
            this.Painel_RegistraMovimento.Controls.Add(this.date_DataConsulta);
            this.Painel_RegistraMovimento.Controls.Add(this.label3);
            this.Painel_RegistraMovimento.Controls.Add(this.cb_Medicos);
            this.Painel_RegistraMovimento.Controls.Add(this.label2);
            this.Painel_RegistraMovimento.Controls.Add(this.tx_Nome);
            this.Painel_RegistraMovimento.Controls.Add(this.label1);
            this.Painel_RegistraMovimento.Controls.Add(this.tx_Prontuario);
            this.Painel_RegistraMovimento.Controls.Add(this.shapeContainer1);
            this.Painel_RegistraMovimento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Painel_RegistraMovimento.Location = new System.Drawing.Point(185, 5);
            this.Painel_RegistraMovimento.Name = "Painel_RegistraMovimento";
            this.Painel_RegistraMovimento.Size = new System.Drawing.Size(721, 493);
            this.Painel_RegistraMovimento.TabIndex = 0;
            this.Painel_RegistraMovimento.Visible = false;
            // 
            // DataGrind_Registro
            // 
            this.DataGrind_Registro.AllowUserToAddRows = false;
            this.DataGrind_Registro.AllowUserToDeleteRows = false;
            this.DataGrind_Registro.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGrind_Registro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DataGrind_Registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrind_Registro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DataGrind_Registro.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGrind_Registro.Location = new System.Drawing.Point(6, 156);
            this.DataGrind_Registro.Name = "DataGrind_Registro";
            this.DataGrind_Registro.ReadOnly = true;
            this.DataGrind_Registro.Size = new System.Drawing.Size(704, 330);
            this.DataGrind_Registro.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Prontuario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 69;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Medico";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 79;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Data";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 64;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "Hora";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 63;
            // 
            // radio_novo
            // 
            this.radio_novo.AutoSize = true;
            this.radio_novo.Location = new System.Drawing.Point(287, 4);
            this.radio_novo.Name = "radio_novo";
            this.radio_novo.Size = new System.Drawing.Size(64, 20);
            this.radio_novo.TabIndex = 17;
            this.radio_novo.Text = "NOVO";
            this.radio_novo.UseVisualStyleBackColor = true;
            // 
            // radio_Antigo
            // 
            this.radio_Antigo.AutoSize = true;
            this.radio_Antigo.Checked = true;
            this.radio_Antigo.Location = new System.Drawing.Point(204, 4);
            this.radio_Antigo.Name = "radio_Antigo";
            this.radio_Antigo.Size = new System.Drawing.Size(77, 20);
            this.radio_Antigo.TabIndex = 16;
            this.radio_Antigo.TabStop = true;
            this.radio_Antigo.Text = "ANTIGO";
            this.radio_Antigo.UseVisualStyleBackColor = true;
            // 
            // cb_Horas
            // 
            this.cb_Horas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Horas.FormattingEnabled = true;
            this.cb_Horas.Items.AddRange(new object[] {
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00"});
            this.cb_Horas.Location = new System.Drawing.Point(153, 86);
            this.cb_Horas.Name = "cb_Horas";
            this.cb_Horas.Size = new System.Drawing.Size(127, 24);
            this.cb_Horas.Sorted = true;
            this.cb_Horas.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hora:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(82, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Inserir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(557, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data:";
            // 
            // date_DataConsulta
            // 
            this.date_DataConsulta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_DataConsulta.Location = new System.Drawing.Point(324, 87);
            this.date_DataConsulta.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.date_DataConsulta.Name = "date_DataConsulta";
            this.date_DataConsulta.Size = new System.Drawing.Size(298, 23);
            this.date_DataConsulta.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Médico:";
            // 
            // cb_Medicos
            // 
            this.cb_Medicos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Medicos.FormattingEnabled = true;
            this.cb_Medicos.Items.AddRange(new object[] {
            "ALEXSSANDRO",
            "ARTUR",
            "JACKELYNE",
            "JOSE CARLOS",
            "JOSE HELVECIO",
            "MARGARIDA",
            "ROSANGELA",
            "SILVANA"});
            this.cb_Medicos.Location = new System.Drawing.Point(3, 86);
            this.cb_Medicos.Name = "cb_Medicos";
            this.cb_Medicos.Size = new System.Drawing.Size(127, 24);
            this.cb_Medicos.Sorted = true;
            this.cb_Medicos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // tx_Nome
            // 
            this.tx_Nome.BackColor = System.Drawing.Color.White;
            this.tx_Nome.Cursor = System.Windows.Forms.Cursors.No;
            this.tx_Nome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Nome.ForeColor = System.Drawing.Color.Black;
            this.tx_Nome.Location = new System.Drawing.Point(90, 31);
            this.tx_Nome.Name = "tx_Nome";
            this.tx_Nome.ReadOnly = true;
            this.tx_Nome.Size = new System.Drawing.Size(461, 23);
            this.tx_Nome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prontuário:";
            // 
            // tx_Prontuario
            // 
            this.tx_Prontuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Prontuario.Location = new System.Drawing.Point(90, 3);
            this.tx_Prontuario.Name = "tx_Prontuario";
            this.tx_Prontuario.Size = new System.Drawing.Size(100, 23);
            this.tx_Prontuario.TabIndex = 2;
            this.tx_Prontuario.TextChanged += new System.EventHandler(this.tx_Prontuario_TextChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(717, 489);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 4;
            this.lineShape2.X2 = 700;
            this.lineShape2.Y1 = 146;
            this.lineShape2.Y2 = 146;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 5;
            this.lineShape1.X2 = 702;
            this.lineShape1.Y1 = 61;
            this.lineShape1.Y2 = 62;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar_tollstrip,
            this.label_tollstrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(915, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar_tollstrip
            // 
            this.progressBar_tollstrip.Name = "progressBar_tollstrip";
            this.progressBar_tollstrip.Size = new System.Drawing.Size(100, 16);
            // 
            // label_tollstrip
            // 
            this.label_tollstrip.Name = "label_tollstrip";
            this.label_tollstrip.Size = new System.Drawing.Size(19, 17);
            this.label_tollstrip.Text = "...";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 500);
            this.panel2.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(6, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "CADASTRAR USUARIO";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "REGISTRA MOVIMENTO";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Movimento_Diario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 523);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Painel_RegistraMovimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Movimento_Diario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimento_Diario";
            this.Painel_RegistraMovimento.ResumeLayout(false);
            this.Painel_RegistraMovimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrind_Registro)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Painel_RegistraMovimento;
        private System.Windows.Forms.TextBox tx_Prontuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar_tollstrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Medicos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_DataConsulta;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_Horas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripStatusLabel label_tollstrip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radio_novo;
        private System.Windows.Forms.RadioButton radio_Antigo;
        private System.Windows.Forms.DataGridView DataGrind_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

    }
}