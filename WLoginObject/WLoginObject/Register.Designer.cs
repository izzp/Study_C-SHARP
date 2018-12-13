namespace WLoginObject
{
    partial class Register
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
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtRegistePassword2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnegiste = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegistePassword = new System.Windows.Forms.TextBox();
            this.txtRegisteName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(127, 106);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(126, 21);
            this.txtMail.TabIndex = 24;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(52, 109);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(65, 12);
            this.lblMail.TabIndex = 23;
            this.lblMail.Text = "电子邮箱：";
            // 
            // txtRegistePassword2
            // 
            this.txtRegistePassword2.Location = new System.Drawing.Point(127, 80);
            this.txtRegistePassword2.Name = "txtRegistePassword2";
            this.txtRegistePassword2.Size = new System.Drawing.Size(126, 21);
            this.txtRegistePassword2.TabIndex = 22;
            this.txtRegistePassword2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "确认密码：";
            // 
            // btnegiste
            // 
            this.btnegiste.Location = new System.Drawing.Point(54, 149);
            this.btnegiste.Name = "btnegiste";
            this.btnegiste.Size = new System.Drawing.Size(75, 23);
            this.btnegiste.TabIndex = 20;
            this.btnegiste.Text = "注册";
            this.btnegiste.UseVisualStyleBackColor = true;
            this.btnegiste.Click += new System.EventHandler(this.btnegiste_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "密   码：";
            // 
            // txtRegistePassword
            // 
            this.txtRegistePassword.Location = new System.Drawing.Point(127, 53);
            this.txtRegistePassword.Name = "txtRegistePassword";
            this.txtRegistePassword.Size = new System.Drawing.Size(126, 21);
            this.txtRegistePassword.TabIndex = 18;
            this.txtRegistePassword.UseSystemPasswordChar = true;
            // 
            // txtRegisteName
            // 
            this.txtRegisteName.Location = new System.Drawing.Point(127, 27);
            this.txtRegisteName.Name = "txtRegisteName";
            this.txtRegisteName.Size = new System.Drawing.Size(126, 21);
            this.txtRegisteName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "用户名：";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(178, 149);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 20;
            this.btn.Text = "清空";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btnegiste_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 202);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtRegistePassword2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnegiste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegistePassword);
            this.Controls.Add(this.txtRegisteName);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtRegistePassword2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnegiste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegistePassword;
        private System.Windows.Forms.TextBox txtRegisteName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn;
    }
}