using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{


    public partial class Form1 : Form
    {
        BackgroundWorker worker;

        public class Global
        {
            public static string FOLDER_NAME = "";
            public static string COPY_PATH = "";
            public static string TARGET_PATH = "";
            public static int COUNT = 0;
        }

        public Form1()
        {
            MessageBox.Show("此程式為測試版，請斟酌使用，如檔案損失，本作者一蓋不負責", "注意!");
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            openFileDialog.Description = "請選擇目標路徑";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folderName = openFileDialog.SelectedPath;
                labelFolderName.Text = folderName;
                Global.FOLDER_NAME = folderName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Global.FOLDER_NAME.Equals(""))
            {
                MessageBox.Show("請先選擇目標資料夾", "注意!");

            }
            else if (fileName.Text == "")
            {
                MessageBox.Show("請先輸入資料夾名稱", "注意!");

            }
            else
            {
                if (Directory.Exists(Global.FOLDER_NAME))
                {
                    if (Directory.Exists(Global.FOLDER_NAME + "\\" + fileName.Text))
                    {
                        MessageBox.Show("資料夾已經存在了喔", "注意!");
                    }
                    else
                    {
                        Directory.CreateDirectory(Global.FOLDER_NAME + "\\" + fileName.Text);
                        MessageBox.Show("成功新增" + fileName.Text + "資料夾", "通知!");

                    }
                }
            }


        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt_start = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            DateTime dt_end = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
            Console.WriteLine("開始時間 : " + dt_start.Date);
            Console.WriteLine("結束時間 : " + dt_end.Date);
            int duplicate = 0;
            int num = 0;

            if (Global.FOLDER_NAME.Equals(""))
            {
                MessageBox.Show("請先選擇目標資料夾", "注意!");

            }
            else
            {
                DateTime temp = dt_start < dt_end ? dt_start : dt_end;
                DateTime temp_end = dt_start > dt_end ? dt_start : dt_end;

                for (DateTime temp_start = temp; temp_start <= temp_end; temp_start = temp_start.AddDays(1))
                {
                    Console.WriteLine("正在新增");
                    string month = temp_start.Date.Month < 10 ? "0" + temp_start.Date.Month : temp_start.Date.Month + "";
                    string day = temp_start.Date.Day < 10 ? "0" + temp_start.Date.Day : temp_start.Date.Day + "";
                    string folderName = temp_start.Date.Year + "" + month + "" + day;
                    if (radioNumber.Checked)
                        folderName = temp_start.Date.Year + "" + month + "" + day;
                    else if (radioButtomLine.Checked)
                        folderName = temp_start.Date.Year + "_" + month + "_" + day;
                    else if (radioLine.Checked)
                        folderName = temp_start.Date.Year + "-" + month + "-" + day;

                    Console.WriteLine("folder name : " + folderName);

                    if (Directory.Exists(Global.FOLDER_NAME))
                    {
                        if (Directory.Exists(Global.FOLDER_NAME + "\\" + folderName))
                        {
                            duplicate++;
                            Console.WriteLine("資料夾已經存在了喔" + duplicate);
                        }
                        else
                        {
                            Directory.CreateDirectory(Global.FOLDER_NAME + "\\" + folderName);
                            num++;
                            Console.WriteLine("成功新增" + num);

                        }

                    }
                }
                MessageBox.Show("成功新增" + num + "個資料夾\r\n有" + duplicate + "個重複資料夾", "通知!");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            openFileDialog.Description = "請選擇複製路徑";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folderName = openFileDialog.SelectedPath;
                if (folderName.Length > 10)
                    folderName = folderName.Substring(0, 10) + "...";
                lblCopy.Text = folderName;

                Global.COPY_PATH = openFileDialog.SelectedPath;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            openFileDialog.Description = "請選擇目標路徑";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folderName = openFileDialog.SelectedPath;
                if (folderName.Length > 10)
                    folderName = folderName.Substring(0, 10) + "...";
                lblTarget.Text = folderName;
                Global.TARGET_PATH = openFileDialog.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // button4.Enabled = false;
            if (Global.COPY_PATH != "" && Global.TARGET_PATH != "")
            {
                Global.COUNT = 0;
                System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(Global.COPY_PATH);
                int filesCount = GetAllFilesCount(dirInfo);
                this.backgroundWorker1.RunWorkerAsync(); // 运行 backgroundWorker 组件
                ProgressForm form = new ProgressForm(this.backgroundWorker1, filesCount);// 显示进度条窗体
                form.ShowDialog(this);
                form.Close();
            }
            else if (Global.COPY_PATH == "")
            {
                MessageBox.Show("請選擇複製路徑", "注意!");
                Console.WriteLine("Source path does not exist!");
            }
            else if (Global.TARGET_PATH == "")
            {
                MessageBox.Show("請選擇目標路徑", "注意!");
            }
            //  BackgroundWorker worker = sender as BackgroundWorker;


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private delegate void SetPos(int ipos, int vinfo, int fileNum);

        private void SetTextMesssage(int ipos, int vinfo, int fileNum)
        {
            if (this.InvokeRequired)
            {
                SetPos setpos = new SetPos(SetTextMesssage);
                this.Invoke(setpos, new object[] { ipos, vinfo });
            }
            else
            {
                // this.lblProgress.Text = vinfo.ToString() + "/" + fileNum;
                //if(vinfo==fileNum)
                //   this.lblProgress.Text = vinfo.ToString() + "/" + fileNum+" 完成!";
                // this.copyProgress.Value = Convert.ToInt32(ipos);
                //this.textBox1.AppendText(vinfo);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
            }
            else
            {
            }
        }


        private void btnCancelCopy_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            worker = sender as BackgroundWorker;
            RunState state = new RunState();
            string fileName = "";
            string destFile = "";
            int num = 0;
            int createdFolder = 0;
            if (System.IO.Directory.Exists(Global.COPY_PATH))
            {
                int i = 1;
                string[] files = System.IO.Directory.GetFiles(Global.COPY_PATH);
                string[] folders = System.IO.Directory.GetDirectories(Global.COPY_PATH);
                System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(Global.COPY_PATH);
                int filesCount = GetAllFilesCount(dirInfo);
                int fileCreateYear, fileCreateMonth, fileCreateDay;
                if (files.Length > 1)
                {
                    // copyProgress.Visible = true;
                    //  lblProgress.Visible = true;                    
                }
                // Copy the files and overwrite destination files if they already exist.
                Console.WriteLine("檔案數量 : " + filesCount);
                foreach (string s in files)
                {

                    if (worker.CancellationPending)
                    {  // 如果用户取消则跳出处理数据代码 
                        e.Cancel = true;
                        break;
                    }


                    Console.WriteLine(s + "");
                    fileName = System.IO.Path.GetFileName(s);
                    if (radioCreateTime.Checked)
                    {
                        fileCreateYear = File.GetCreationTime(s).Date.Year;
                        fileCreateMonth = File.GetCreationTime(s).Date.Month;
                        fileCreateDay = File.GetCreationTime(s).Date.Day;
                    }
                    else
                    {
                        fileCreateYear = File.GetLastWriteTime(s).Date.Year;
                        fileCreateMonth = File.GetLastWriteTime(s).Date.Month;
                        fileCreateDay = File.GetLastWriteTime(s).Date.Day;
                    }
                    Console.WriteLine("folder year : " + fileCreateYear);
                    Console.WriteLine("folder month : " + fileCreateMonth);
                    Console.WriteLine("folder day : " + fileCreateDay);


                    string month = fileCreateMonth < 10 ? "0" + fileCreateMonth : fileCreateMonth + "";
                    string day = fileCreateDay < 10 ? "0" + fileCreateDay : fileCreateDay + "";
                    string folderName = fileCreateYear + "" + month + "" + day;
                    if (radioNumber.Checked)
                        folderName = fileCreateYear + "" + month + "" + day;
                    else if (radioButtomLine.Checked)
                        folderName = fileCreateYear + "_" + month + "_" + day;
                    else if (radioLine.Checked)
                        folderName = fileCreateYear + "-" + month + "-" + day;

                    Console.WriteLine("folder name : " + folderName);
                    if (Directory.Exists(Global.COPY_PATH))
                    {
                        if (Directory.Exists(Global.TARGET_PATH))
                        {

                            if (!Directory.Exists(Global.TARGET_PATH + "\\" + folderName))
                            {
                                Directory.CreateDirectory(Global.TARGET_PATH + "\\" + folderName);
                                createdFolder++;
                            }
                            if (Directory.Exists(Global.TARGET_PATH + "\\" + folderName))
                            {
                                createdFolder++;
                                destFile = System.IO.Path.Combine(Global.TARGET_PATH + "\\" + folderName, fileName);
                                System.IO.File.Copy(s, destFile, true);
                                num++;
                            }


                        }
                    }
                    else
                    {
                        MessageBox.Show("複製路徑已消失", "錯誤!");
                        e.Cancel = true;
                        break;
                    }
                    state.set_Count(Global.COUNT);
                    //Thread.Sleep(100);
                    // worker.ReportProgress(100 * i / files.Length);
                    // i++;
                    worker.ReportProgress(100 * Global.COUNT /filesCount, Global.COUNT);
                    Global.COUNT++;
                }
                foreach (string s in folders)
                {
                    if (worker.CancellationPending)
                    {  // 如果用户取消则跳出处理数据代码 
                        e.Cancel = true;
                        break;
                    }


                    fileName = System.IO.Path.GetFileName(s);
                    Console.WriteLine("folderName is " + fileName);

                    if (radioCreateTime.Checked)
                    {
                        fileCreateYear = Directory.GetCreationTime(s).Date.Year;
                        fileCreateMonth = Directory.GetCreationTime(s).Date.Month;
                        fileCreateDay = Directory.GetCreationTime(s).Date.Day;
                    }
                    else
                    {
                        fileCreateYear = Directory.GetLastWriteTime(s).Date.Year;
                        fileCreateMonth = Directory.GetLastWriteTime(s).Date.Month;
                        fileCreateDay = Directory.GetLastWriteTime(s).Date.Day;
                    }
                    Console.WriteLine("folder year : " + fileCreateYear);
                    Console.WriteLine("folder month : " + fileCreateMonth);
                    Console.WriteLine("folder day : " + fileCreateDay);


                    string month = fileCreateMonth < 10 ? "0" + fileCreateMonth : fileCreateMonth + "";
                    string day = fileCreateDay < 10 ? "0" + fileCreateDay : fileCreateDay + "";
                    string folderName = fileCreateYear + "" + month + "" + day;
                    if (radioNumber.Checked)
                        folderName = fileCreateYear + "" + month + "" + day;
                    else if (radioButtomLine.Checked)
                        folderName = fileCreateYear + "_" + month + "_" + day;
                    else if (radioLine.Checked)
                        folderName = fileCreateYear + "-" + month + "-" + day;
                    if (Directory.Exists(Global.COPY_PATH))
                    {
                        if (Directory.Exists(Global.TARGET_PATH))
                        {

                            if (!Directory.Exists(Global.TARGET_PATH + "\\" + folderName))
                            {
                                Directory.CreateDirectory(Global.TARGET_PATH + "\\" + folderName);
                                createdFolder++;
                            }
                            if (Directory.Exists(Global.TARGET_PATH + "\\" + folderName))
                            {
                                CopyDirectory(Global.COPY_PATH + "\\" + fileName, Global.TARGET_PATH + "\\" + folderName + "\\" + fileName, Global.TARGET_PATH + "\\" + folderName + "\\" + fileName, false, i, filesCount);
                                num++;
                            }


                        }
                    }

                }

                DialogResult result = MessageBox.Show("檔案轉移完成\r\n共" + num + "個檔案\r\n" + createdFolder + "個資料夾被建立", "通知!", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    // copyProgress.Value = 0;
                    // lblProgress.Text = "";
                }
                //button4.Enabled = true;

            }
            else if (Global.COPY_PATH == "")
            {
                MessageBox.Show("請選擇複製路徑", "注意!");
                Console.WriteLine("Source path does not exist!");
            }
            else if (Global.TARGET_PATH == "")
            {
                MessageBox.Show("請選擇目標路徑", "注意!");
            }
            //for (int i = 0; i < 100; i++)
            //{
            //   Thread.Sleep(100);
            //     worker.ReportProgress(i);
            //       if (worker.CancellationPending)
            //         {  // 如果用户取消则跳出处理数据代码 
            //               e.Cancel = true;
            //                 break;
            //               }
            //            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        public static int GetAllFilesCount(System.IO.DirectoryInfo DirInfo)
        {
            int total = 0;
            total += DirInfo.GetFiles().Length;
            foreach(System.IO.DirectoryInfo subdir in DirInfo.GetDirectories())
            {
                total += GetAllFilesCount(subdir);
            }
            return total;

        }
        public class RunState
        {
            public int count = 0;
            public string folderPath = "";
            public RunState()
            {
                count = 0;
                folderPath = "";
            }
            public void set_Count(int count)
            {
                this.count = count;
            }
            public int get_Count()
            {
                return count;
            }
            public void set_FolderPath(string folderPath)
            {
                this.folderPath = folderPath;
            }
            public string get_FolderPath()
            {
                return folderPath;
            }
        }
        private  bool CopyDirectory(string SourcePath, string DestinationPath, string targetPath,bool overwriteexisting,int count,int fileCount)
        {   
            bool ret = false;
            try
            {
                RunState state = new RunState();
                SourcePath = SourcePath.EndsWith(@"\") ? SourcePath : SourcePath + @"\";
                DestinationPath = DestinationPath.EndsWith(@"\") ? DestinationPath : DestinationPath + @"\";

                if (Directory.Exists(SourcePath))
                {
                    if (Directory.Exists(DestinationPath) == false)
                        Directory.CreateDirectory(DestinationPath);

                    foreach (string fls in Directory.GetFiles(SourcePath))
                    {
                        FileInfo flinfo = new FileInfo(fls);
                        flinfo.CopyTo(DestinationPath +"\\" +flinfo.Name, overwriteexisting);
                        Console.WriteLine("Count is " + Global.COUNT);
                        //Thread.Sleep(100);
                        //worker.ReportProgress(100 * count / fileCount);
                        //count++;
                        //state.set_Count(Global.COUNT);
                        worker.ReportProgress(100 * Global.COUNT / fileCount, Global.COUNT);
                        Global.COUNT++;
                    }
                    foreach (string drs in Directory.GetDirectories(SourcePath))
                    {
                        DirectoryInfo drinfo = new DirectoryInfo(drs);
                        if (CopyDirectory(drs, DestinationPath + drinfo.Name,targetPath, overwriteexisting,count, fileCount) == false)
                            ret = false;
                    }
                }
                ret = true;
            }
            catch (Exception ex)
            {
                ret = false;
            }
            return ret;

        }
    }
}
    