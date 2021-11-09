using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;   //get Excel com

namespace FileExcelSave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FileInfo fileInfo = null;   //file info 
        string filePath = "";       

        private void btnPath_Click(object sender, EventArgs e)  //select file with dialog
        {
            if(this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                foreach(string f in this.ofdFile.FileNames)
                {
                    fileInfo = new FileInfo(f);
                    this.lvFile.Items.Add(new ListViewItem(new string[]
                    {
                        fileInfo.Name, 
                        fileInfo.LastWriteTime.ToString(), 
                        fileInfo.Extension.Split('.')[1], 
                        GetFileSize(fileInfo.Length), 
                        fileInfo.FullName
                    }));
                }
            }
        }

        private string GetFileSize(double byteCount)    //calculate file size
        {
            string size = "0 Bytes";
            if(byteCount >= 1073741824.0)
            {
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            }else if(byteCount >= 1048576.0)
            {
                size = String.Format("{0.##.##}", byteCount / 1048576.0) + " MB";
            }else if(byteCount >= 1024.0)
            {
                size = String.Format("{0.##.##}", byteCount / 1024.0) + " KB";
            }else if(byteCount > 0 && byteCount < 1024.0)
            {
                size = byteCount.ToString() + " Bytes";
            }

            return size;
        }

        private void btnSave_Click(object sender, EventArgs e)  //save file with selected type
        {
            if(this.lvFile.Items.Count == 0)    //no select file
            {
                MessageBox.Show("저장할 파일 정보가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.rbText.Checked == true)    //select txt file
            {
                this.sfdFile.Filter = "텍스트 파일(*.txt) | *.txt";
                if(this.sfdFile.ShowDialog() == DialogResult.OK)
                {
                    filePath = this.sfdFile.FileName;
                    TxtSave();
                }
            }
            else    //select excel file
            { 
                this.sfdFile.Filter = "엑셀 파일(*.xlsx) | *.xlsx";
                if(this.sfdFile.ShowDialog() == DialogResult.OK)
                {
                    filePath = this.sfdFile.FileName;
                    ExcelSave();
                }
            }
        }

        private void ExcelSave()    //save type of excel file
        {
            Excel.Application eApp;
            Excel.Workbook eWorkbook;
            Excel.Worksheet eWorksheet;     

            string[,] data;

            eApp = new Excel.Application();                     //get excel app
            eWorkbook = eApp.Workbooks.Add(true);               //get workbooks
            eWorksheet = (Excel.Worksheet)eWorkbook.Sheets[1];  //get excel worksheet

            int rowNum = this.lvFile.Items.Count + 1;
            int colNum = 5;

            data = new string[rowNum, colNum];
            data[0, 0] = "이름";
            data[0, 1] = "수정한 날짜";
            data[0, 2] = "유형";
            data[0, 3] = "크기";
            data[0, 4] = "경로";

            for(int n = 0; n < this.lvFile.Items.Count; n++)
            {
                for(int i = 0; i < this.lvFile.Items[n].SubItems.Count; i++)
                {
                    data[n + 1, i] = this.lvFile.Items[n].SubItems[i].Text;
                }
            }
            string endStr = "E" + rowNum.ToString();
            eWorksheet.get_Range("A1 : " + endStr).Value2 = data;

            //save file .xsml
            eWorkbook.SaveAs2(filePath, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing,
                Type.Missing, false, false, Excel.XlSaveAsAccessMode.xlShared, false, false, Type.Missing, Type.Missing);
            eWorkbook.Close(false, Type.Missing, Type.Missing);
            eApp.Quit();
        }

        private void TxtSave()  //save file type of .txt
        {
            using(StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("이름" + "\t" + "수정한 날짜" + "\t" + "유형" + "\t" + "크기" + "\t" + "경로" + "\t");
                for(int n = 0; n < this.lvFile.Items.Count; n++)
                {
                    string info = "";
                    for(int i = 0; i < this.lvFile.Items[n].SubItems.Count; i++)
                    {
                        info += this.lvFile.Items[n].SubItems[i].Text + "\t";
                    }
                    sw.WriteLine(info);
                }
                sw.Close();
            }
        }
    }
}
