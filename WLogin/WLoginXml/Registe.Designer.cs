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
            this.label1.Location = new System.Drawing.Point(64, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // txtRegisteName
            // 
            this.txtRegisteName.Location = new System.Drawing.Point(138, 55);
            this.txtRegisteName.Name = "txtRegisteName";
            this.txtRegisteName.Size = new System.Drawing.Size(100, 21);
            this.txtRegisteName.TabIndex = 1;
            // 
            // txtRegistePassword
            // 
            this.txtRegistePassword.Location = new System.Drawing.Point(138, 93);
            this.txtRegistePassword.Name = "txtRegistePassword";
            this.txtRegistePassword.Size = new System.Drawing.Size(100, 21);
            this.txtRegistePassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密   码：";
            // 
            // btnegiste
            // 
            this.btnegiste.Location = new System.Drawing.Point(113, 178);
            this.btnegiste.Name = "btnegiste";
            this.btnegiste.Size = new System.Drawing.Size(75, 23);
            this.btnegiste.TabIndex = 4;
            this.btnegiste.Text = "注册";
            this.btnegiste.UseVisualStyleBackColor = true;
            this.btnegiste.Click += new System.EventHandler(this.btnegiste_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "确认密码：";
            // 
            // txtRegistePassword2
            // 
            this.txtRegistePassword2.Location = new System.Drawing.Point(138, 125);
            this.txtRegistePassword2.Name = "txtRegistePassword2";
            this.txtRegistePassword2.Size = new System.Drawing.Size(100, 21);
            this.txtRegistePassword2.TabIndex = 6;
            // 
            // btnRegisteRegiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 232);
            this.Controls.Add(this.txtRegistePassword2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnegiste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegistePassword);
            this.Controls.Add(this.txtRegisteName);
            this.Controls.Add(this.label1);
            this.Name = "btnRegisteRegiste";
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