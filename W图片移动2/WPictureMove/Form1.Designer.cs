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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.运动方向ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowsBigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowsSmallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "当前位置：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.运动方向ToolStripMenuItem,
            this.窗口ToolStripMenuItem,
            this.SpeedUpToolStripMenuItem,
            this.SpeedDownToolStripMenuItem,
            this.ResetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 283);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 运动方向ToolStripMenuItem
            // 
            this.运动方向ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updownToolStripMenuItem,
            this.LRToolStripMenuItem,
            this.CircleToolStripMenuItem});
            this.运动方向ToolStripMenuItem.Name = "运动方向ToolStripMenuItem";
            this.运动方向ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.运动方向ToolStripMenuItem.Text = "运动方向";
            // 
            // updownToolStripMenuItem
            // 
            this.updownToolStripMenuItem.Name = "updownToolStripMenuItem";
            this.updownToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.updownToolStripMenuItem.Text = "上下";
            this.updownToolStripMenuItem.Click += new System.EventHandler(this.updownToolStripMenuItem_Click);
            // 
            // LRToolStripMenuItem
            // 
            this.LRToolStripMenuItem.Name = "LRToolStripMenuItem";
            this.LRToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.LRToolStripMenuItem.Text = "左右";
            this.LRToolStripMenuItem.Click += new System.EventHandler(this.LRToolStripMenuItem_Click);
            // 
            // CircleToolStripMenuItem
            // 
            this.CircleToolStripMenuItem.Name = "CircleToolStripMenuItem";
            this.CircleToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.CircleToolStripMenuItem.Text = "环周";
            this.CircleToolStripMenuItem.Click += new System.EventHandler(this.CircleToolStripMenuItem_Click);
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowsBigToolStripMenuItem,
            this.WindowsSmallToolStripMenuItem});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // WindowsBigToolStripMenuItem
            // 
            this.WindowsBigToolStripMenuItem.Name = "WindowsBigToolStripMenuItem";
            this.WindowsBigToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.WindowsBigToolStripMenuItem.Text = "变大";
            this.WindowsBigToolStripMenuItem.Click += new System.EventHandler(this.WindowsBigToolStripMenuItem_Click);
            // 
            // WindowsSmallToolStripMenuItem
            // 
            this.WindowsSmallToolStripMenuItem.Name = "WindowsSmallToolStripMenuItem";
            this.WindowsSmallToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.WindowsSmallToolStripMenuItem.Text = "变小";
            this.WindowsSmallToolStripMenuItem.Click += new System.EventHandler(this.WindowsSmallToolStripMenuItem_Click);
            // 
            // SpeedUpToolStripMenuItem
            // 
            this.SpeedUpToolStripMenuItem.Name = "SpeedUpToolStripMenuItem";
            this.SpeedUpToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.SpeedUpToolStripMenuItem.Text = "加速";
            this.SpeedUpToolStripMenuItem.Click += new System.EventHandler(this.SpeedUpToolStripMenuItem_Click);
            // 
            // SpeedDownToolStripMenuItem
            // 
            this.SpeedDownToolStripMenuItem.Name = "SpeedDownToolStripMenuItem";
            this.SpeedDownToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.SpeedDownToolStripMenuItem.Text = "减速";
            this.SpeedDownToolStripMenuItem.Click += new System.EventHandler(this.SpeedDownToolStripMenuItem_Click);
            // 
            // ResetToolStripMenuItem
            // 
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.ResetToolStripMenuItem.Text = "复位";
            this.ResetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(624, 347);
            this.Name = "Form1";
            this.Text = "图片移动";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 运动方向ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowsBigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowsSmallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpeedUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpeedDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetToolStripMenuItem;
    }
}

