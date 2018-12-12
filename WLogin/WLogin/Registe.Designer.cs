namespace WLogin
{
    partial class btnRegisteRegiste
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegisteName = new System.Windows.Forms.TextBox();
            this.txtRegistePassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnegiste = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegistePassword2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // txtRegisteName
            // 
            this.txtRegisteName.Location = new System.Drawing.Point(179, 40);
            this.txtRegisteName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegisteName.Name = "txtRegisteName";
            this.txtRegisteName.Size = new System.Drawing.Size(132, 25);
            this.txtRegisteName.TabIndex = 1;
            // 
            // txtRegistePassword
            // 
            this.txtRegistePassword.Location = new System.Drawing.Point(179, 87);
            this.txtRegistePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistePassword.Name = "txtRegistePassword";
            this.txtRegistePassword.Size = new System.Drawing.Size(132, 25);
            this.txtRegistePassword.TabIndex = 2;
            this.txtRegistePassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "密   码：";
            // 
            // btnegiste
            // 
            this.btnegiste.Location = new System.Drawing.Point(146, 193);
            this.btnegiste.Margin = new System.Windows.Forms.Padding(4);
            this.btnegiste.Name = "btnegiste";
            this.btnegiste.Size = new System.Drawing.Size(100, 29);
            this.btnegiste.TabIndex = 4;
            this.btnegiste.Text = "注册";
            this.btnegiste.UseVisualStyleBackColor = true;
            this.btnegiste.Click += new System.EventHandler(this.btnegiste_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "确认密码：";
            // 
            // txtRegistePassword2
            // 
            this.txtRegistePassword2.Location = new System.Drawing.Point(179, 127);
            this.txtRegistePassword2.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistePassword2.Name = "txtRegistePassword2";
            this.txtRegistePassword2.Size = new System.Drawing.Size(132, 25);
            this.txtRegistePassword2.TabIndex = 6;
            this.txtRegistePassword2.UseSystemPasswordChar = true;
            // 
            // btnRegisteRegiste
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "btnRegisteRegiste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegisteName;
        private System.Windows.Forms.TextBox txtRegistePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnegiste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegistePassword2;
    }
}