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

        private void InsertImageToExcel()
        {

        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            //创建新文件
            if (true)
            {
                string folderPath = "";
                folderPath = GetFolder();
                if (folderPath == string.Empty)
                {
                    return;
                }

                //获取文件名
                List<string> files = GetFiles(folderPath, ".png;.bmp;.jpg");
                Random random = new Random();

                string fileName = "./图片列表" + random.Next(1, 1000) + ".xlsx";
                while (File.Exists(fileName))
                {
                    fileName = "./图片列表" + random.Next(1, 1000) + ".xlsx";
                }
                //Excel部分
                FileInfo excelFile = new FileInfo(fileName);
                ExcelPackage excel = new ExcelPackage(excelFile);
                ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("List");
                ExcelPicture excelPicture = null;
                ExcelRow excelRow;
                ExcelColumn excelColumn;
                int row = 2;
                int column = 3;
                string name;
                string extension;
                int counter = 0;
                string tempImgFile = "";
                //循环处理文件名
                foreach (string s in files)
                {
                    name = Path.GetFileNameWithoutExtension(s);
                    //获取文件扩展名
                    extension = Path.GetExtension(s).Remove(0, 1);
                    //文件名
                    worksheet.Cells[row, 1].Value = name;
                    worksheet.Cells[row, 1].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin, Color.Black);
                    excelRow = worksheet.Row(row);
                    excelColumn = worksheet.Column(column);
                    excelRow.Height = 100.0;
                    excelColumn.Width = 18.0;

                    //复制文件到临时目录
                    try
                    {
                        //找一个合适的文件名
                        while (File.Exists(TempPath + "\\" + counter.ToString() + extension))
                        {
                            counter++;
                        }

                        tempImgFile = TempPath + "\\" + counter.ToString() + extension;
                        //将文件复制到临时文件夹中
                        File.Copy(s, tempImgFile);
                    }
                    catch (Exception)
                    {
                        return;
                    }

                    excelPicture = worksheet.Drawings.AddPicture(name, new FileInfo(tempImgFile));
                    //调整图片的位置到单元格内
                    excelPicture.SetPosition(row - 1, 0, column - 1, 0);
                    excelPicture.SetSize(127, 130);
                    row++;
                    //删除临时文件
                    File.Delete(tempImgFile);
                }

                excelPicture.AdjustPositionAndSize();
                excel.Save();
                excel = null;
                worksheet = null;
                excelPicture = null;
                excelColumn = null;
                excelRow = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SwitchSettingPanelVisible(true);
            IsSettingPanelVisible = false;
        }

        bool IsSettingPanelVisible = true;

        private void Btn_SwitchSetPanel_Click(object sender, EventArgs e)
        {
            if(IsSettingPanelVisible == true)
            {
                SwitchSettingPanelVisible(true);
            }
            else
            {
                SwitchSettingPanelVisible(false);
            }
        }

        private void SwitchSettingPanelVisible(bool CurrentStatus)
        {
            if(CurrentStatus == true)
            {
                this.Width = this.Width - (Panel_Setting.Width);
                Panel_Setting.Visible = false;
                IsSettingPanelVisible = false;
            }
            else
            {
                Panel_Setting.Visible = true;
                this.Width = this.Width + (Panel_Setting.Width);
                IsSettingPanelVisible = true;
            }
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

        private void ChkBox_UseImgName_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkBox_UseImgName.Checked == true)
            {
                TxtBox_ImgNameColIndex.Enabled = true;
            }
            else
            {
                TxtBox_ImgNameColIndex.Enabled = false;
            }
        }
    }
}
