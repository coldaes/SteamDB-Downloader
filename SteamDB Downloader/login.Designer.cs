namespace SteamDB_Downloader
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.userbox2 = new System.Windows.Forms.TextBox();
            this.userbox1 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(203, 86);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(75, 23);
            this.buttonlogin.TabIndex = 0;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(122, 86);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 23);
            this.buttoncancel.TabIndex = 1;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            // 
            // userbox2
            // 
            this.userbox2.Location = new System.Drawing.Point(109, 49);
            this.userbox2.Name = "userbox2";
            this.userbox2.Size = new System.Drawing.Size(169, 20);
            this.userbox2.TabIndex = 2;
            this.userbox2.UseSystemPasswordChar = true;
            // 
            // userbox1
            // 
            this.userbox1.Location = new System.Drawing.Point(109, 19);
            this.userbox1.Name = "userbox1";
            this.userbox1.Size = new System.Drawing.Size(169, 20);
            this.userbox1.TabIndex = 3;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(12, 22);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(91, 13);
            this.text1.TabIndex = 4;
            this.text1.Text = "Steam Username:";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(12, 52);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(56, 13);
            this.text2.TabIndex = 5;
            this.text2.Text = "Password:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(5, 91);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Is this safe?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 113);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.userbox1);
            this.Controls.Add(this.userbox2);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonlogin);
            this.Name = "login";
            this.Text = "Steam Log-In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.TextBox userbox2;
        private System.Windows.Forms.TextBox userbox1;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}