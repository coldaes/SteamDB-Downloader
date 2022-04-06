namespace SteamDB_Downloader
{
    partial class isthissafe
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
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(12, 19);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(241, 20);
            this.text1.TabIndex = 0;
            this.text1.Text = "Is it safe to use this downloader?";
            this.text1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(230, 142);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(23, 13);
            this.text2.TabIndex = 1;
            this.text2.Text = "yes";
            // 
            // isthissafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 164);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Name = "isthissafe";
            this.Text = "Is this safe?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
    }
}