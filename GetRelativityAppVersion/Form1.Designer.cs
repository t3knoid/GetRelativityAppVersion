namespace GetRelativityAppVersion
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
            this.btBrowse = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btGetVersion = new System.Windows.Forms.Button();
            this.tbRAPFile = new System.Windows.Forms.TextBox();
            this.lbRAPFile = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(422, 38);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 0;
            this.btBrowse.Text = "Browse...";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(273, 75);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "&Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btGetVersion
            // 
            this.btGetVersion.Location = new System.Drawing.Point(154, 75);
            this.btGetVersion.Name = "btGetVersion";
            this.btGetVersion.Size = new System.Drawing.Size(75, 23);
            this.btGetVersion.TabIndex = 2;
            this.btGetVersion.Text = "Get &Version";
            this.btGetVersion.UseVisualStyleBackColor = true;
            this.btGetVersion.Click += new System.EventHandler(this.btGetVersion_Click);
            // 
            // tbRAPFile
            // 
            this.tbRAPFile.Location = new System.Drawing.Point(66, 40);
            this.tbRAPFile.Name = "tbRAPFile";
            this.tbRAPFile.Size = new System.Drawing.Size(342, 20);
            this.tbRAPFile.TabIndex = 3;
            // 
            // lbRAPFile
            // 
            this.lbRAPFile.AutoSize = true;
            this.lbRAPFile.Location = new System.Drawing.Point(12, 43);
            this.lbRAPFile.Name = "lbRAPFile";
            this.lbRAPFile.Size = new System.Drawing.Size(48, 13);
            this.lbRAPFile.TabIndex = 4;
            this.lbRAPFile.Text = "RAP File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "rap";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "RAP Files|*.rap";
            this.openFileDialog1.Title = "Select a Relativity application file";
            // 
            // lbInstructions
            // 
            this.lbInstructions.AutoSize = true;
            this.lbInstructions.Location = new System.Drawing.Point(12, 9);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Size = new System.Drawing.Size(419, 13);
            this.lbInstructions.TabIndex = 6;
            this.lbInstructions.Text = "Select a Relativity application file and click \"Get Version\" to display the versi" +
    "on number.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 115);
            this.Controls.Add(this.lbInstructions);
            this.Controls.Add(this.lbRAPFile);
            this.Controls.Add(this.tbRAPFile);
            this.Controls.Add(this.btGetVersion);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Get Relativity Application Version";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btGetVersion;
        private System.Windows.Forms.TextBox tbRAPFile;
        private System.Windows.Forms.Label lbRAPFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbInstructions;
    }
}

