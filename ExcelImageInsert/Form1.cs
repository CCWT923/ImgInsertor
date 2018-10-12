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
            if(dialog.ShowDialog() == DialogResult.OK)
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
            if(filter.IndexOf(';') != -1)
            {
                filters = filter.Split(';');
            }
            else
            {
                filters = new string[1];
                filters[0] = filter;
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(folder);
            foreach ( FileInfo file in directoryInfo.GetFiles())
            {
                for(int i = 0; i < filters.Length; i++)
                {
                    if(file.Extension == filters[i])
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
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                excelFileName = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            //列表框内的所有图片路径取出
            List<string> imgFiles = new List<string>();
            for(int i = 0; i < listBox1.Items.Count;i++)
            {
                imgFiles.Add(listBox1.Items[i].ToString());
            }


            //Excel部分

            int rowHeigth = 94;
            int columnWidth = 22;

            FileInfo excelFile = new FileInfo(excelFileName);
            ExcelPackage excel = new ExcelPackage(excelFile);
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add(DateTime.Now.ToString("yyyyMMddhhmmss"));
            ExcelPicture excelPicture = null;
            ExcelRow excelRow;
            ExcelColumn excelColumn;
            int row = 2;
            int column = 2;
            string name;
            string extension;
            int counter = 0;
            string tempImgFile = "";

            worksheet.Cells[1, 1].Value = "名称";
            worksheet.Cells[1, 2].Value = "图片";
            //将路径中的文件名取出，不带扩展名
            foreach (string s in imgFiles)
            {
                name = Path.GetFileNameWithoutExtension(s);
                //获取文件扩展名
                extension = Path.GetExtension(s).Remove(0, 1);
                //文件名
                worksheet.Cells[row, 1].Value = name;
                worksheet.Cells[row, 1].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin, Color.Black);
                excelRow = worksheet.Row(row);
                excelColumn = worksheet.Column(column);
                excelRow.Height = rowHeigth;
                excelColumn.Width = columnWidth;

                //复制文件到临时目录
                try
                {
                    //找一个合适的文件名
                    while (File.Exists(TempPath + "\\" + counter.ToString() + "." + extension))
                    {
                        counter++;
                    }

                    tempImgFile = TempPath + "\\" + counter.ToString() + "." + extension;
                    //将文件复制到临时文件夹中
                    File.Copy(s, tempImgFile);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                excelPicture = worksheet.Drawings.AddPicture(name, new FileInfo(tempImgFile));
                //调整图片的位置到单元格内
                excelPicture.SetPosition(row - 1, 0, column - 1, 0);
                excelPicture.SetSize((int)(excelColumn.Width * 7),(int)(rowHeigth * 1.33));
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

        private void Form1_Load(object sender, EventArgs e)
        {
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
        private void TxtBox_ImgColIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
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
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach(string x in openFileDialog.FileNames)
                {
                    listBox1.Items.Add(x);
                }
            }
        }

        private void Rad_AddToExistsFile_CheckedChanged(object sender, EventArgs e)
        {
            if(Rad_AddToExistsFile.Checked)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel文件|*.xlsx";
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextBox_ExcelFile.Text = openFileDialog.FileName;
                }
            }
        }

        private void Btn_Execution_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count == 0)
            {
                return;
            }
            if(Rad_NewFile.Checked)
            {
                CreateNewFile();
            }
            else if(Rad_AddToExistsFile.Checked)
            {

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
            if(ext.Contains("PNG") || ext.Contains("GIF") || ext.Contains("JPG") || ext.Contains("BMP"))
            {
                return true;
            }

            return false;
        }

        private void Btn_AddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo directory = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                foreach(FileInfo fileInfo in directory.GetFiles())
                {
                    if(IsPicture(fileInfo.FullName))
                    {
                        listBox1.Items.Add(fileInfo.FullName);
                    }
                }
            }
        }
        #region 移除项目和清空列表
        private void MenuItem_Remove_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count == 0)
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

    }
}
