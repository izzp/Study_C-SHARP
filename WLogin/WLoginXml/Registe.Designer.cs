namespace WLoginXml
{
    partial class Registe
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
            this.txtRegistePassword2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnegiste = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegistePassword = new System.Windows.Forms.TextBox();
            this.txtRegisteName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRegistePassword2
            // 
            this.txtRegistePassword2.Location = new System.Drawing.Point(185, 128);
            this.txtRegistePassword2.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistePassword2.Name = "txtRegistePassword2";
            this.txtRegistePassword2.Size = new System.Drawing.Size(132, 25);
            this.txtRegistePassword2.TabIndex = 13;
            this.txtRegistePassword2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "确认密码：";
            // 
            // btnegiste
            // 
            this.btnegiste.Location = new System.Drawing.Point(158, 189);
            this.btnegiste.Margin = new System.Windows.Forms.Padding(4);
            this.btnegiste.Name = "btnegiste";
            this.btnegiste.Size = new System.Drawing.Size(100, 29);
            this.btnegiste.TabIndex = 11;
            this.btnegiste.Text = "注册";
            this.btnegiste.UseVisualStyleBackColor = true;
            this.btnegiste.Click += new System.EventHandler(this.btnegiste_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "密   码：";
            // 
            // txtRegistePassword
            // 
            this.txtRegistePassword.Location = new System.Drawing.Point(185, 88);
            this.txtRegistePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistePassword.Name = "txtRegistePassword";
            this.txtRegistePassword.Size = new System.Drawing.Size(132, 25);
            this.txtRegistePassword.TabIndex = 9;
            this.txtRegistePassword.UseSystemPasswordChar = true;
            // 
            // txtRegisteName
            // 
            this.txtRegisteName.Location = new System.Drawing.Point(185, 41);
            this.txtRegisteName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegisteName.Name = "txtRegisteName";
            this.txtRegisteName.Size = new System.Drawing.Size(132, 25);
            this.txtRegisteName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "用户名：";
            // 
            // Registe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.txtRegistePassword2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnegiste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegistePassword);
            this.Controls.Add(this.txtRegisteName);
            this.Controls.Add(this.label1);
            this.Name = "Registe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegistePassword2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnegiste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegistePassword;
        private System.Windows.Forms.TextBox txtRegisteName;
        private System.Windows.Forms.Label label1;
    }
}