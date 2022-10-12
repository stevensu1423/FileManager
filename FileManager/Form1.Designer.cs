namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.labelFolderName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.radioNumber = new System.Windows.Forms.RadioButton();
            this.radioButtomLine = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblCopy = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.radioCreateTime = new System.Windows.Forms.RadioButton();
            this.radioModifyTime = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioChangeName = new System.Windows.Forms.RadioButton();
            this.radioNoOveride = new System.Windows.Forms.RadioButton();
            this.radioOveride = new System.Windows.Forms.RadioButton();
            this.backgroundWorkerCount = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(11, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "選擇路徑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelFolderName
            // 
            this.labelFolderName.AutoSize = true;
            this.labelFolderName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelFolderName.Location = new System.Drawing.Point(106, 15);
            this.labelFolderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFolderName.Name = "labelFolderName";
            this.labelFolderName.Size = new System.Drawing.Size(0, 16);
            this.labelFolderName.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(10, 43);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "建立資料夾";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(118, 48);
            this.fileName.Margin = new System.Windows.Forms.Padding(2);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(167, 22);
            this.fileName.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(11, 76);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "依時間建立資料夾";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "開始";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "結束";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(366, 78);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // radioNumber
            // 
            this.radioNumber.AutoSize = true;
            this.radioNumber.Checked = true;
            this.radioNumber.Location = new System.Drawing.Point(8, 18);
            this.radioNumber.Name = "radioNumber";
            this.radioNumber.Size = new System.Drawing.Size(59, 16);
            this.radioNumber.TabIndex = 13;
            this.radioNumber.TabStop = true;
            this.radioNumber.Text = "純數字";
            this.radioNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtomLine
            // 
            this.radioButtomLine.AutoSize = true;
            this.radioButtomLine.Location = new System.Drawing.Point(68, 18);
            this.radioButtomLine.Name = "radioButtomLine";
            this.radioButtomLine.Size = new System.Drawing.Size(59, 16);
            this.radioButtomLine.TabIndex = 14;
            this.radioButtomLine.Text = "依底線";
            this.radioButtomLine.UseVisualStyleBackColor = true;
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Location = new System.Drawing.Point(129, 18);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(59, 16);
            this.radioLine.TabIndex = 15;
            this.radioLine.Text = "依橫線";
            this.radioLine.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(9, 126);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 24);
            this.button4.TabIndex = 16;
            this.button4.Text = "複製檔案快速分類";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(158, 126);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 24);
            this.button5.TabIndex = 17;
            this.button5.Text = "複製路徑";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(366, 126);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 24);
            this.button6.TabIndex = 18;
            this.button6.Text = "目標路徑";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Location = new System.Drawing.Point(258, 133);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(0, 12);
            this.lblCopy.TabIndex = 19;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(466, 133);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(0, 12);
            this.lblTarget.TabIndex = 20;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(572, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "注意! 資料夾格式為依照日期可選擇純數字、依底線、依橫線呈現方式為20221009、2022_10_09、2022-10-09";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioCreateTime
            // 
            this.radioCreateTime.AutoSize = true;
            this.radioCreateTime.Checked = true;
            this.radioCreateTime.Location = new System.Drawing.Point(4, 18);
            this.radioCreateTime.Margin = new System.Windows.Forms.Padding(2);
            this.radioCreateTime.Name = "radioCreateTime";
            this.radioCreateTime.Size = new System.Drawing.Size(107, 16);
            this.radioCreateTime.TabIndex = 22;
            this.radioCreateTime.TabStop = true;
            this.radioCreateTime.Text = "依建立日期分類";
            this.radioCreateTime.UseVisualStyleBackColor = true;
            // 
            // radioModifyTime
            // 
            this.radioModifyTime.AutoSize = true;
            this.radioModifyTime.Location = new System.Drawing.Point(116, 18);
            this.radioModifyTime.Margin = new System.Windows.Forms.Padding(2);
            this.radioModifyTime.Name = "radioModifyTime";
            this.radioModifyTime.Size = new System.Drawing.Size(107, 16);
            this.radioModifyTime.TabIndex = 23;
            this.radioModifyTime.Text = "依修改日期分類";
            this.radioModifyTime.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCreateTime);
            this.groupBox1.Controls.Add(this.radioModifyTime);
            this.groupBox1.Location = new System.Drawing.Point(9, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(231, 45);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分類方式";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioNumber);
            this.groupBox2.Controls.Add(this.radioButtomLine);
            this.groupBox2.Controls.Add(this.radioLine);
            this.groupBox2.Location = new System.Drawing.Point(250, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(189, 45);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "";
            this.groupBox2.Text = "資料夾格式";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            this.eventLog1.EntryWritten += new System.Diagnostics.EntryWrittenEventHandler(this.eventLog1_EntryWritten);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioChangeName);
            this.groupBox3.Controls.Add(this.radioNoOveride);
            this.groupBox3.Controls.Add(this.radioOveride);
            this.groupBox3.Location = new System.Drawing.Point(457, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 43);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "重複檔案(test)";
            // 
            // radioChangeName
            // 
            this.radioChangeName.AutoSize = true;
            this.radioChangeName.Location = new System.Drawing.Point(126, 15);
            this.radioChangeName.Name = "radioChangeName";
            this.radioChangeName.Size = new System.Drawing.Size(71, 16);
            this.radioChangeName.TabIndex = 2;
            this.radioChangeName.TabStop = true;
            this.radioChangeName.Text = "修改名稱";
            this.radioChangeName.UseVisualStyleBackColor = true;
            this.radioChangeName.Visible = false;
            // 
            // radioNoOveride
            // 
            this.radioNoOveride.AutoSize = true;
            this.radioNoOveride.Location = new System.Drawing.Point(60, 16);
            this.radioNoOveride.Name = "radioNoOveride";
            this.radioNoOveride.Size = new System.Drawing.Size(59, 16);
            this.radioNoOveride.TabIndex = 1;
            this.radioNoOveride.TabStop = true;
            this.radioNoOveride.Text = "不覆蓋";
            this.radioNoOveride.UseVisualStyleBackColor = true;
            // 
            // radioOveride
            // 
            this.radioOveride.AutoSize = true;
            this.radioOveride.Checked = true;
            this.radioOveride.Location = new System.Drawing.Point(6, 17);
            this.radioOveride.Name = "radioOveride";
            this.radioOveride.Size = new System.Drawing.Size(47, 16);
            this.radioOveride.TabIndex = 0;
            this.radioOveride.TabStop = true;
            this.radioOveride.Text = "覆蓋";
            this.radioOveride.UseVisualStyleBackColor = true;
            this.radioOveride.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // backgroundWorkerCount
            // 
            this.backgroundWorkerCount.WorkerReportsProgress = true;
            this.backgroundWorkerCount.WorkerSupportsCancellation = true;
            this.backgroundWorkerCount.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCount_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 229);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelFolderName);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "快速產生資料夾(Beta)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelFolderName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton radioNumber;
        private System.Windows.Forms.RadioButton radioButtomLine;
        private System.Windows.Forms.RadioButton radioLine;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.Label lblTarget;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioCreateTime;
        private System.Windows.Forms.RadioButton radioModifyTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioChangeName;
        private System.Windows.Forms.RadioButton radioNoOveride;
        private System.Windows.Forms.RadioButton radioOveride;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCount;
    }
}

