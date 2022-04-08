namespace SteamDB_Downloader
{
    partial class mainwindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainwindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.singledltab = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sidebackground2 = new System.Windows.Forms.RichTextBox();
            this.sidebackground1 = new System.Windows.Forms.RichTextBox();
            this.multidltab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logtab = new System.Windows.Forms.TabPage();
            this.textareaLog = new System.Windows.Forms.RichTextBox();
            this.perftab = new System.Windows.Forms.TabPage();
            this.abouttab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.dropdown1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCommandWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToSteamDBcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDownloadDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.choosedirdialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.singledltab.SuspendLayout();
            this.multidltab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.logtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.singledltab);
            this.tabControl.Controls.Add(this.multidltab);
            this.tabControl.Controls.Add(this.logtab);
            this.tabControl.Controls.Add(this.perftab);
            this.tabControl.Controls.Add(this.abouttab);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // singledltab
            // 
            this.singledltab.Controls.Add(this.button2);
            this.singledltab.Controls.Add(this.linkLabel1);
            this.singledltab.Controls.Add(this.checkBox6);
            this.singledltab.Controls.Add(this.checkBox5);
            this.singledltab.Controls.Add(this.checkBox4);
            this.singledltab.Controls.Add(this.label5);
            this.singledltab.Controls.Add(this.label2);
            this.singledltab.Controls.Add(this.checkBox3);
            this.singledltab.Controls.Add(this.checkBox2);
            this.singledltab.Controls.Add(this.checkBox1);
            this.singledltab.Controls.Add(this.label4);
            this.singledltab.Controls.Add(this.textBox3);
            this.singledltab.Controls.Add(this.textBox2);
            this.singledltab.Controls.Add(this.button1);
            this.singledltab.Controls.Add(this.textBox1);
            this.singledltab.Controls.Add(this.label3);
            this.singledltab.Controls.Add(this.label1);
            this.singledltab.Controls.Add(this.sidebackground2);
            this.singledltab.Controls.Add(this.sidebackground1);
            resources.ApplyResources(this.singledltab, "singledltab");
            this.singledltab.Name = "singledltab";
            this.singledltab.UseVisualStyleBackColor = true;
            this.singledltab.Click += new System.EventHandler(this.singledltab_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            // 
            // checkBox6
            // 
            resources.ApplyResources(this.checkBox6, "checkBox6");
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            resources.ApplyResources(this.checkBox5, "checkBox5");
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // sidebackground2
            // 
            this.sidebackground2.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.sidebackground2, "sidebackground2");
            this.sidebackground2.Name = "sidebackground2";
            this.sidebackground2.ReadOnly = true;
            // 
            // sidebackground1
            // 
            this.sidebackground1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebackground1.DetectUrls = false;
            resources.ApplyResources(this.sidebackground1, "sidebackground1");
            this.sidebackground1.Name = "sidebackground1";
            this.sidebackground1.ReadOnly = true;
            this.sidebackground1.TabStop = false;
            this.sidebackground1.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // multidltab
            // 
            this.multidltab.Controls.Add(this.label7);
            this.multidltab.Controls.Add(this.label6);
            this.multidltab.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.multidltab, "multidltab");
            this.multidltab.Name = "multidltab";
            this.multidltab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // logtab
            // 
            this.logtab.Controls.Add(this.textareaLog);
            resources.ApplyResources(this.logtab, "logtab");
            this.logtab.Name = "logtab";
            this.logtab.UseVisualStyleBackColor = true;
            // 
            // textareaLog
            // 
            this.textareaLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textareaLog.DetectUrls = false;
            resources.ApplyResources(this.textareaLog, "textareaLog");
            this.textareaLog.Name = "textareaLog";
            this.textareaLog.TextChanged += new System.EventHandler(this.cmdlog_TextChanged);
            // 
            // perftab
            // 
            resources.ApplyResources(this.perftab, "perftab");
            this.perftab.Name = "perftab";
            this.perftab.UseVisualStyleBackColor = true;
            // 
            // abouttab
            // 
            resources.ApplyResources(this.abouttab, "abouttab");
            this.abouttab.Name = "abouttab";
            this.abouttab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripProgressBar2,
            this.dropdown1});
            resources.ApplyResources(this.statusStripMain, "statusStripMain");
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            this.toolStripProgressBar1.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            resources.ApplyResources(this.toolStripProgressBar2, "toolStripProgressBar2");
            // 
            // dropdown1
            // 
            this.dropdown1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dropdown1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.goToSteamDBcomToolStripMenuItem,
            this.openDownloadDirectoryToolStripMenuItem,
            this.pauseDownloadToolStripMenuItem,
            this.cancelDownloadToolStripMenuItem});
            resources.ApplyResources(this.dropdown1, "dropdown1");
            this.dropdown1.Margin = new System.Windows.Forms.Padding(225, 2, 0, 0);
            this.dropdown1.Name = "dropdown1";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCommandWindowToolStripMenuItem,
            this.openLogDirectoryToolStripMenuItem});
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            resources.ApplyResources(this.pauseToolStripMenuItem, "pauseToolStripMenuItem");
            // 
            // openCommandWindowToolStripMenuItem
            // 
            this.openCommandWindowToolStripMenuItem.Name = "openCommandWindowToolStripMenuItem";
            resources.ApplyResources(this.openCommandWindowToolStripMenuItem, "openCommandWindowToolStripMenuItem");
            this.openCommandWindowToolStripMenuItem.Click += new System.EventHandler(this.openCommandWindowToolStripMenuItem_Click);
            // 
            // openLogDirectoryToolStripMenuItem
            // 
            this.openLogDirectoryToolStripMenuItem.Name = "openLogDirectoryToolStripMenuItem";
            resources.ApplyResources(this.openLogDirectoryToolStripMenuItem, "openLogDirectoryToolStripMenuItem");
            this.openLogDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openLogDirectoryToolStripMenuItem_Click);
            // 
            // goToSteamDBcomToolStripMenuItem
            // 
            this.goToSteamDBcomToolStripMenuItem.Name = "goToSteamDBcomToolStripMenuItem";
            resources.ApplyResources(this.goToSteamDBcomToolStripMenuItem, "goToSteamDBcomToolStripMenuItem");
            // 
            // openDownloadDirectoryToolStripMenuItem
            // 
            this.openDownloadDirectoryToolStripMenuItem.Name = "openDownloadDirectoryToolStripMenuItem";
            resources.ApplyResources(this.openDownloadDirectoryToolStripMenuItem, "openDownloadDirectoryToolStripMenuItem");
            // 
            // pauseDownloadToolStripMenuItem
            // 
            this.pauseDownloadToolStripMenuItem.Name = "pauseDownloadToolStripMenuItem";
            resources.ApplyResources(this.pauseDownloadToolStripMenuItem, "pauseDownloadToolStripMenuItem");
            // 
            // cancelDownloadToolStripMenuItem
            // 
            this.cancelDownloadToolStripMenuItem.Name = "cancelDownloadToolStripMenuItem";
            resources.ApplyResources(this.cancelDownloadToolStripMenuItem, "cancelDownloadToolStripMenuItem");
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            // 
            // choosedirdialog
            // 
            this.choosedirdialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mainwindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainwindow";
            this.Load += new System.EventHandler(this.Window_Load);
            this.tabControl.ResumeLayout(false);
            this.singledltab.ResumeLayout(false);
            this.singledltab.PerformLayout();
            this.multidltab.ResumeLayout(false);
            this.multidltab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.logtab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage singledltab;
        private System.Windows.Forms.TabPage multidltab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RichTextBox textareaLog;
        private System.Windows.Forms.TabPage logtab;
        private System.Windows.Forms.TabPage perftab;
        private System.Windows.Forms.TabPage abouttab;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.ToolStripDropDownButton dropdown1;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCommandWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLogDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDownloadDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseDownloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelDownloadToolStripMenuItem;
        private System.Windows.Forms.RichTextBox sidebackground2;
        private System.Windows.Forms.ToolStripMenuItem goToSteamDBcomToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.FolderBrowserDialog choosedirdialog;
        private System.Windows.Forms.RichTextBox sidebackground1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
    }
}

