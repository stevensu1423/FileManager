using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class ProgressForm : Form
    {
        
        private BackgroundWorker backgroundWorker1;
        public ProgressForm(BackgroundWorker backgroundWorker1,int Total)
        {
            InitializeComponent();
            this.lblProcess.Text =  "0%";
            this.lblTotal.Text = Total.ToString();
            this.backgroundWorker1 = backgroundWorker1;
            this.backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }
        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
            //this.Close();//执行完之后，直接关闭页面
        }
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            RunState state = e.UserState as RunState;
            this.lblCount.Text = state.get_Count().ToString();
            this.lblTotal.Text = state.get_FileCount().ToString();
            this.lblPath.Text = state.get_FolderPath().ToString();
            this.progressBar1.Value = e.ProgressPercentage;
            this.lblProcess.Text = e.ProgressPercentage + "%";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.CancelAsync();
            this.button1.Enabled = false;
            this.Close();
        }


    

    
    }
}
