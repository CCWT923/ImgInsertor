namespace ExcelImageInsert
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Execution = new System.Windows.Forms.Button();
            this.Btn_SwitchSetPanel = new System.Windows.Forms.Button();
            this.Panel_Setting = new System.Windows.Forms.Panel();
            this.Group_ImgLayout = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBox_ImgHeight = new System.Windows.Forms.TextBox();
            this.TxtBox_ImgWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBox_ImgNameColIndex = new System.Windows.Forms.TextBox();
            this.ChkBox_UseImgName = new System.Windows.Forms.CheckBox();
            this.TxtBox_ImgColIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rad_Vertical = new System.Windows.Forms.RadioButton();
            this.Rad_Horizontal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Minisize = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Group_HoriOption = new System.Windows.Forms.GroupBox();
            this.Group_VertiOption = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_ImgCountOfLines = new System.Windows.Forms.TextBox();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProgressBar1 = new ProgressBarWithText.ProgressBarWithText();
            this.Panel_Setting.SuspendLayout();
            this.Group_ImgLayout.SuspendLayout();
            this.Group_HoriOption.SuspendLayout();
            this.Group_VertiOption.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Execution
            // 
            this.Btn_Execution.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Execution.Location = new System.Drawing.Point(739, 427);
            this.Btn_Execution.Name = "Btn_Execution";
            this.Btn_Execution.Size = new System.Drawing.Size(119, 31);
            this.Btn_Execution.TabIndex = 0;
            this.Btn_Execution.Text = "执行";
            this.Btn_Execution.UseVisualStyleBackColor = true;
            this.Btn_Execution.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // Btn_SwitchSetPanel
            // 
            this.Btn_SwitchSetPanel.Location = new System.Drawing.Point(863, 225);
            this.Btn_SwitchSetPanel.Name = "Btn_SwitchSetPanel";
            this.Btn_SwitchSetPanel.Size = new System.Drawing.Size(16, 54);
            this.Btn_SwitchSetPanel.TabIndex = 5;
            this.Btn_SwitchSetPanel.Text = ">";
            this.Btn_SwitchSetPanel.UseVisualStyleBackColor = true;
            this.Btn_SwitchSetPanel.Click += new System.EventHandler(this.Btn_SwitchSetPanel_Click);
            // 
            // Panel_Setting
            // 
            this.Panel_Setting.BackColor = System.Drawing.Color.White;
            this.Panel_Setting.Controls.Add(this.Group_ImgLayout);
            this.Panel_Setting.Controls.Add(this.label6);
            this.Panel_Setting.Controls.Add(this.Group_VertiOption);
            this.Panel_Setting.Controls.Add(this.TxtBox_ImgHeight);
            this.Panel_Setting.Controls.Add(this.Group_HoriOption);
            this.Panel_Setting.Controls.Add(this.TxtBox_ImgWidth);
            this.Panel_Setting.Controls.Add(this.label5);
            this.Panel_Setting.Location = new System.Drawing.Point(880, -1);
            this.Panel_Setting.Name = "Panel_Setting";
            this.Panel_Setting.Size = new System.Drawing.Size(322, 468);
            this.Panel_Setting.TabIndex = 6;
            // 
            // Group_ImgLayout
            // 
            this.Group_ImgLayout.Controls.Add(this.Rad_Vertical);
            this.Group_ImgLayout.Controls.Add(this.Rad_Horizontal);
            this.Group_ImgLayout.Controls.Add(this.label1);
            this.Group_ImgLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Group_ImgLayout.Location = new System.Drawing.Point(10, 46);
            this.Group_ImgLayout.Name = "Group_ImgLayout";
            this.Group_ImgLayout.Size = new System.Drawing.Size(312, 53);
            this.Group_ImgLayout.TabIndex = 0;
            this.Group_ImgLayout.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(155, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "×";
            // 
            // TxtBox_ImgHeight
            // 
            this.TxtBox_ImgHeight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtBox_ImgHeight.Location = new System.Drawing.Point(180, 100);
            this.TxtBox_ImgHeight.MaxLength = 3;
            this.TxtBox_ImgHeight.Name = "TxtBox_ImgHeight";
            this.TxtBox_ImgHeight.Size = new System.Drawing.Size(51, 27);
            this.TxtBox_ImgHeight.TabIndex = 10;
            this.TxtBox_ImgHeight.Text = "100";
            this.TxtBox_ImgHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBox_ImgWidth
            // 
            this.TxtBox_ImgWidth.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtBox_ImgWidth.Location = new System.Drawing.Point(99, 100);
            this.TxtBox_ImgWidth.MaxLength = 3;
            this.TxtBox_ImgWidth.Name = "TxtBox_ImgWidth";
            this.TxtBox_ImgWidth.Size = new System.Drawing.Size(51, 27);
            this.TxtBox_ImgWidth.TabIndex = 10;
            this.TxtBox_ImgWidth.Text = "100";
            this.TxtBox_ImgWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(19, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "图片尺寸：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(270, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "列";
            // 
            // TxtBox_ImgNameColIndex
            // 
            this.TxtBox_ImgNameColIndex.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtBox_ImgNameColIndex.Location = new System.Drawing.Point(223, 44);
            this.TxtBox_ImgNameColIndex.MaxLength = 3;
            this.TxtBox_ImgNameColIndex.Name = "TxtBox_ImgNameColIndex";
            this.TxtBox_ImgNameColIndex.Size = new System.Drawing.Size(38, 27);
            this.TxtBox_ImgNameColIndex.TabIndex = 7;
            this.TxtBox_ImgNameColIndex.Text = "1";
            this.TxtBox_ImgNameColIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChkBox_UseImgName
            // 
            this.ChkBox_UseImgName.AutoSize = true;
            this.ChkBox_UseImgName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChkBox_UseImgName.Location = new System.Drawing.Point(6, 47);
            this.ChkBox_UseImgName.Name = "ChkBox_UseImgName";
            this.ChkBox_UseImgName.Size = new System.Drawing.Size(211, 24);
            this.ChkBox_UseImgName.TabIndex = 6;
            this.ChkBox_UseImgName.Text = "将图片名称作为数据写入第";
            this.ChkBox_UseImgName.UseVisualStyleBackColor = true;
            this.ChkBox_UseImgName.CheckedChanged += new System.EventHandler(this.ChkBox_UseImgName_CheckedChanged);
            // 
            // TxtBox_ImgColIndex
            // 
            this.TxtBox_ImgColIndex.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtBox_ImgColIndex.Location = new System.Drawing.Point(120, 16);
            this.TxtBox_ImgColIndex.MaxLength = 3;
            this.TxtBox_ImgColIndex.Name = "TxtBox_ImgColIndex";
            this.TxtBox_ImgColIndex.Size = new System.Drawing.Size(38, 27);
            this.TxtBox_ImgColIndex.TabIndex = 5;
            this.TxtBox_ImgColIndex.Text = "2";
            this.TxtBox_ImgColIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBox_ImgColIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_ImgColIndex_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(164, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "列";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(2, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "将图片插入到第";
            // 
            // Rad_Vertical
            // 
            this.Rad_Vertical.AutoSize = true;
            this.Rad_Vertical.Checked = true;
            this.Rad_Vertical.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Rad_Vertical.Location = new System.Drawing.Point(209, 17);
            this.Rad_Vertical.Name = "Rad_Vertical";
            this.Rad_Vertical.Size = new System.Drawing.Size(60, 24);
            this.Rad_Vertical.TabIndex = 3;
            this.Rad_Vertical.TabStop = true;
            this.Rad_Vertical.Text = "纵向";
            this.Rad_Vertical.UseVisualStyleBackColor = true;
            // 
            // Rad_Horizontal
            // 
            this.Rad_Horizontal.AutoSize = true;
            this.Rad_Horizontal.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Rad_Horizontal.Location = new System.Drawing.Point(135, 17);
            this.Rad_Horizontal.Name = "Rad_Horizontal";
            this.Rad_Horizontal.Size = new System.Drawing.Size(60, 24);
            this.Rad_Horizontal.TabIndex = 2;
            this.Rad_Horizontal.Text = "横向";
            this.Rad_Horizontal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "图片分布方式：";
            // 
            // Btn_Minisize
            // 
            this.Btn_Minisize.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Minisize.FlatAppearance.BorderSize = 0;
            this.Btn_Minisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.Btn_Minisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_Minisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minisize.Location = new System.Drawing.Point(792, 0);
            this.Btn_Minisize.Name = "Btn_Minisize";
            this.Btn_Minisize.Size = new System.Drawing.Size(35, 23);
            this.Btn_Minisize.TabIndex = 7;
            this.Btn_Minisize.TabStop = false;
            this.Btn_Minisize.UseVisualStyleBackColor = false;
            this.Btn_Minisize.Click += new System.EventHandler(this.Btn_Minisize_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Tomato;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Location = new System.Drawing.Point(839, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(35, 23);
            this.Btn_Close.TabIndex = 8;
            this.Btn_Close.TabStop = false;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "添加文件";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(739, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "添加目录";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Location = new System.Drawing.Point(12, 107);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(840, 297);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Group_HoriOption
            // 
            this.Group_HoriOption.Controls.Add(this.TextBox_ImgCountOfLines);
            this.Group_HoriOption.Controls.Add(this.label7);
            this.Group_HoriOption.Location = new System.Drawing.Point(10, 146);
            this.Group_HoriOption.Name = "Group_HoriOption";
            this.Group_HoriOption.Size = new System.Drawing.Size(312, 73);
            this.Group_HoriOption.TabIndex = 1;
            this.Group_HoriOption.TabStop = false;
            this.Group_HoriOption.Text = "横向分布图片";
            // 
            // Group_VertiOption
            // 
            this.Group_VertiOption.Controls.Add(this.ChkBox_UseImgName);
            this.Group_VertiOption.Controls.Add(this.label2);
            this.Group_VertiOption.Controls.Add(this.label3);
            this.Group_VertiOption.Controls.Add(this.TxtBox_ImgColIndex);
            this.Group_VertiOption.Controls.Add(this.label4);
            this.Group_VertiOption.Controls.Add(this.TxtBox_ImgNameColIndex);
            this.Group_VertiOption.Location = new System.Drawing.Point(10, 241);
            this.Group_VertiOption.Name = "Group_VertiOption";
            this.Group_VertiOption.Size = new System.Drawing.Size(312, 94);
            this.Group_VertiOption.TabIndex = 1;
            this.Group_VertiOption.TabStop = false;
            this.Group_VertiOption.Text = "纵向分布图片";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "每行图片的个数：";
            // 
            // TextBox_ImgCountOfLines
            // 
            this.TextBox_ImgCountOfLines.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_ImgCountOfLines.Location = new System.Drawing.Point(143, 29);
            this.TextBox_ImgCountOfLines.MaxLength = 3;
            this.TextBox_ImgCountOfLines.Name = "TextBox_ImgCountOfLines";
            this.TextBox_ImgCountOfLines.Size = new System.Drawing.Size(52, 27);
            this.TextBox_ImgCountOfLines.TabIndex = 6;
            this.TextBox_ImgCountOfLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Title.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.Linen;
            this.Lbl_Title.Location = new System.Drawing.Point(3, 6);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(136, 20);
            this.Lbl_Title.TabIndex = 12;
            this.Lbl_Title.Text = "Excel图片插入工具";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.Btn_Close);
            this.panel1.Controls.Add(this.Lbl_Title);
            this.panel1.Controls.Add(this.Btn_Minisize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 30);
            this.panel1.TabIndex = 13;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BackgroundColor = System.Drawing.Color.White;
            this.ProgressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProgressBar1.DisplayMode = ProgressBarWithText.ProgressBarWithText.ValueDisplayMode.Percent;
            this.ProgressBar1.ForegroundColor = System.Drawing.Color.Green;
            this.ProgressBar1.Location = new System.Drawing.Point(12, 427);
            this.ProgressBar1.MaxValue = 100;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.SetFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProgressBar1.ShowText = true;
            this.ProgressBar1.Size = new System.Drawing.Size(700, 26);
            this.ProgressBar1.TabIndex = 14;
            this.ProgressBar1.TextAlignment = ProgressBarWithText.ProgressBarWithText.TextAlignmentStyle.Center;
            this.ProgressBar1.UseDecimal = false;
            this.ProgressBar1.Value = 85;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 470);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Panel_Setting);
            this.Controls.Add(this.Btn_SwitchSetPanel);
            this.Controls.Add(this.Btn_Execution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Setting.ResumeLayout(false);
            this.Panel_Setting.PerformLayout();
            this.Group_ImgLayout.ResumeLayout(false);
            this.Group_ImgLayout.PerformLayout();
            this.Group_HoriOption.ResumeLayout(false);
            this.Group_HoriOption.PerformLayout();
            this.Group_VertiOption.ResumeLayout(false);
            this.Group_VertiOption.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Execution;
        private System.Windows.Forms.Button Btn_SwitchSetPanel;
        private System.Windows.Forms.Panel Panel_Setting;
        private System.Windows.Forms.Button Btn_Minisize;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.GroupBox Group_ImgLayout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBox_ImgNameColIndex;
        private System.Windows.Forms.CheckBox ChkBox_UseImgName;
        private System.Windows.Forms.TextBox TxtBox_ImgColIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Rad_Vertical;
        private System.Windows.Forms.RadioButton Rad_Horizontal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBox_ImgHeight;
        private System.Windows.Forms.TextBox TxtBox_ImgWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox Group_VertiOption;
        private System.Windows.Forms.GroupBox Group_HoriOption;
        private System.Windows.Forms.TextBox TextBox_ImgCountOfLines;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Panel panel1;
        private ProgressBarWithText.ProgressBarWithText ProgressBar1;
    }
}

