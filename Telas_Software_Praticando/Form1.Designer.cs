namespace Telas_Software_Praticando
{
    partial class Menu_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Cadastros = new System.Windows.Forms.ComboBox();
            this.ComboBox_Estoque = new System.Windows.Forms.ComboBox();
            this.ComboBox_Caixa = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Cadastros
            // 
            this.comboBox_Cadastros.FormattingEnabled = true;
            this.comboBox_Cadastros.Location = new System.Drawing.Point(12, 12);
            this.comboBox_Cadastros.Name = "comboBox_Cadastros";
            this.comboBox_Cadastros.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Cadastros.TabIndex = 0;
            // 
            // ComboBox_Estoque
            // 
            this.ComboBox_Estoque.FormattingEnabled = true;
            this.ComboBox_Estoque.Location = new System.Drawing.Point(12, 131);
            this.ComboBox_Estoque.Name = "ComboBox_Estoque";
            this.ComboBox_Estoque.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Estoque.TabIndex = 1;
            // 
            // ComboBox_Caixa
            // 
            this.ComboBox_Caixa.FormattingEnabled = true;
            this.ComboBox_Caixa.Location = new System.Drawing.Point(12, 72);
            this.ComboBox_Caixa.Name = "ComboBox_Caixa";
            this.ComboBox_Caixa.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Caixa.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComboBox_Caixa);
            this.Controls.Add(this.ComboBox_Estoque);
            this.Controls.Add(this.comboBox_Cadastros);
            this.Name = "Menu_Principal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Cadastros;
        private System.Windows.Forms.ComboBox ComboBox_Estoque;
        private System.Windows.Forms.ComboBox ComboBox_Caixa;
        private System.Windows.Forms.Button button1;
    }
}

