namespace WNeon
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBorn = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(28, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 240);
            this.panel1.TabIndex = 0;
            // 
            // btnBorn
            // 
            this.btnBorn.Location = new System.Drawing.Point(37, 13);
            this.btnBorn.Name = "btnBorn";
            this.btnBorn.Size = new System.Drawing.Size(124, 23);
            this.btnBorn.TabIndex = 1;
            this.btnBorn.Text = "动态生成label";
            this.btnBorn.UseVisualStyleBackColor = true;
            this.btnBorn.Click += new System.EventHandler(this.btnBorn_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(182, 13);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "跑起来";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 307);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnBorn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "霓虹灯";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorn;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer timer1;
    }
}

