using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.Drawing;
#if DEBUG
using System.Diagnostics;
#endif

namespace ExcelImageInsert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取用户选择的文件夹
        /// </summary>
        /// <returns></returns>
        private string GetFolder()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.SelectedPath;
            }
            return string.Empty;
        }

        //获取临时文件夹路径
        string TempPath = Path.GetTempPath();
        /// <summary>
        /// 从指定的目录中获取指定扩展名的文件
        /// </summary>
        /// <param name="folder">目录名</param>
        /// <param name="filter">扩展名列表，多个扩展名使用分号分开，如.txt;.zip</param>
        /// <returns></returns>
        private List<string> GetFiles(string folder, string filter)
        {
            List<string> files = new List<string>();
            string[] filters;
            if (filter.IndexOf(';') != -1)
            {
                filters = filter.Split(';');
            }
            else
            {
                filters = new string[1];
                filters[0] = filter;
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(folder);
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                for (int i = 0; i < filters.Length; i++)
                {
                    if (file.Extension == filters[i])
                    {
                        files.Add(file.FullName);
#if DEBUG
                        Debug.WriteLine(message: file.FullName);
#endif
                        break;
                    }
                }
            }

            return files;
        }

        const double COLUMN_WIDTH_RATIO = 7.0;
        const double ROW_HEIGHT_RATIO = 1.33;

        #region 将列表框中的内容取出到一个List中
        /// <summary>
        /// 获取列表框中的所有项目
        /// </summary>
        /// <returns></returns>
        private List<string> GetImageFiles()
        {
            if (listBox1.Items.Count == 0) return null;

            List<string> imgFiles = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                imgFiles.Add(listBox1.Items[i].ToString());
            }
            return imgFiles;
        }
        #endregion

        #region 获取路径中的不带扩展名的文件名
        /// <summary>
        /// 从指定路径中返回不带扩展名的文件名
        /// </summary>
        /// <param name="path">要获取文件名的路径</param>
        /// <returns></returns>
        private string GetFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }
        #endregion

        #region 创建新的Excel文件
        /// <summary>
        /// 创建一个新的Excel文件
        /// </summary>
        private void CreateNewFile()
        {
            //获取要保存的文件的路径
            string excelFileName = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel文件|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                excelFileName = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            //获取图片路径
            List<string> imgFiles = GetImageFiles();

            //Excel部分

            double rowHeigth = 94.0;
            double columnWidth = 22.0;

            FileInfo excelFile = new FileInfo(excelFileName);
            ExcelPackage excel = new ExcelPackage(excelFile);
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add(DateTime.Now.ToString("yyyyMMddhhmmss"));
            ExcelPicture excelPicture = null;
            ExcelRow excelRow;
            ExcelColumn excelColumn;
            int row = 1;
            int imgColumn = int.Parse(TextBox_ImgColumn.Text);
            int filenameColumn = int.Parse(TextBox_ImgNameColumn.Text);
            string name;
            string tempImgFile = "";

            //将路径中的文件名取出，不带扩展名
            foreach (string s in imgFiles)
            {
                name = GetFileName(s);
                if (TextBox_ImgNameColumn.Text != "" || TextBox_ImgNameColumn.Text != "0")
                {
                    //文件名填入第一列
                    worksheet.Cells[row, int.Parse(TextBox_ImgNameColumn.Text)].Value = name;
                    worksheet.Cells[row, int.Parse(TextBox_ImgNameColumn.Text)].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin, Color.Black);
                }

                excelRow = worksheet.Row(row);
                excelColumn = worksheet.Column(imgColumn);
                excelRow.Height = rowHeigth;
                excelColumn.Width = columnWidth;

                tempImgFile = GetTempFileName(s);

                excelPicture = worksheet.Drawings.AddPicture(name, new FileInfo(tempImgFile));
                //调整图片的位置到单元格内
                excelPicture.SetPosition(row - 1, 0, imgColumn - 1, 0);
                excelPicture.SetSize((int)(excelColumn.Width * COLUMN_WIDTH_RATIO), (int)(rowHeigth * ROW_HEIGHT_RATIO));
                row++;
                //删除临时文件
                File.Delete(tempImgFile);
            }

            excelPicture.AdjustPositionAndSize();
            //根据内容调整列的宽度
            worksheet.Column(1).AutoFit();
            //激活工作表，然后保存
            worksheet.Select();
            excel.Save();
            excel = null;
            worksheet = null;
            excelPicture = null;
            excelColumn = null;
            excelRow = null;
        }

        #endregion

        #region 复制文件到临时目录
        /// <summary>
        /// 复制一个指定的文件到临时文件夹，并返回该临时文件的路径
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private string GetTempFileName(string file)
        {
            string tempImgFile;
            int counter = 0;
            try
            {
                //找一个合适的文件名
                while (File.Exists(TempPath + "\\" + counter.ToString() + Path.GetExtension(file)))
                {
                    counter++;
                }

                tempImgFile = TempPath + "\\" + counter.ToString() + Path.GetExtension(file);
                //将文件复制到临时文件夹中
                File.Copy(file, tempImgFile);
                return tempImgFile;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region 插入到已有的Excel文件
        private void UseExistsExcelFile()
        {
            using (ExcelPackage excel = new ExcelPackage(new FileInfo(TextBox_ExcelFile.Text)))
            {
                int successCount = 0;
                int failCount = 0;
                string errMsg = "";

                //获取第一个工作表
                ExcelWorksheet worksheet = excel.Workbook.Worksheets[1];
                int row = 0;

                while (worksheet.Cells[++row, 1].Value != null) ;
                double imgColumnWidth = worksheet.Column(int.Parse(TextBox_ImgColumn.Text)).Width; //图片所在列的宽度
                double imgRowHeight = worksheet.Row(row - 1).Height; //图片所在行的高度
                int imgNameColumn = 0;
                int imgColumn = int.Parse(TextBox_ImgColumn.Text);
                string imgName = "";
                string tempImgFile = "";

                //调整列宽
                worksheet.Column(imgColumn).Width = imgColumnWidth;

                //读取图片
                var imgFiles = GetImageFiles();
                foreach (var f in imgFiles)
                {
                    worksheet.Row(row).Height = imgRowHeight; //调整行高
                    if (TextBox_ImgNameColumn.Text != "" && TextBox_ImgNameColumn.Text != "0")
                    {
                        imgNameColumn = int.Parse(TextBox_ImgNameColumn.Text);
                        //插入文件名
                        imgName = GetFileName(f);
                        worksheet.Cells[row, imgNameColumn].Value = imgName;
                        worksheet.Cells[row, imgNameColumn].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                        worksheet.Cells[row, imgNameColumn].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        //调整列宽
                        worksheet.Column(imgNameColumn).AutoFit();
                    }
                    //插入图片
                    tempImgFile = GetTempFileName(f);
                    
                    try
                    {
                        ExcelPicture picture = worksheet.Drawings.AddPicture(imgName, new FileInfo(tempImgFile));
                        picture.SetPosition(row - 1, 0, imgColumn - 1, 0);
                        picture.SetSize((int)(imgColumnWidth * COLUMN_WIDTH_RATIO), (int)(worksheet.Row(row).Height * ROW_HEIGHT_RATIO));
                        successCount++;
                    }
                    catch(Exception ex)
                    {
                        failCount++;
                        errMsg += ex.Message + "\n";
                        continue;
                    }
                    
                    ++row;
                    File.Delete(tempImgFile);
                }
                
                //保存文件
                excel.Save();


                if(failCount > 0)
                {
                    MessageBox.Show(string.Format("操作已完成。成功 {0} 个，失败 {1} 个。\n{2}", successCount.ToString(), failCount.ToString(),errMsg), "文件已保存", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(string.Format("操作已完成。成功 {0} 个，失败 {1} 个。", successCount.ToString(), failCount.ToString()), "文件已保存", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn_BrowseExcelFile.Enabled = false;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// 只允许输入数字和退格键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllowNumbersInput(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        /// <summary>
        /// 添加文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图片文件|*.jpg;*.bmp;*.gif;*.png";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string x in openFileDialog.FileNames)
                {
                    listBox1.Items.Add(x);
                }
            }
        }


        private void Btn_Execution_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                return;
            }

            if (TextBox_ImgColumn.Text == "" || int.Parse(TextBox_ImgColumn.Text) == 0 )
            {
                return;
            }

            if (Rad_NewFile.Checked)
            {
                CreateNewFile();
            }
            else if (Rad_AddToExistsFile.Checked)
            {
                UseExistsExcelFile();
            }
        }
        /// <summary>
        /// 是否为指定扩展名的图片文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private bool IsPicture(string path)
        {
            string ext = Path.GetExtension(path).ToUpper();
            if (ext.Contains("PNG") || ext.Contains("GIF") || ext.Contains("JPG") || ext.Contains("BMP"))
            {
                return true;
            }

            return false;
        }

        private void Btn_AddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo directory = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                foreach (FileInfo fileInfo in directory.GetFiles())
                {
                    if (IsPicture(fileInfo.FullName))
                    {
                        listBox1.Items.Add(fileInfo.FullName);
                    }
                }
            }
        }
        #region 移除项目和清空列表
        private void MenuItem_Remove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                return;
            }
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void MenuItem_Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        #endregion

        #region 切换设置窗口的可见性
        bool OptionWindowVisible = true;

        private void Btn_SwitchOptionWindow_Click(object sender, EventArgs e)
        {
            if (OptionWindowVisible)
            {
                this.Height = this.Height - Grp_Settings.Height;
                listBox1.Top -= Grp_Settings.Height;
                Btn_Execution.Top -= Grp_Settings.Height;
                Btn_AddFolder.Top -= Grp_Settings.Height;
                Btn_AddImgFile.Top -= Grp_Settings.Height;
                Grp_Settings.Visible = false;
                OptionWindowVisible = false;
                Lnk_SwitchSettingWindow.Text = "显示设置";
            }
            else
            {
                Grp_Settings.Visible = true;
                this.Height = this.Height + Grp_Settings.Height;
                listBox1.Top += Grp_Settings.Height;
                Btn_Execution.Top += Grp_Settings.Height;
                Btn_AddFolder.Top += Grp_Settings.Height;
                Btn_AddImgFile.Top += Grp_Settings.Height;
                OptionWindowVisible = true;
                Lnk_SwitchSettingWindow.Text = "隐藏设置";
            }
        }
        #endregion

        private void Btn_BrowseExcelFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel文件|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBox_ExcelFile.Text = openFileDialog.FileName;
            }
        }

        private void Rad_AddToExistsFile_CheckedChanged(object sender, EventArgs e)
        {
            if(Rad_AddToExistsFile.Checked)
            {
                TextBox_ImgColumn.Text = "";
                TextBox_ImgNameColumn.Text = "";
                Btn_BrowseExcelFile.Enabled = true;
            }
            else
            {
                Btn_BrowseExcelFile.Enabled = false;
            }
        }

      
    }
}
