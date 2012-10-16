namespace Listagem_ACS
{
    partial class GrindViewRua
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
            this.Grind_Ruas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Rua = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grind_Ruas)).BeginInit();
            this.SuspendLayout();
            // 
            // Grind_Ruas
            // 
            this.Grind_Ruas.AllowDrop = true;
            this.Grind_Ruas.AllowUserToAddRows = false;
            this.Grind_Ruas.AllowUserToDeleteRows = false;
            this.Grind_Ruas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grind_Ruas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.Grind_Ruas.Location = new System.Drawing.Point(13, 32);
            this.Grind_Ruas.Margin = new System.Windows.Forms.Padding(4);
            this.Grind_Ruas.Name = "Grind_Ruas";
            this.Grind_Ruas.Size = new System.Drawing.Size(618, 240);
            this.Grind_Ruas.TabIndex = 0;
            this.Grind_Ruas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grind_Ruas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column1.HeaderText = "Nome ACS";
            this.Column1.Name = "Column1";
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Column2.HeaderText = "Números";
            this.Column2.Name = "Column2";
            this.Column2.Width = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Endereço.:";
            // 
            // lb_Rua
            // 
            this.lb_Rua.AutoSize = true;
            this.lb_Rua.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_Rua.Location = new System.Drawing.Point(98, 9);
            this.lb_Rua.Name = "lb_Rua";
            this.lb_Rua.Size = new System.Drawing.Size(93, 19);
            this.lb_Rua.TabIndex = 2;
            this.lb_Rua.Text = "Rua Recebida";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GrindViewRua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(643, 311);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_Rua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grind_Ruas);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrindViewRua";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Consulta por Endereço :.";
            ((System.ComponentModel.ISupportInitialize)(this.Grind_Ruas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grind_Ruas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Rua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}