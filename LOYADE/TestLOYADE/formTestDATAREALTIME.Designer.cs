namespace TestLOYADE
{
    partial class formTestDATAREALTIME
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
            this.timerGetMem = new System.Windows.Forms.Timer(this.components);
            this.buttonSCADA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVC0 = new System.Windows.Forms.TextBox();
            this.txtVC1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVC2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVC3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVC4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMemSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThreadCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFreq = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.txtMemUpper = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDC4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDC3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDC2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDC1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSCADACount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonDT = new System.Windows.Forms.Button();
            this.buttonGenData = new System.Windows.Forms.Button();
            this.buttonCQStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerGetMem
            // 
            this.timerGetMem.Interval = 1000;
            this.timerGetMem.Tick += new System.EventHandler(this.timerGetMem_Tick);
            // 
            // buttonSCADA
            // 
            this.buttonSCADA.Location = new System.Drawing.Point(495, 197);
            this.buttonSCADA.Name = "buttonSCADA";
            this.buttonSCADA.Size = new System.Drawing.Size(75, 23);
            this.buttonSCADA.TabIndex = 0;
            this.buttonSCADA.Text = "开始采集";
            this.buttonSCADA.UseVisualStyleBackColor = true;
            this.buttonSCADA.Click += new System.EventHandler(this.buttonSCADA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "0层变量数";
            // 
            // txtVC0
            // 
            this.txtVC0.Location = new System.Drawing.Point(39, 44);
            this.txtVC0.MaxLength = 5;
            this.txtVC0.Name = "txtVC0";
            this.txtVC0.Size = new System.Drawing.Size(100, 21);
            this.txtVC0.TabIndex = 2;
            this.txtVC0.Text = "200";
            // 
            // txtVC1
            // 
            this.txtVC1.Location = new System.Drawing.Point(158, 95);
            this.txtVC1.MaxLength = 5;
            this.txtVC1.Name = "txtVC1";
            this.txtVC1.Size = new System.Drawing.Size(100, 21);
            this.txtVC1.TabIndex = 4;
            this.txtVC1.Text = "50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "1层变量数";
            // 
            // txtVC2
            // 
            this.txtVC2.Location = new System.Drawing.Point(158, 146);
            this.txtVC2.MaxLength = 5;
            this.txtVC2.Name = "txtVC2";
            this.txtVC2.Size = new System.Drawing.Size(100, 21);
            this.txtVC2.TabIndex = 6;
            this.txtVC2.Text = "300";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "2层变量数";
            // 
            // txtVC3
            // 
            this.txtVC3.Location = new System.Drawing.Point(158, 197);
            this.txtVC3.MaxLength = 5;
            this.txtVC3.Name = "txtVC3";
            this.txtVC3.Size = new System.Drawing.Size(100, 21);
            this.txtVC3.TabIndex = 8;
            this.txtVC3.Text = "1200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "3层变量数";
            // 
            // txtVC4
            // 
            this.txtVC4.Location = new System.Drawing.Point(158, 248);
            this.txtVC4.MaxLength = 5;
            this.txtVC4.Name = "txtVC4";
            this.txtVC4.Size = new System.Drawing.Size(100, 21);
            this.txtVC4.TabIndex = 10;
            this.txtVC4.Text = "4800";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "4层变量数";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 146);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "假设已采集条数";
            // 
            // txtMemSize
            // 
            this.txtMemSize.Location = new System.Drawing.Point(468, 44);
            this.txtMemSize.Name = "txtMemSize";
            this.txtMemSize.ReadOnly = true;
            this.txtMemSize.Size = new System.Drawing.Size(100, 21);
            this.txtMemSize.TabIndex = 14;
            this.txtMemSize.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "当前内存占用（MB）";
            // 
            // txtThreadCount
            // 
            this.txtThreadCount.Location = new System.Drawing.Point(304, 197);
            this.txtThreadCount.MaxLength = 3;
            this.txtThreadCount.Name = "txtThreadCount";
            this.txtThreadCount.Size = new System.Drawing.Size(100, 21);
            this.txtThreadCount.TabIndex = 16;
            this.txtThreadCount.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "模拟采集线程数";
            // 
            // txtFreq
            // 
            this.txtFreq.Location = new System.Drawing.Point(304, 248);
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(100, 21);
            this.txtFreq.TabIndex = 18;
            this.txtFreq.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "模拟采集周期（ms）";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(495, 248);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 19;
            this.buttonStop.Text = "停止采集";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // txtMemUpper
            // 
            this.txtMemUpper.Location = new System.Drawing.Point(304, 95);
            this.txtMemUpper.MaxLength = 10;
            this.txtMemUpper.Name = "txtMemUpper";
            this.txtMemUpper.Size = new System.Drawing.Size(100, 21);
            this.txtMemUpper.TabIndex = 21;
            this.txtMemUpper.Text = "2000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "内存上限（MB）";
            // 
            // txtDC4
            // 
            this.txtDC4.Location = new System.Drawing.Point(39, 248);
            this.txtDC4.MaxLength = 5;
            this.txtDC4.Name = "txtDC4";
            this.txtDC4.Size = new System.Drawing.Size(100, 21);
            this.txtDC4.TabIndex = 29;
            this.txtDC4.Text = "40";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "4层平均设备点数";
            // 
            // txtDC3
            // 
            this.txtDC3.Location = new System.Drawing.Point(39, 197);
            this.txtDC3.MaxLength = 5;
            this.txtDC3.Name = "txtDC3";
            this.txtDC3.Size = new System.Drawing.Size(100, 21);
            this.txtDC3.TabIndex = 27;
            this.txtDC3.Text = "20";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "3层平均设备点数";
            // 
            // txtDC2
            // 
            this.txtDC2.Location = new System.Drawing.Point(39, 146);
            this.txtDC2.MaxLength = 5;
            this.txtDC2.Name = "txtDC2";
            this.txtDC2.Size = new System.Drawing.Size(100, 21);
            this.txtDC2.TabIndex = 25;
            this.txtDC2.Text = "15";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "2层平均设备点数";
            // 
            // txtDC1
            // 
            this.txtDC1.Location = new System.Drawing.Point(39, 95);
            this.txtDC1.MaxLength = 5;
            this.txtDC1.Name = "txtDC1";
            this.txtDC1.Size = new System.Drawing.Size(100, 21);
            this.txtDC1.TabIndex = 23;
            this.txtDC1.Text = "10";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 12);
            this.label14.TabIndex = 22;
            this.label14.Text = "1层平均设备点数";
            // 
            // txtSCADACount
            // 
            this.txtSCADACount.Location = new System.Drawing.Point(468, 95);
            this.txtSCADACount.Name = "txtSCADACount";
            this.txtSCADACount.ReadOnly = true;
            this.txtSCADACount.Size = new System.Drawing.Size(100, 21);
            this.txtSCADACount.TabIndex = 31;
            this.txtSCADACount.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(468, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 12);
            this.label15.TabIndex = 30;
            this.label15.Text = "当前模拟采集次数";
            // 
            // buttonDT
            // 
            this.buttonDT.Location = new System.Drawing.Point(304, 42);
            this.buttonDT.Name = "buttonDT";
            this.buttonDT.Size = new System.Drawing.Size(75, 23);
            this.buttonDT.TabIndex = 32;
            this.buttonDT.Text = "变量表";
            this.buttonDT.UseVisualStyleBackColor = true;
            this.buttonDT.Click += new System.EventHandler(this.buttonDT_Click);
            // 
            // buttonGenData
            // 
            this.buttonGenData.Location = new System.Drawing.Point(158, 43);
            this.buttonGenData.Name = "buttonGenData";
            this.buttonGenData.Size = new System.Drawing.Size(75, 23);
            this.buttonGenData.TabIndex = 33;
            this.buttonGenData.Text = "生成变量";
            this.buttonGenData.UseVisualStyleBackColor = true;
            this.buttonGenData.Click += new System.EventHandler(this.buttonGenData_Click);
            // 
            // buttonCQStore
            // 
            this.buttonCQStore.Location = new System.Drawing.Point(495, 144);
            this.buttonCQStore.Name = "buttonCQStore";
            this.buttonCQStore.Size = new System.Drawing.Size(75, 23);
            this.buttonCQStore.TabIndex = 34;
            this.buttonCQStore.Text = "转存区";
            this.buttonCQStore.UseVisualStyleBackColor = true;
            this.buttonCQStore.Click += new System.EventHandler(this.buttonCQStore_Click);
            // 
            // formTestDATAREALTIME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 305);
            this.Controls.Add(this.buttonCQStore);
            this.Controls.Add(this.buttonGenData);
            this.Controls.Add(this.buttonDT);
            this.Controls.Add(this.txtSCADACount);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDC4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDC3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDC2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDC1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMemUpper);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.txtFreq);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtThreadCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMemSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVC4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVC3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVC2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVC1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVC0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSCADA);
            this.Name = "formTestDATAREALTIME";
            this.Text = "测试内存数据库";
            this.Load += new System.EventHandler(this.formTestDATAREALTIME_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerGetMem;
        private System.Windows.Forms.Button buttonSCADA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVC0;
        private System.Windows.Forms.TextBox txtVC1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVC2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVC3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVC4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMemSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThreadCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFreq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox txtMemUpper;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDC4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDC3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDC2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDC1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSCADACount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonDT;
        private System.Windows.Forms.Button buttonGenData;
        private System.Windows.Forms.Button buttonCQStore;
    }
}

