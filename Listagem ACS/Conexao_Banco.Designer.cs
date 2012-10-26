namespace Listagem_ACS
{
    partial class Conexao_Banco
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
            this.tx_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_todos = new System.Windows.Forms.Button();
            this.dtgrd_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_view)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_pesquisa
            // 
            this.tx_pesquisa.Location = new System.Drawing.Point(13, 25);
            this.tx_pesquisa.Name = "tx_pesquisa";
            this.tx_pesquisa.Size = new System.Drawing.Size(277, 20);
            this.tx_pesquisa.TabIndex = 1;
            // 
            // btn_todos
            // 
            this.btn_todos.Location = new System.Drawing.Point(377, 23);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(75, 23);
            this.btn_todos.TabIndex = 2;
            this.btn_todos.Text = "Todos";
            this.btn_todos.UseVisualStyleBackColor = true;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // dtgrd_view
            // 
            this.dtgrd_view.AllowUserToAddRows = false;
            this.dtgrd_view.AllowUserToDeleteRows = false;
            this.dtgrd_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgrd_view.Location = new System.Drawing.Point(12, 61);
            this.dtgrd_view.Name = "dtgrd_view";
            this.dtgrd_view.ReadOnly = true;
            this.dtgrd_view.Size = new System.Drawing.Size(547, 193);
            this.dtgrd_view.TabIndex = 3;
            // 
            // Conexao_Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 266);
            this.Controls.Add(this.dtgrd_view);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.tx_pesquisa);
            this.Name = "Conexao_Banco";
            this.Text = "Conexao_Banco";
            this.Load += new System.EventHandler(this.Conexao_Banco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_pesquisa;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.DataGridView dtgrd_view;
    }
}