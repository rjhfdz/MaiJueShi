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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.p3 = new System.Windows.Forms.TextBox();
            this.p4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectFile = new System.Windows.Forms.Label();
            this.SelectPort = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ChangJing = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "端口3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "端口4";
            // 
            // p1
            // 
            this.p1.Enabled = false;
            this.p1.Location = new System.Drawing.Point(125, 129);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 21);
            this.p1.TabIndex = 8;
            this.p1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p1_KeyPress);
            // 
            // p2
            // 
            this.p2.Enabled = false;
            this.p2.Location = new System.Drawing.Point(125, 166);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 21);
            this.p2.TabIndex = 9;
            this.p2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p2_KeyPress);
            // 
            // p3
            // 
            this.p3.Enabled = false;
            this.p3.Location = new System.Drawing.Point(125, 209);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(100, 21);
            this.p3.TabIndex = 10;
            this.p3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p3_KeyPress);
            // 
            // p4
            // 
            this.p4.Enabled = false;
            this.p4.Location = new System.Drawing.Point(125, 245);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(100, 21);
            this.p4.TabIndex = 11;
            this.p4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p4_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "生成对应文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(286, 25);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem1});
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.打开文件ToolStripMenuItem.Text = "菜单";
            // 
            // 打开文件ToolStripMenuItem1
            // 
            this.打开文件ToolStripMenuItem1.Name = "打开文件ToolStripMenuItem1";
            this.打开文件ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.打开文件ToolStripMenuItem1.Text = "打开文件";
            this.打开文件ToolStripMenuItem1.Click += new System.EventHandler(this.打开文件ToolStripMenuItem1_Click);
            // 
            // SelectFile
            // 
            this.SelectFile.AutoSize = true;
            this.SelectFile.Location = new System.Drawing.Point(12, 37);
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
            "4"});
            this.SelectPort.Location = new System.Drawing.Point(125, 90);
            this.SelectPort.Name = "SelectPort";
            this.SelectPort.Size = new System.Drawing.Size(100, 20);
            this.SelectPort.TabIndex = 19;
            this.SelectPort.SelectedIndexChanged += new System.EventHandler(this.SelectPort_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "已开放端口";
            // 
            // ChangJing
            // 
            this.ChangJing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChangJing.FormattingEnabled = true;
            this.ChangJing.Location = new System.Drawing.Point(125, 64);
            this.ChangJing.Name = "ChangJing";
            this.ChangJing.Size = new System.Drawing.Size(100, 20);
            this.ChangJing.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "场景";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(286, 336);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ChangJing);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SelectPort);
            this.Controls.Add(this.SelectFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "麦爵士辅助工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.Label SelectFile;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem1;
        private System.Windows.Forms.ComboBox SelectPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ChangJing;
        private System.Windows.Forms.Label label10;
    }
}

