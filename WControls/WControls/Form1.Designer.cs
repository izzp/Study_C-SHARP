namespace WControls
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.chkSleep = new System.Windows.Forms.CheckBox();
            this.chkGame = new System.Windows.Forms.CheckBox();
            this.chkSing = new System.Windows.Forms.CheckBox();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxClass = new System.Windows.Forms.GroupBox();
            this.rbtnClassOne = new System.Windows.Forms.RadioButton();
            this.rbtnClassTwo = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBoxClub = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "爱好：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "选课：";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(93, 28);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 21);
            this.textName.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "语文",
            "数学",
            "英语",
            "c#"});
            this.checkedListBox1.Location = new System.Drawing.Point(93, 205);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 84);
            this.checkedListBox1.TabIndex = 5;
            // 
            // chkSleep
            // 
            this.chkSleep.AutoSize = true;
            this.chkSleep.Location = new System.Drawing.Point(93, 158);
            this.chkSleep.Name = "chkSleep";
            this.chkSleep.Size = new System.Drawing.Size(48, 16);
            this.chkSleep.TabIndex = 6;
            this.chkSleep.Text = "睡觉";
            this.chkSleep.UseVisualStyleBackColor = true;
            // 
            // chkGame
            // 
            this.chkGame.AutoSize = true;
            this.chkGame.Location = new System.Drawing.Point(165, 158);
            this.chkGame.Name = "chkGame";
            this.chkGame.Size = new System.Drawing.Size(48, 16);
            this.chkGame.TabIndex = 7;
            this.chkGame.Text = "游戏";
            this.chkGame.UseVisualStyleBackColor = true;
            // 
            // chkSing
            // 
            this.chkSing.AutoSize = true;
            this.chkSing.Location = new System.Drawing.Point(242, 158);
            this.chkSing.Name = "chkSing";
            this.chkSing.Size = new System.Drawing.Size(48, 16);
            this.chkSing.TabIndex = 8;
            this.chkSing.Text = "唱歌";
            this.chkSing.UseVisualStyleBackColor = true;
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Location = new System.Drawing.Point(28, 29);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(35, 16);
            this.rbtnM.TabIndex = 9;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "男";
            this.rbtnM.UseVisualStyleBackColor = true;
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.Location = new System.Drawing.Point(90, 29);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(35, 16);
            this.rbtnF.TabIndex = 10;
            this.rbtnF.TabStop = true;
            this.rbtnF.Text = "女";
            this.rbtnF.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(93, 317);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnF);
            this.groupBox1.Controls.Add(this.rbtnM);
            this.groupBox1.Location = new System.Drawing.Point(47, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 64);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "性别";
            // 
            // groupBoxClass
            // 
            this.groupBoxClass.Controls.Add(this.rbtnClassOne);
            this.groupBoxClass.Controls.Add(this.rbtnClassTwo);
            this.groupBoxClass.Location = new System.Drawing.Point(199, 70);
            this.groupBoxClass.Name = "groupBoxClass";
            this.groupBoxClass.Size = new System.Drawing.Size(149, 64);
            this.groupBoxClass.TabIndex = 13;
            this.groupBoxClass.TabStop = false;
            this.groupBoxClass.Text = "班级";
            // 
            // rbtnClassOne
            // 
            this.rbtnClassOne.AutoSize = true;
            this.rbtnClassOne.Location = new System.Drawing.Point(17, 29);
            this.rbtnClassOne.Name = "rbtnClassOne";
            this.rbtnClassOne.Size = new System.Drawing.Size(47, 16);
            this.rbtnClassOne.TabIndex = 14;
            this.rbtnClassOne.TabStop = true;
            this.rbtnClassOne.Text = "一班";
            this.rbtnClassOne.UseVisualStyleBackColor = true;
            // 
            // rbtnClassTwo
            // 
            this.rbtnClassTwo.AutoSize = true;
            this.rbtnClassTwo.Location = new System.Drawing.Point(84, 29);
            this.rbtnClassTwo.Name = "rbtnClassTwo";
            this.rbtnClassTwo.Size = new System.Drawing.Size(47, 16);
            this.rbtnClassTwo.TabIndex = 15;
            this.rbtnClassTwo.TabStop = true;
            this.rbtnClassTwo.Text = "二班";
            this.rbtnClassTwo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(396, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(405, 181);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 15;
            this.btnUpload.Text = "上传照片";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxClub
            // 
            this.listBoxClub.FormattingEnabled = true;
            this.listBoxClub.ItemHeight = 12;
            this.listBoxClub.Items.AddRange(new object[] {
            "IT社",
            "乒乓球社",
            "轮滑社"});
            this.listBoxClub.Location = new System.Drawing.Point(293, 228);
            this.listBoxClub.Name = "listBoxClub";
            this.listBoxClub.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxClub.Size = new System.Drawing.Size(120, 88);
            this.listBoxClub.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "社团";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxClub);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxClass);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkSing);
            this.Controls.Add(this.chkGame);
            this.Controls.Add(this.chkSleep);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxClass.ResumeLayout(false);
            this.groupBoxClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox chkSleep;
        private System.Windows.Forms.CheckBox chkGame;
        private System.Windows.Forms.CheckBox chkSing;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxClass;
        private System.Windows.Forms.RadioButton rbtnClassOne;
        private System.Windows.Forms.RadioButton rbtnClassTwo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxClub;
        private System.Windows.Forms.Label label2;
    }
}

