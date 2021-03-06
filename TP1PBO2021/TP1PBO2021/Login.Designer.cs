
namespace TP1PBO2021
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textpassword = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.textusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lbljudul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textpassword
            // 
            this.textpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textpassword.Location = new System.Drawing.Point(253, 237);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(216, 23);
            this.textpassword.TabIndex = 0;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblusername.Location = new System.Drawing.Point(302, 104);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(97, 24);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Username";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogin.Location = new System.Drawing.Point(311, 277);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(96, 35);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // textusername
            // 
            this.textusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textusername.Location = new System.Drawing.Point(253, 150);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(216, 23);
            this.textusername.TabIndex = 3;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblpassword.Location = new System.Drawing.Point(307, 198);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(92, 24);
            this.lblpassword.TabIndex = 4;
            this.lblpassword.Text = "Password";
            // 
            // lbljudul
            // 
            this.lbljudul.AutoSize = true;
            this.lbljudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbljudul.Location = new System.Drawing.Point(158, 47);
            this.lbljudul.Name = "lbljudul";
            this.lbljudul.Size = new System.Drawing.Size(433, 31);
            this.lbljudul.TabIndex = 5;
            this.lbljudul.Text = "Selamat Datang di PT.Gelay Abadi";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(749, 439);
            this.Controls.Add(this.lbljudul);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.textpassword);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lbljudul;
    }
}