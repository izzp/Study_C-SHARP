namespace WPictureMove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSpeedUp = new System.Windows.Forms.Button();
            this.btnUpDown = new System.Windows.Forms.Button();
            this.btnLeftRight = new System.Windows.Forms.Button();
            this.btnSpeedDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(359, 147);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(75, 23);
            this.btnCircle.TabIndex = 1;
            this.btnCircle.Text = "环周";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSpeedUp
            // 
            this.btnSpeedUp.Location = new System.Drawing.Point(440, 89);
            this.btnSpeedUp.Name = "btnSpeedUp";
            this.btnSpeedUp.Size = new System.Drawing.Size(75, 23);
            this.btnSpeedUp.TabIndex = 2;
            this.btnSpeedUp.Text = "加速";
            this.btnSpeedUp.UseVisualStyleBackColor = true;
            this.btnSpeedUp.Click += new System.EventHandler(this.btnSpeedUp_Click);
            // 
            // btnUpDown
            // 
            this.btnUpDown.Location = new System.Drawing.Point(359, 89);
            this.btnUpDown.Name = "btnUpDown";
            this.btnUpDown.Size = new System.Drawing.Size(75, 23);
            this.btnUpDown.TabIndex = 3;
            this.btnUpDown.Text = "上下";
            this.btnUpDown.UseVisualStyleBackColor = true;
            this.btnUpDown.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnLeftRight
            // 
            this.btnLeftRight.Location = new System.Drawing.Point(359, 118);
            this.btnLeftRight.Name = "btnLeftRight";
            this.btnLeftRight.Size = new System.Drawing.Size(75, 23);
            this.btnLeftRight.TabIndex = 4;
            this.btnLeftRight.Text = "左右";
            this.btnLeftRight.UseVisualStyleBackColor = true;
            this.btnLeftRight.Click += new System.EventHandler(this.btnLeftRight_Click);
            // 
            // btnSpeedDown
            // 
            this.btnSpeedDown.Location = new System.Drawing.Point(440, 118);
            this.btnSpeedDown.Name = "btnSpeedDown";
            this.btnSpeedDown.Size = new System.Drawing.Size(75, 23);
            this.btnSpeedDown.TabIndex = 2;
            this.btnSpeedDown.Text = "减速";
            this.btnSpeedDown.UseVisualStyleBackColor = true;
            this.btnSpeedDown.Click += new System.EventHandler(this.btnSpeedDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "当前位置：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(608, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeftRight);
            this.Controls.Add(this.btnUpDown);
            this.Controls.Add(this.btnSpeedDown);
            this.Controls.Add(this.btnSpeedUp);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "图片移动";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSpeedUp;
        private System.Windows.Forms.Button btnUpDown;
        private System.Windows.Forms.Button btnLeftRight;
        private System.Windows.Forms.Button btnSpeedDown;
        private System.Windows.Forms.Label label1;
    }
}

