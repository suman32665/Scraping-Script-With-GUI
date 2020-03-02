namespace SeleniumWithGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.runscript = new System.Windows.Forms.Button();
            this.checkBoxBrowserless = new System.Windows.Forms.CheckBox();
            this.outputpath = new System.Windows.Forms.TextBox();
            this.txtBoxAppUrl = new System.Windows.Forms.TextBox();
            this.selectFolder = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblURL";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // runscript
            // 
            this.runscript.AccessibleName = "runscript";
            this.runscript.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runscript.Location = new System.Drawing.Point(85, 208);
            this.runscript.Name = "runscript";
            this.runscript.Size = new System.Drawing.Size(155, 38);
            this.runscript.TabIndex = 1;
            this.runscript.Text = "RUN Script";
            this.runscript.UseVisualStyleBackColor = true;
            this.runscript.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBoxBrowserless
            // 
            this.checkBoxBrowserless.AccessibleName = "checkBoxBrowserless";
            this.checkBoxBrowserless.AutoSize = true;
            this.checkBoxBrowserless.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBrowserless.Location = new System.Drawing.Point(126, 129);
            this.checkBoxBrowserless.Name = "checkBoxBrowserless";
            this.checkBoxBrowserless.Size = new System.Drawing.Size(106, 21);
            this.checkBoxBrowserless.TabIndex = 3;
            this.checkBoxBrowserless.Text = "Browserless";
            this.checkBoxBrowserless.UseVisualStyleBackColor = true;
            this.checkBoxBrowserless.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // outputpath
            // 
            this.outputpath.Location = new System.Drawing.Point(144, 97);
            this.outputpath.Name = "outputpath";
            this.outputpath.Size = new System.Drawing.Size(306, 23);
            this.outputpath.TabIndex = 5;
            this.outputpath.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBoxAppUrl
            // 
            this.txtBoxAppUrl.AccessibleName = "appURL";
            this.txtBoxAppUrl.Location = new System.Drawing.Point(144, 57);
            this.txtBoxAppUrl.Name = "txtBoxAppUrl";
            this.txtBoxAppUrl.Size = new System.Drawing.Size(306, 23);
            this.txtBoxAppUrl.TabIndex = 2;
            this.txtBoxAppUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // selectFolder
            // 
            this.selectFolder.BackColor = System.Drawing.Color.Honeydew;
            this.selectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFolder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectFolder.Location = new System.Drawing.Point(7, 93);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(135, 30);
            this.selectFolder.TabIndex = 6;
            this.selectFolder.Text = "Select Folder";
            this.selectFolder.UseVisualStyleBackColor = false;
            this.selectFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(123, 24);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(37, 18);
            this.Message.TabIndex = 7;
            this.Message.Text = "msg";
            this.Message.Visible = false;
            this.Message.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 292);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.outputpath);
            this.Controls.Add(this.checkBoxBrowserless);
            this.Controls.Add(this.txtBoxAppUrl);
            this.Controls.Add(this.runscript);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Web Scrapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button runscript;
        private System.Windows.Forms.TextBox txtBoxAppUrl;
        private System.Windows.Forms.CheckBox checkBoxBrowserless;
        private System.Windows.Forms.TextBox outputpath;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.Label Message;
    }
}

