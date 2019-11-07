namespace CheckFileStatus
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoadFilePaths = new System.Windows.Forms.Button();
            this.listBoxFilesPath = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSetBackUpPath = new System.Windows.Forms.Button();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnLoadFilePaths
            // 
            this.btnLoadFilePaths.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoadFilePaths.Location = new System.Drawing.Point(32, 12);
            this.btnLoadFilePaths.Name = "btnLoadFilePaths";
            this.btnLoadFilePaths.Size = new System.Drawing.Size(126, 45);
            this.btnLoadFilePaths.TabIndex = 0;
            this.btnLoadFilePaths.Text = "加载文件路径";
            this.btnLoadFilePaths.UseVisualStyleBackColor = false;
            this.btnLoadFilePaths.Click += new System.EventHandler(this.btnLoadFilePaths_Click);
            // 
            // listBoxFilesPath
            // 
            this.listBoxFilesPath.FormattingEnabled = true;
            this.listBoxFilesPath.ItemHeight = 15;
            this.listBoxFilesPath.Location = new System.Drawing.Point(184, 12);
            this.listBoxFilesPath.Name = "listBoxFilesPath";
            this.listBoxFilesPath.ScrollAlwaysVisible = true;
            this.listBoxFilesPath.Size = new System.Drawing.Size(776, 184);
            this.listBoxFilesPath.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Yellow;
            this.btnStart.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(32, 249);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(928, 200);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "启动文件监控";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSetBackUpPath
            // 
            this.btnSetBackUpPath.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSetBackUpPath.Location = new System.Drawing.Point(32, 198);
            this.btnSetBackUpPath.Name = "btnSetBackUpPath";
            this.btnSetBackUpPath.Size = new System.Drawing.Size(126, 45);
            this.btnSetBackUpPath.TabIndex = 3;
            this.btnSetBackUpPath.Text = "设置备份文件";
            this.btnSetBackUpPath.UseVisualStyleBackColor = false;
            this.btnSetBackUpPath.Click += new System.EventHandler(this.btnSetBackUpPath_Click);
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBackupPath.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBackupPath.Location = new System.Drawing.Point(184, 202);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.ReadOnly = true;
            this.txtBackupPath.Size = new System.Drawing.Size(776, 38);
            this.txtBackupPath.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "DeleteFile";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(998, 471);
            this.Controls.Add(this.txtBackupPath);
            this.Controls.Add(this.btnSetBackUpPath);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listBoxFilesPath);
            this.Controls.Add(this.btnLoadFilePaths);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "CheckFiles";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFilePaths;
        private System.Windows.Forms.ListBox listBoxFilesPath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSetBackUpPath;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

