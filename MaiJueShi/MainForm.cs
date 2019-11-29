using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MaiJueShi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //默认选择
            SelectPort.SelectedIndex = 0;
            ChangJing.Items.Clear();
            for (int i = 0; i < 255; i++)
            {
                ChangJing.Items.Add(i + 1);
            }
            ChangJing.SelectedIndex = 0;
        }

        private void 打开文件ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //打开文件选择器
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "DAT File(*.dat)|*.dat;*.DAT";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SelectFile.Text = openFileDialog.FileName;
            }
        }

        private void SelectPort_SelectedIndexChanged(object sender, EventArgs e)
        {

            int number = Convert.ToInt32(SelectPort.SelectedItem.ToString());
            foreach (Control control in this.Controls)//循环所有文本框  开放端口
            {
                if (control is TextBox)
                {
                    int port = int.Parse(control.Name.ToString().Substring(1));
                    if (port <= number)
                    {
                        control.Enabled = true;
                    }
                    else
                    {
                        control.Enabled = false;
                    }
                }
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectFile.Text.Length < 5)
            {
                MessageBox.Show("未选择文件！");
                return;
            }
            TextBox[] ports = { p1, p2, p3, p4 };
            FileStream fs = new FileStream(SelectFile.Text, FileMode.Open, FileAccess.Read);
            byte[] vs1 = new byte[fs.Length];
            fs.Read(vs1, 0, (int)fs.Length);
            String path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);//桌面路径

            byte[] buff = new byte[fs.Length - 512];
            for (int i = 0; i < buff.Length; i++)
            {
                buff[i] = vs1[512 + i];
            }

            int number = Convert.ToInt32(SelectPort.SelectedItem.ToString());//开放端口数量
            //先计算文件长度是否足够 以及文本框是否为空
            Boolean flag = true;
            for (int i = 0; i < number; i++)
            {
                if (ports[i].Text.Equals(""))
                {
                    flag = false;
                    MessageBox.Show("端口" + (i + 1) + "未填写数据！");
                    break;
                }
            }
            int count = 0;//计算所有端口占字节数
            if (flag)
            {
                for (int i = 0; i < number; i++)
                {
                    count += Convert.ToInt32(ports[i].Text) * 3;
                }
                if (count > buff.Length)
                {
                    flag = false;
                    MessageBox.Show("选择文件有误，不能生成对应的文件！");
                }
                if (count <= 512)
                {
                    count = 512;
                }
                else
                {
                    count = 1024;
                }
            }
            if (flag)
            {
                //计算总步数
                int buShu = buff.Length / count;

                FileStream[] fileStreams = new FileStream[number];
                for (int i = 0; i < number; i++)
                {
                    String pathAndNmae = path + "\\" + ChangJing.SelectedItem.ToString() + "-" + (i + 1) + ".bin";
                    fileStreams[i] = new FileStream(@pathAndNmae, FileMode.Create, FileAccess.Write);
                }
                List<byte[]> list = new List<byte[]>();
                for (int j = 0; j < buShu; j++)
                {
                    byte[] vs = new byte[count];
                    Array.Copy(buff, j * count, vs, 0, count);
                    list.Add(vs);
                }
                for (int i = 0; i < list.Count; i++)
                {
                    byte[] vs = list[i];
                    for (int j = 0; j < number; j++)
                    {
                        int b = 0;
                        for (int k = 0; k < (Convert.ToInt32(ports[j].Text) * 3); k++)
                        {
                            fileStreams[j].WriteByte(vs[b++]);
                        }
                    }
                }
                for (int i = 0; i < fileStreams.Length; i++)
                {
                    fileStreams[i].Close();
                }

                MessageBox.Show("文件生成成功，默认存放在桌面！");
            }
        }

        private void p1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void p2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void p3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void p4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

    }
}
