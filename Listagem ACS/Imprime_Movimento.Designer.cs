namespace Listagem_ACS
{
    partial class Imprime_Movimento
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
            this.button1 = new System.Windows.Forms.Button();
            this.calen_date = new System.Windows.Forms.DateTimePicker();
            this.cb_medicos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calen_date
            // 
            this.calen_date.Location = new System.Drawing.Point(12, 21);
            this.calen_date.Name = "calen_date";
            this.calen_date.Size = new System.Drawing.Size(336, 23);
            this.calen_date.TabIndex = 3;
            // 
            // cb_medicos
            // 
            this.cb_medicos.FormattingEnabled = true;
            this.cb_medicos.Location = new System.Drawing.Point(12, 66);
            this.cb_medicos.Name = "cb_medicos";
            this.cb_medicos.Size = new System.Drawing.Size(336, 24);
            this.cb_medicos.TabIndex = 4;
            this.cb_medicos.SelectedIndexChanged += new System.EventHandler(this.cb_medicos_SelectedIndexChanged);
            // 
            // Imprime_Movimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 156);
            this.Controls.Add(this.cb_medicos);
            this.Controls.Add(this.calen_date);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Imprime_Movimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprime_Movimento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker calen_date;
        private System.Windows.Forms.ComboBox cb_medicos;

    }
}