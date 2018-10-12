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
            this.components = new System.ComponentModel.Container();
            this.Btn_Execution = new System.Windows.Forms.Button();
            this.Rad_AddToExistsFile = new System.Windows.Forms.RadioButton();
            this.Rad_NewFile = new System.Windows.Forms.RadioButton();
            this.Btn_Minisize = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_AddFolder = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox_ExcelFile = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Execution
            // 
            this.Btn_Execution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Execution.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Execution.Location = new System.Drawing.Point(554, 342);
            this.Btn_Execution.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Execution.Name = "Btn_Execution";
            this.Btn_Execution.Size = new System.Drawing.Size(89, 25);
            this.Btn_Execution.TabIndex = 0;
            this.Btn_Execution.Text = "开始";
            this.Btn_Execution.UseVisualStyleBackColor = true;
            this.Btn_Execution.Click += new System.EventHandler(this.Btn_Execution_Click);
            // 
            // Rad_AddToExistsFile
            // 
            this.Rad_AddToExistsFile.AutoSize = true;
            this.Rad_AddToExistsFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Rad_AddToExistsFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Rad_AddToExistsFile.Location = new System.Drawing.Point(100, 43);
            this.Rad_AddToExistsFile.Margin = new System.Windows.Forms.Padding(2);
            this.Rad_AddToExistsFile.Name = "Rad_AddToExistsFile";
            this.Rad_AddToExistsFile.Size = new System.Drawing.Size(116, 22);
            this.Rad_AddToExistsFile.TabIndex = 3;
            this.Rad_AddToExistsFile.Text = "添加到已有文件";
            this.Rad_AddToExistsFile.UseVisualStyleBackColor = true;
            this.Rad_AddToExistsFile.CheckedChanged += new System.EventHandler(this.Rad_AddToExistsFile_CheckedChanged);
            // 
            // Rad_NewFile
            // 
            this.Rad_NewFile.AutoSize = true;
            this.Rad_NewFile.Checked = true;
            this.Rad_NewFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Rad_NewFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Rad_NewFile.Location = new System.Drawing.Point(12, 43);
            this.Rad_NewFile.Margin = new System.Windows.Forms.Padding(2);
            this.Rad_NewFile.Name = "Rad_NewFile";
            this.Rad_NewFile.Size = new System.Drawing.Size(80, 22);
            this.Rad_NewFile.TabIndex = 2;
            this.Rad_NewFile.TabStop = true;
            this.Rad_NewFile.Text = "新建文件";
            this.Rad_NewFile.UseVisualStyleBackColor = true;
            // 
            // Btn_Minisize
            // 
            this.Btn_Minisize.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Minisize.FlatAppearance.BorderSize = 0;
            this.Btn_Minisize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.Btn_Minisize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_Minisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minisize.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Minisize.ForeColor = System.Drawing.Color.White;
            this.Btn_Minisize.Location = new System.Drawing.Point(580, 2);
            this.Btn_Minisize.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Minisize.Name = "Btn_Minisize";
            this.Btn_Minisize.Size = new System.Drawing.Size(26, 25);
            this.Btn_Minisize.TabIndex = 7;
            this.Btn_Minisize.TabStop = false;
            this.Btn_Minisize.Text = "-";
            this.Btn_Minisize.UseVisualStyleBackColor = false;
            this.Btn_Minisize.Click += new System.EventHandler(this.Btn_Minisize_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(616, 2);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(26, 25);
            this.Btn_Close.TabIndex = 8;
            this.Btn_Close.TabStop = false;
            this.Btn_Close.Text = "×";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(465, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "添加文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_AddFolder
            // 
            this.Btn_AddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddFolder.Location = new System.Drawing.Point(554, 42);
            this.Btn_AddFolder.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_AddFolder.Name = "Btn_AddFolder";
            this.Btn_AddFolder.Size = new System.Drawing.Size(85, 26);
            this.Btn_AddFolder.TabIndex = 9;
            this.Btn_AddFolder.Text = "添加目录";
            this.Btn_AddFolder.UseVisualStyleBackColor = true;
            this.Btn_AddFolder.Click += new System.EventHandler(this.Btn_AddFolder_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Title.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(2, 7);
            this.Lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(109, 17);
            this.Lbl_Title.TabIndex = 12;
            this.Lbl_Title.Text = "Excel图片插入工具";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.Btn_Close);
            this.panel1.Controls.Add(this.Lbl_Title);
            this.panel1.Controls.Add(this.Btn_Minisize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 30);
            this.panel1.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(630, 242);
            this.listBox1.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Remove,
            this.MenuItem_Clear});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // MenuItem_Remove
            // 
            this.MenuItem_Remove.Name = "MenuItem_Remove";
            this.MenuItem_Remove.Size = new System.Drawing.Size(120, 22);
            this.MenuItem_Remove.Text = "移除(&M)";
            this.MenuItem_Remove.Click += new System.EventHandler(this.MenuItem_Remove_Click);
            // 
            // MenuItem_Clear
            // 
            this.MenuItem_Clear.Name = "MenuItem_Clear";
            this.MenuItem_Clear.Size = new System.Drawing.Size(120, 22);
            this.MenuItem_Clear.Text = "清空(&C)";
            this.MenuItem_Clear.Click += new System.EventHandler(this.MenuItem_Clear_Click);
            // 
            // TextBox_ExcelFile
            // 
            this.TextBox_ExcelFile.BackColor = System.Drawing.Color.White;
            this.TextBox_ExcelFile.Location = new System.Drawing.Point(221, 45);
            this.TextBox_ExcelFile.Name = "TextBox_ExcelFile";
            this.TextBox_ExcelFile.ReadOnly = true;
            this.TextBox_ExcelFile.Size = new System.Drawing.Size(230, 21);
            this.TextBox_ExcelFile.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 376);
            this.Controls.Add(this.TextBox_ExcelFile);
            this.Controls.Add(this.Rad_AddToExistsFile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Rad_NewFile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_AddFolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Execution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Execution;
        private System.Windows.Forms.Button Btn_Minisize;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.RadioButton Rad_AddToExistsFile;
        private System.Windows.Forms.RadioButton Rad_NewFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_AddFolder;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TextBox_ExcelFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Remove;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Clear;
    }
}

