namespace LMS
{
    partial class Form1
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
            this.userlbl = new System.Windows.Forms.Label();
            this.Passlbl = new System.Windows.Forms.Label();
            this.UserTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Location = new System.Drawing.Point(33, 21);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(60, 13);
            this.userlbl.TabIndex = 0;
            this.userlbl.Text = "User Name";
            // 
            // Passlbl
            // 
            this.Passlbl.AutoSize = true;
            this.Passlbl.Location = new System.Drawing.Point(40, 58);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(53, 13);
            this.Passlbl.TabIndex = 1;
            this.Passlbl.Text = "Password";
            // 
            // UserTxt
            // 
            this.UserTxt.Location = new System.Drawing.Point(125, 18);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(211, 20);
            this.UserTxt.TabIndex = 2;
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(125, 58);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '*';
            this.PassTxt.Size = new System.Drawing.Size(211, 20);
            this.PassTxt.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(177, 108);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(93, 36);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 350);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.UserTxt);
            this.Controls.Add(this.Passlbl);
            this.Controls.Add(this.userlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label Passlbl;
        private System.Windows.Forms.TextBox UserTxt;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Button loginButton;
    }
}

