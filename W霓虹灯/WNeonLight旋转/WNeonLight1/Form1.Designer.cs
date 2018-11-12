namespace WNeonLight1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOneRun = new System.Windows.Forms.Button();
            this.btnClockwise = new System.Windows.Forms.Button();
            this.btnCounterclockwise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(17, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnBorn
            // 
            this.btnBorn.Location = new System.Drawing.Point(17, 15);
            this.btnBorn.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorn.Name = "btnBorn";
            this.btnBorn.Size = new System.Drawing.Size(100, 29);
            this.btnBorn.TabIndex = 1;
            this.btnBorn.Text = "动态生成50个";
            this.btnBorn.UseVisualStyleBackColor = true;
            this.btnBorn.Click += new System.EventHandler(this.btnBorn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOneRun
            // 
            this.btnOneRun.Location = new System.Drawing.Point(170, 15);
            this.btnOneRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnOneRun.Name = "btnOneRun";
            this.btnOneRun.Size = new System.Drawing.Size(100, 29);
            this.btnOneRun.TabIndex = 2;
            this.btnOneRun.Text = "棕色转圈";
            this.btnOneRun.UseVisualStyleBackColor = true;
            this.btnOneRun.Click += new System.EventHandler(this.btnOneRun_Click);
            // 
            // btnClockwise
            // 
            this.btnClockwise.Location = new System.Drawing.Point(303, 15);
            this.btnClockwise.Margin = new System.Windows.Forms.Padding(4);
            this.btnClockwise.Name = "btnClockwise";
            this.btnClockwise.Size = new System.Drawing.Size(100, 29);
            this.btnClockwise.TabIndex = 2;
            this.btnClockwise.Text = "顺时针转圈";
            this.btnClockwise.UseVisualStyleBackColor = true;
            this.btnClockwise.Click += new System.EventHandler(this.btnClockwise_Click);
            // 
            // btnCounterclockwise
            // 
            this.btnCounterclockwise.Location = new System.Drawing.Point(437, 15);
            this.btnCounterclockwise.Margin = new System.Windows.Forms.Padding(4);
            this.btnCounterclockwise.Name = "btnCounterclockwise";
            this.btnCounterclockwise.Size = new System.Drawing.Size(100, 29);
            this.btnCounterclockwise.TabIndex = 2;
            this.btnCounterclockwise.Text = "逆时针转圈";
            this.btnCounterclockwise.UseVisualStyleBackColor = true;
            this.btnCounterclockwise.Click += new System.EventHandler(this.btnCounterclockwise_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 530);
            this.Controls.Add(this.btnCounterclockwise);
            this.Controls.Add(this.btnClockwise);
            this.Controls.Add(this.btnOneRun);
            this.Controls.Add(this.btnBorn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOneRun;
        private System.Windows.Forms.Button btnClockwise;
        private System.Windows.Forms.Button btnCounterclockwise;
    }
}

