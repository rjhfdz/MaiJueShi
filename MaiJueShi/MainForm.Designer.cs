namespace MaiJueShi
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SelectFile = new System.Windows.Forms.Label();
            this.SelectPort = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxEx1 = new MaiJueShi.GroupBoxEx(this.components);
            this.p1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.p11 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.p10 = new System.Windows.Forms.TextBox();
            this.ChangJing = new System.Windows.Forms.ComboBox();
            this.p12 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.p20 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.p13 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.p9 = new System.Windows.Forms.TextBox();
            this.p3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.p19 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.p18 = new System.Windows.Forms.TextBox();
            this.p8 = new System.Windows.Forms.TextBox();
            this.p4 = new System.Windows.Forms.TextBox();
            this.p14 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p15 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.p7 = new System.Windows.Forms.TextBox();
            this.p5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.p17 = new System.Windows.Forms.TextBox();
            this.p6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.p16 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectFile
            // 
            this.SelectFile.AutoSize = true;
            this.SelectFile.Location = new System.Drawing.Point(134, 52);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(41, 12);
            this.SelectFile.TabIndex = 18;
            this.SelectFile.Text = "文件：";
            // 
            // SelectPort
            // 
            this.SelectPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectPort.FormattingEnabled = true;
            this.SelectPort.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.SelectPort.Location = new System.Drawing.Point(861, 63);
            this.SelectPort.Name = "SelectPort";
            this.SelectPort.Size = new System.Drawing.Size(100, 20);
            this.SelectPort.TabIndex = 19;
            this.SelectPort.SelectedIndexChanged += new System.EventHandler(this.SelectPort_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(776, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "已开放端口";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 55;
            this.button2.Text = "打开文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BorderColor = System.Drawing.Color.Black;
            this.groupBoxEx1.Controls.Add(this.p1);
            this.groupBoxEx1.Controls.Add(this.label4);
            this.groupBoxEx1.Controls.Add(this.p11);
            this.groupBoxEx1.Controls.Add(this.label10);
            this.groupBoxEx1.Controls.Add(this.label12);
            this.groupBoxEx1.Controls.Add(this.label19);
            this.groupBoxEx1.Controls.Add(this.p10);
            this.groupBoxEx1.Controls.Add(this.ChangJing);
            this.groupBoxEx1.Controls.Add(this.p12);
            this.groupBoxEx1.Controls.Add(this.label2);
            this.groupBoxEx1.Controls.Add(this.label13);
            this.groupBoxEx1.Controls.Add(this.p20);
            this.groupBoxEx1.Controls.Add(this.label11);
            this.groupBoxEx1.Controls.Add(this.p2);
            this.groupBoxEx1.Controls.Add(this.label14);
            this.groupBoxEx1.Controls.Add(this.button1);
            this.groupBoxEx1.Controls.Add(this.p13);
            this.groupBoxEx1.Controls.Add(this.label20);
            this.groupBoxEx1.Controls.Add(this.p9);
            this.groupBoxEx1.Controls.Add(this.p3);
            this.groupBoxEx1.Controls.Add(this.label18);
            this.groupBoxEx1.Controls.Add(this.p19);
            this.groupBoxEx1.Controls.Add(this.label5);
            this.groupBoxEx1.Controls.Add(this.label3);
            this.groupBoxEx1.Controls.Add(this.label17);
            this.groupBoxEx1.Controls.Add(this.p18);
            this.groupBoxEx1.Controls.Add(this.p8);
            this.groupBoxEx1.Controls.Add(this.p4);
            this.groupBoxEx1.Controls.Add(this.p14);
            this.groupBoxEx1.Controls.Add(this.label21);
            this.groupBoxEx1.Controls.Add(this.label6);
            this.groupBoxEx1.Controls.Add(this.label1);
            this.groupBoxEx1.Controls.Add(this.p15);
            this.groupBoxEx1.Controls.Add(this.label22);
            this.groupBoxEx1.Controls.Add(this.p7);
            this.groupBoxEx1.Controls.Add(this.p5);
            this.groupBoxEx1.Controls.Add(this.label16);
            this.groupBoxEx1.Controls.Add(this.p17);
            this.groupBoxEx1.Controls.Add(this.p6);
            this.groupBoxEx1.Controls.Add(this.label8);
            this.groupBoxEx1.Controls.Add(this.p16);
            this.groupBoxEx1.Controls.Add(this.label15);
            this.groupBoxEx1.Controls.Add(this.label7);
            this.groupBoxEx1.Location = new System.Drawing.Point(18, 111);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Size = new System.Drawing.Size(1030, 339);
            this.groupBoxEx1.TabIndex = 57;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.Text = "端口灯珠数量分布";
            // 
            // p1
            // 
            this.p1.Enabled = false;
            this.p1.Location = new System.Drawing.Point(87, 67);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 21);
            this.p1.TabIndex = 8;
            this.p1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "端口4";
            // 
            // p11
            // 
            this.p11.Enabled = false;
            this.p11.Location = new System.Drawing.Point(498, 153);
            this.p11.Name = "p11";
            this.p11.Size = new System.Drawing.Size(100, 21);
            this.p11.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "场景";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(434, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 33;
            this.label12.Text = "端口11";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(832, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 47;
            this.label19.Text = "端口17";
            // 
            // p10
            // 
            this.p10.Enabled = false;
            this.p10.Location = new System.Drawing.Point(498, 110);
            this.p10.Name = "p10";
            this.p10.Size = new System.Drawing.Size(100, 21);
            this.p10.TabIndex = 36;
            // 
            // ChangJing
            // 
            this.ChangJing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChangJing.FormattingEnabled = true;
            this.ChangJing.Location = new System.Drawing.Point(348, 270);
            this.ChangJing.Name = "ChangJing";
            this.ChangJing.Size = new System.Drawing.Size(100, 20);
            this.ChangJing.TabIndex = 21;
            // 
            // p12
            // 
            this.p12.Enabled = false;
            this.p12.Location = new System.Drawing.Point(498, 189);
            this.p12.Name = "p12";
            this.p12.Size = new System.Drawing.Size(100, 21);
            this.p12.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(434, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 32;
            this.label13.Text = "端口10";
            // 
            // p20
            // 
            this.p20.Enabled = false;
            this.p20.Location = new System.Drawing.Point(896, 195);
            this.p20.Name = "p20";
            this.p20.Size = new System.Drawing.Size(100, 21);
            this.p20.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 31;
            this.label11.Text = "端口9";
            // 
            // p2
            // 
            this.p2.Enabled = false;
            this.p2.Location = new System.Drawing.Point(87, 104);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 21);
            this.p2.TabIndex = 9;
            this.p2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p2_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(434, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 34;
            this.label14.Text = "端口12";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "生成对应文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // p13
            // 
            this.p13.Enabled = false;
            this.p13.Location = new System.Drawing.Point(702, 76);
            this.p13.Name = "p13";
            this.p13.Size = new System.Drawing.Size(100, 21);
            this.p13.TabIndex = 43;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(832, 159);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 49;
            this.label20.Text = "端口19";
            // 
            // p9
            // 
            this.p9.Enabled = false;
            this.p9.Location = new System.Drawing.Point(498, 73);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(100, 21);
            this.p9.TabIndex = 35;
            // 
            // p3
            // 
            this.p3.Enabled = false;
            this.p3.Location = new System.Drawing.Point(87, 147);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(100, 21);
            this.p3.TabIndex = 10;
            this.p3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p3_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(638, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 42;
            this.label18.Text = "端口16";
            // 
            // p19
            // 
            this.p19.Enabled = false;
            this.p19.Location = new System.Drawing.Point(896, 159);
            this.p19.Name = "p19";
            this.p19.Size = new System.Drawing.Size(100, 21);
            this.p19.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "端口5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "端口3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(638, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 40;
            this.label17.Text = "端口14";
            // 
            // p18
            // 
            this.p18.Enabled = false;
            this.p18.Location = new System.Drawing.Point(896, 116);
            this.p18.Name = "p18";
            this.p18.Size = new System.Drawing.Size(100, 21);
            this.p18.TabIndex = 52;
            // 
            // p8
            // 
            this.p8.Enabled = false;
            this.p8.Location = new System.Drawing.Point(302, 186);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(100, 21);
            this.p8.TabIndex = 30;
            // 
            // p4
            // 
            this.p4.Enabled = false;
            this.p4.Location = new System.Drawing.Point(87, 183);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(100, 21);
            this.p4.TabIndex = 11;
            this.p4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p4_KeyPress);
            // 
            // p14
            // 
            this.p14.Enabled = false;
            this.p14.Location = new System.Drawing.Point(702, 113);
            this.p14.Name = "p14";
            this.p14.Size = new System.Drawing.Size(100, 21);
            this.p14.TabIndex = 44;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(832, 123);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 48;
            this.label21.Text = "端口18";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "端口7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口1";
            // 
            // p15
            // 
            this.p15.Enabled = false;
            this.p15.Location = new System.Drawing.Point(702, 156);
            this.p15.Name = "p15";
            this.p15.Size = new System.Drawing.Size(100, 21);
            this.p15.TabIndex = 45;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(832, 195);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 50;
            this.label22.Text = "端口20";
            // 
            // p7
            // 
            this.p7.Enabled = false;
            this.p7.Location = new System.Drawing.Point(302, 150);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(100, 21);
            this.p7.TabIndex = 29;
            // 
            // p5
            // 
            this.p5.Enabled = false;
            this.p5.Location = new System.Drawing.Point(302, 70);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(100, 21);
            this.p5.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(638, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 41;
            this.label16.Text = "端口15";
            // 
            // p17
            // 
            this.p17.Enabled = false;
            this.p17.Location = new System.Drawing.Point(896, 79);
            this.p17.Name = "p17";
            this.p17.Size = new System.Drawing.Size(100, 21);
            this.p17.TabIndex = 51;
            // 
            // p6
            // 
            this.p6.Enabled = false;
            this.p6.Location = new System.Drawing.Point(302, 107);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(100, 21);
            this.p6.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "端口8";
            // 
            // p16
            // 
            this.p16.Enabled = false;
            this.p16.Location = new System.Drawing.Point(702, 192);
            this.p16.Name = "p16";
            this.p16.Size = new System.Drawing.Size(100, 21);
            this.p16.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(638, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 39;
            this.label15.Text = "端口13";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "端口6";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1060, 484);
            this.Controls.Add(this.groupBoxEx1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SelectPort);
            this.Controls.Add(this.SelectFile);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "麦爵士辅助工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxEx1.ResumeLayout(false);
            this.groupBoxEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.TextBox p3;
        private System.Windows.Forms.TextBox p4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SelectFile;
        private System.Windows.Forms.ComboBox SelectPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ChangJing;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox p8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p7;
        private System.Windows.Forms.TextBox p6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox p5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox p12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox p11;
        private System.Windows.Forms.TextBox p10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox p9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox p16;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox p15;
        private System.Windows.Forms.TextBox p14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox p13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox p20;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox p19;
        private System.Windows.Forms.TextBox p18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox p17;
        private System.Windows.Forms.Button button2;
        private GroupBoxEx groupBoxEx1;
    }
}

