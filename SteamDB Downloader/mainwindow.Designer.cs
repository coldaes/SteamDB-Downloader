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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textareaLog = new System.Windows.Forms.RichTextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.multidltab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logtab = new System.Windows.Forms.TabPage();
            this.perftab = new System.Windows.Forms.TabPage();
            this.abouttab = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.singledltab.SuspendLayout();
            this.multidltab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.logtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Depot-ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "App-ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 203);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(480, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.singledltab);
            this.tabControl.Controls.Add(this.multidltab);
            this.tabControl.Controls.Add(this.logtab);
            this.tabControl.Controls.Add(this.perftab);
            this.tabControl.Controls.Add(this.abouttab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(500, 287);
            this.tabControl.TabIndex = 9;
            // 
            // singledltab
            // 
            this.singledltab.Controls.Add(this.progressBar1);
            this.singledltab.Controls.Add(this.button2);
            this.singledltab.Controls.Add(this.textBox4);
            this.singledltab.Controls.Add(this.textBox5);
            this.singledltab.Controls.Add(this.label2);
            this.singledltab.Controls.Add(this.label5);
            this.singledltab.Controls.Add(this.checkBox2);
            this.singledltab.Controls.Add(this.checkBox1);
            this.singledltab.Controls.Add(this.label4);
            this.singledltab.Controls.Add(this.textBox3);
            this.singledltab.Controls.Add(this.textBox2);
            this.singledltab.Controls.Add(this.button1);
            this.singledltab.Controls.Add(this.textBox1);
            this.singledltab.Controls.Add(this.label3);
            this.singledltab.Controls.Add(this.label1);
            this.singledltab.Location = new System.Drawing.Point(4, 22);
            this.singledltab.Name = "singledltab";
            this.singledltab.Padding = new System.Windows.Forms.Padding(3);
            this.singledltab.Size = new System.Drawing.Size(492, 261);
            this.singledltab.TabIndex = 0;
            this.singledltab.Text = "Single Manifest";
            this.singledltab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Debug";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(109, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4.UseSystemPasswordChar = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(109, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(146, 20);
            this.textBox5.TabIndex = 16;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textareaLog
            // 
            this.textareaLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textareaLog.DetectUrls = false;
            this.textareaLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textareaLog.Location = new System.Drawing.Point(0, 0);
            this.textareaLog.Name = "textareaLog";
            this.textareaLog.Size = new System.Drawing.Size(492, 261);
            this.textareaLog.TabIndex = 10;
            this.textareaLog.Text = "";
            this.textareaLog.TextChanged += new System.EventHandler(this.cmdlog_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(172, 236);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "create log file";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 236);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(157, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "validate files after download";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Manifest-ID:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // multidltab
            // 
            this.multidltab.Controls.Add(this.label7);
            this.multidltab.Controls.Add(this.label6);
            this.multidltab.Controls.Add(this.pictureBox2);
            this.multidltab.Location = new System.Drawing.Point(4, 22);
            this.multidltab.Name = "multidltab";
            this.multidltab.Padding = new System.Windows.Forms.Padding(3);
            this.multidltab.Size = new System.Drawing.Size(492, 261);
            this.multidltab.TabIndex = 1;
            this.multidltab.Text = "Multiple Manifests";
            this.multidltab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(468, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logtab
            // 
            this.logtab.Controls.Add(this.textareaLog);
            this.logtab.Location = new System.Drawing.Point(4, 22);
            this.logtab.Name = "logtab";
            this.logtab.Size = new System.Drawing.Size(492, 261);
            this.logtab.TabIndex = 2;
            this.logtab.Text = "Logging";
            this.logtab.UseVisualStyleBackColor = true;
            // 
            // perftab
            // 
            this.perftab.Location = new System.Drawing.Point(4, 22);
            this.perftab.Name = "perftab";
            this.perftab.Size = new System.Drawing.Size(492, 261);
            this.perftab.TabIndex = 3;
            this.perftab.Text = "Network Performance";
            this.perftab.UseVisualStyleBackColor = true;
            // 
            // abouttab
            // 
            this.abouttab.Location = new System.Drawing.Point(4, 22);
            this.abouttab.Name = "abouttab";
            this.abouttab.Size = new System.Drawing.Size(492, 261);
            this.abouttab.TabIndex = 4;
            this.abouttab.Text = "About";
            this.abouttab.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-4, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Neuropolitical Rg", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(444, 44);
            this.label6.TabIndex = 1;
            this.label6.Text = "Work In Progress!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(364, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Come back soon!";
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.Name = "mainwindow";
            this.Text = "Steam Database Downloader";
            this.Load += new System.EventHandler(this.Window_Load);
            this.tabControl.ResumeLayout(false);
            this.singledltab.ResumeLayout(false);
            this.singledltab.PerformLayout();
            this.multidltab.ResumeLayout(false);
            this.multidltab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.logtab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage logtab;
        private System.Windows.Forms.TabPage perftab;
        private System.Windows.Forms.TabPage abouttab;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

