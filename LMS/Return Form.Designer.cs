namespace LMS
{
    partial class Return_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ISBNtxt = new System.Windows.Forms.TextBox();
            this.Enrolltxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter ISBN Numner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Student Enrollment Number";
            // 
            // ISBNtxt
            // 
            this.ISBNtxt.Location = new System.Drawing.Point(196, 25);
            this.ISBNtxt.Name = "ISBNtxt";
            this.ISBNtxt.Size = new System.Drawing.Size(199, 20);
            this.ISBNtxt.TabIndex = 2;
            // 
            // Enrolltxt
            // 
            this.Enrolltxt.Location = new System.Drawing.Point(196, 72);
            this.Enrolltxt.Name = "Enrolltxt";
            this.Enrolltxt.Size = new System.Drawing.Size(199, 20);
            this.Enrolltxt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Book Return";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Return_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Enrolltxt);
            this.Controls.Add(this.ISBNtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Return_Form";
            this.Text = "Return_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ISBNtxt;
        private System.Windows.Forms.TextBox Enrolltxt;
        private System.Windows.Forms.Button button1;
    }
}