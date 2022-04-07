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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainwindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.singledltab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.multidltab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logtab = new System.Windows.Forms.TabPage();
            this.textareaLog = new System.Windows.Forms.RichTextBox();
            this.perftab = new System.Windows.Forms.TabPage();
            this.abouttab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.singledltab.SuspendLayout();
            this.multidltab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.logtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
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
            this.singledltab.Controls.Add(this.checkBox3);
            this.singledltab.Controls.Add(this.progressBar1);
            this.singledltab.Controls.Add(this.button2);
            this.singledltab.Controls.Add(this.checkBox2);
            this.singledltab.Controls.Add(this.checkBox1);
            this.singledltab.Controls.Add(this.label4);
            this.singledltab.Controls.Add(this.textBox3);
            this.singledltab.Controls.Add(this.textBox2);
            this.singledltab.Controls.Add(this.button1);
            this.singledltab.Controls.Add(this.textBox1);
            this.singledltab.Controls.Add(this.label3);
            this.singledltab.Controls.Add(this.label1);
            resources.ApplyResources(this.singledltab, "singledltab");
            this.singledltab.Name = "singledltab";
            this.singledltab.UseVisualStyleBackColor = true;
            this.singledltab.Click += new System.EventHandler(this.singledltab_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // mainwindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage logtab;
        private System.Windows.Forms.TabPage perftab;
        private System.Windows.Forms.TabPage abouttab;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

