namespace WindowsForm.views
{
    partial class FmPessoa
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
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.textBEmail = new System.Windows.Forms.TextBox();
            this.textBEndereco = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBCod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(36, 66);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(479, 20);
            this.txtbNome.TabIndex = 0;
            // 
            // textBEmail
            // 
            this.textBEmail.Location = new System.Drawing.Point(36, 142);
            this.textBEmail.Name = "textBEmail";
            this.textBEmail.Size = new System.Drawing.Size(479, 20);
            this.textBEmail.TabIndex = 1;
            // 
            // textBEndereco
            // 
            this.textBEndereco.Location = new System.Drawing.Point(36, 102);
            this.textBEndereco.Name = "textBEndereco";
            this.textBEndereco.Size = new System.Drawing.Size(479, 20);
            this.textBEndereco.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Endereco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-mail";
            // 
            // textBCod
            // 
            this.textBCod.Location = new System.Drawing.Point(415, 23);
            this.textBCod.Name = "textBCod";
            this.textBCod.Size = new System.Drawing.Size(100, 20);
            this.textBCod.TabIndex = 8;
            this.textBCod.Visible = false;
            // 
            // FmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 260);
            this.Controls.Add(this.textBCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBEndereco);
            this.Controls.Add(this.textBEmail);
            this.Controls.Add(this.txtbNome);
            this.Name = "FmPessoa";
            this.Text = "Manutenção de Pessoa";
            this.Load += new System.EventHandler(this.FmPessoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.TextBox textBEmail;
        private System.Windows.Forms.TextBox textBEndereco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBCod;
    }
}