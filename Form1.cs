using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CheckFileStatus
{
    public partial class Form1 : Form
    {
        List<string> FilePaths = new List<string>();
        string BackUpPath = "";

        public void LoadPathsFromTxt()
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFilePaths_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                string FilePath = dialog.FileName;
                FilePaths.Add(FilePath);
                listBoxFilesPath.Items.Add(FilePath);
            }
        }

        private void btnSetBackUpPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(DialogResult.OK == dialog.ShowDialog())
            {
                BackUpPath = dialog.SelectedPath;
                txtBackupPath.Text = BackUpPath;
            }
        }


        public bool CheckFilePath(string FileName, string BackUpPath)
        {
            try
            {
                if (System.IO.File.Exists(FileName)) //判断文件是否存在
                {

                }
                else
                {
                    System.IO.File.Copy(BackUpPath + "\\" + System.IO.Path.GetFileName(FileName), FileName);
                    Log.WriteLog(FileName + "文件丢失异常Error，程序已自动复制恢复");
                }
                return true;
            }
            catch(Exception ee)
            {
                Log.WriteLog(ee.Message );
                return false;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if((FilePaths.Count<1)||(BackUpPath==""))
            {
                MessageBox.Show("请确认是否有设置文件路径和备份文件夹！！！");
                return;
            }
            if (!timer1.Enabled)
            {

                btnStart.Text = "监控中...";
                btnStart.BackColor = Color.Lime;
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("已经启动~ 无需重复点击");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                if (FilePaths.Count > 0)
                {
                    for (int i = 0; i < FilePaths.Count; i++)
                    {
                        if (!CheckFilePath(FilePaths[i], BackUpPath))
                        {
                            MessageBox.Show("请确认备份文件夹文件是否存在！！！");
                            Log.WriteLog("文件操作异常，程序运行中止！");
                            timer1.Stop();
                            btnStart.Text = "中止";
                            btnStart.BackColor = Color.Red;
                        }
                    }

                }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string startup = Application.ExecutablePath;       //取得程序路径   
            int pp = startup.LastIndexOf("\\");
            startup = startup.Substring(0, pp);
            string icon = startup + "\\CPEPS.ico";
            if (System.IO.File.Exists(icon))
                notifyIcon1.Icon = new Icon(icon);
            else
                this.Close();
        }
    }
}
