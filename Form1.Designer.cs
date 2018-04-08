namespace HourlySign
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
            this.btnRun = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOutputFileLocation = new System.Windows.Forms.Button();
            this.txtOutfile = new System.Windows.Forms.TextBox();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.rdoChronological = new System.Windows.Forms.RadioButton();
            this.rdoBusiest = new System.Windows.Forms.RadioButton();
            this.grpSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(225, 262);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(122, 58);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(130, 46);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(148, 22);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(411, 26);
            this.txtFileName.TabIndex = 2;
            // 
            // btnOutputFileLocation
            // 
            this.btnOutputFileLocation.Location = new System.Drawing.Point(12, 82);
            this.btnOutputFileLocation.Name = "btnOutputFileLocation";
            this.btnOutputFileLocation.Size = new System.Drawing.Size(130, 61);
            this.btnOutputFileLocation.TabIndex = 3;
            this.btnOutputFileLocation.Text = "Output File Location";
            this.btnOutputFileLocation.UseVisualStyleBackColor = true;
            this.btnOutputFileLocation.Click += new System.EventHandler(this.btnOutputFileLocation_Click);
            // 
            // txtOutfile
            // 
            this.txtOutfile.Location = new System.Drawing.Point(148, 99);
            this.txtOutfile.Name = "txtOutfile";
            this.txtOutfile.Size = new System.Drawing.Size(411, 26);
            this.txtOutfile.TabIndex = 4;
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.rdoBusiest);
            this.grpSort.Controls.Add(this.rdoChronological);
            this.grpSort.Location = new System.Drawing.Point(100, 164);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(379, 63);
            this.grpSort.TabIndex = 5;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Sort Weeks By:";
            // 
            // rdoChronological
            // 
            this.rdoChronological.AutoSize = true;
            this.rdoChronological.Location = new System.Drawing.Point(28, 26);
            this.rdoChronological.Name = "rdoChronological";
            this.rdoChronological.Size = new System.Drawing.Size(130, 24);
            this.rdoChronological.TabIndex = 0;
            this.rdoChronological.TabStop = true;
            this.rdoChronological.Text = "Chronological";
            this.rdoChronological.UseVisualStyleBackColor = true;
            // 
            // rdoBusiest
            // 
            this.rdoBusiest.AutoSize = true;
            this.rdoBusiest.Location = new System.Drawing.Point(275, 26);
            this.rdoBusiest.Name = "rdoBusiest";
            this.rdoBusiest.Size = new System.Drawing.Size(87, 24);
            this.rdoBusiest.TabIndex = 1;
            this.rdoBusiest.TabStop = true;
            this.rdoBusiest.Text = "Busiest";
            this.rdoBusiest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 353);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.txtOutfile);
            this.Controls.Add(this.btnOutputFileLocation);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnRun);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Hourly Sign-In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Button btnRun;
          private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOutputFileLocation;
        private System.Windows.Forms.TextBox txtOutfile;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.RadioButton rdoBusiest;
        private System.Windows.Forms.RadioButton rdoChronological;
    }
}

