namespace Telas_Software_Praticando
{
    partial class Cadastro_de_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_de_Funcionario));
            this.TextBox_Nome = new System.Windows.Forms.TextBox();
            this.TextBox_RG = new System.Windows.Forms.TextBox();
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.TextBox_CPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_Nome
            // 
            this.TextBox_Nome.Location = new System.Drawing.Point(12, 30);
            this.TextBox_Nome.Name = "TextBox_Nome";
            this.TextBox_Nome.Size = new System.Drawing.Size(308, 20);
            this.TextBox_Nome.TabIndex = 0;
            // 
            // TextBox_RG
            // 
            this.TextBox_RG.Location = new System.Drawing.Point(12, 73);
            this.TextBox_RG.Name = "TextBox_RG";
            this.TextBox_RG.Size = new System.Drawing.Size(100, 20);
            this.TextBox_RG.TabIndex = 1;
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.Location = new System.Drawing.Point(12, 186);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Email.TabIndex = 2;
            // 
            // TextBox_CPF
            // 
            this.TextBox_CPF.Location = new System.Drawing.Point(12, 117);
            this.TextBox_CPF.Name = "TextBox_CPF";
            this.TextBox_CPF.Size = new System.Drawing.Size(100, 20);
            this.TextBox_CPF.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome Completo";
            // 
            // Cadastro_de_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_CPF);
            this.Controls.Add(this.TextBox_Email);
            this.Controls.Add(this.TextBox_RG);
            this.Controls.Add(this.TextBox_Nome);
            this.Name = "Cadastro_de_Funcionario";
            this.Text = "Cadastro_de_Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Nome;
        private System.Windows.Forms.TextBox TextBox_RG;
        private System.Windows.Forms.TextBox TextBox_Email;
        private System.Windows.Forms.TextBox TextBox_CPF;
        private System.Windows.Forms.Label label1;
    }
}