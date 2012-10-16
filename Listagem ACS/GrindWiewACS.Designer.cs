namespace Listagem_ACS
{
    partial class GrindWiewACS
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
            this.DataGrindView_ACS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ACS_Recebido = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ENF_Recebido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrindView_ACS)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrindView_ACS
            // 
            this.DataGrindView_ACS.AllowUserToAddRows = false;
            this.DataGrindView_ACS.AllowUserToDeleteRows = false;
            this.DataGrindView_ACS.AllowUserToOrderColumns = true;
            this.DataGrindView_ACS.AllowUserToResizeRows = false;
            this.DataGrindView_ACS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrindView_ACS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataGrindView_ACS.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGrindView_ACS.Location = new System.Drawing.Point(15, 65);
            this.DataGrindView_ACS.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrindView_ACS.Name = "DataGrindView_ACS";
            this.DataGrindView_ACS.Size = new System.Drawing.Size(696, 265);
            this.DataGrindView_ACS.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column1.HeaderText = "Endereço";
            this.Column1.Name = "Column1";
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column2.HeaderText = "Nº";
            this.Column2.Name = "Column2";
            this.Column2.Width = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACS.:";
            // 
            // ACS_Recebido
            // 
            this.ACS_Recebido.AutoSize = true;
            this.ACS_Recebido.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACS_Recebido.Location = new System.Drawing.Point(57, 13);
            this.ACS_Recebido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ACS_Recebido.Name = "ACS_Recebido";
            this.ACS_Recebido.Size = new System.Drawing.Size(98, 19);
            this.ACS_Recebido.TabIndex = 2;
            this.ACS_Recebido.Text = "ACS Recebido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ENF_Recebido
            // 
            this.ENF_Recebido.AutoSize = true;
            this.ENF_Recebido.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENF_Recebido.Location = new System.Drawing.Point(118, 42);
            this.ENF_Recebido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ENF_Recebido.Name = "ENF_Recebido";
            this.ENF_Recebido.Size = new System.Drawing.Size(140, 19);
            this.ENF_Recebido.TabIndex = 5;
            this.ENF_Recebido.Text = "Enfermeiro Recebido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "ENFERMEIRO.:";
            // 
            // GrindWiewACS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(724, 372);
            this.ControlBox = false;
            this.Controls.Add(this.ENF_Recebido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ACS_Recebido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGrindView_ACS);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrindWiewACS";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Consulta Por ACS :.";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrindView_ACS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrindView_ACS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ACS_Recebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ENF_Recebido;
        private System.Windows.Forms.Label label3;
    }
}