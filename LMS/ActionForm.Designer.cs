namespace LMS
{
    partial class ActionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchRadio = new System.Windows.Forms.RadioButton();
            this.ReturnRadio = new System.Windows.Forms.RadioButton();
            this.CatRadio = new System.Windows.Forms.RadioButton();
            this.AddRadio = new System.Windows.Forms.RadioButton();
            this.PassRadio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PassRadio);
            this.groupBox1.Controls.Add(this.AddRadio);
            this.groupBox1.Controls.Add(this.CatRadio);
            this.groupBox1.Controls.Add(this.ReturnRadio);
            this.groupBox1.Controls.Add(this.SearchRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SearchRadio
            // 
            this.SearchRadio.Location = new System.Drawing.Point(24, 32);
            this.SearchRadio.Name = "SearchRadio";
            this.SearchRadio.Size = new System.Drawing.Size(144, 19);
            this.SearchRadio.TabIndex = 0;
            this.SearchRadio.TabStop = true;
            this.SearchRadio.Text = "Search / Issue Book";
            this.SearchRadio.UseVisualStyleBackColor = true;
            // 
            // ReturnRadio
            // 
            this.ReturnRadio.Location = new System.Drawing.Point(24, 66);
            this.ReturnRadio.Name = "ReturnRadio";
            this.ReturnRadio.Size = new System.Drawing.Size(85, 17);
            this.ReturnRadio.TabIndex = 1;
            this.ReturnRadio.TabStop = true;
            this.ReturnRadio.Text = "Return Book";
            this.ReturnRadio.UseVisualStyleBackColor = true;
            // 
            // CatRadio
            // 
            this.CatRadio.Location = new System.Drawing.Point(24, 104);
            this.CatRadio.Name = "CatRadio";
            this.CatRadio.Size = new System.Drawing.Size(144, 21);
            this.CatRadio.TabIndex = 2;
            this.CatRadio.TabStop = true;
            this.CatRadio.Text = "Manage Categories";
            this.CatRadio.UseVisualStyleBackColor = true;
            // 
            // AddRadio
            // 
            this.AddRadio.Location = new System.Drawing.Point(24, 140);
            this.AddRadio.Name = "AddRadio";
            this.AddRadio.Size = new System.Drawing.Size(129, 18);
            this.AddRadio.TabIndex = 3;
            this.AddRadio.TabStop = true;
            this.AddRadio.Text = "Add / Remove Book";
            this.AddRadio.UseVisualStyleBackColor = true;
            // 
            // PassRadio
            // 
            this.PassRadio.Location = new System.Drawing.Point(24, 175);
            this.PassRadio.Name = "PassRadio";
            this.PassRadio.Size = new System.Drawing.Size(129, 17);
            this.PassRadio.TabIndex = 4;
            this.PassRadio.TabStop = true;
            this.PassRadio.Text = "Change Password";
            this.PassRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ActionForm";
            this.Text = "ActionForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PassRadio;
        private System.Windows.Forms.RadioButton AddRadio;
        private System.Windows.Forms.RadioButton CatRadio;
        private System.Windows.Forms.RadioButton ReturnRadio;
        private System.Windows.Forms.RadioButton SearchRadio;
        private System.Windows.Forms.Button button1;
    }
}