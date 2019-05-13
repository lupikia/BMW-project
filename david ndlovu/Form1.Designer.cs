namespace david_ndlovu
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
            this.components = new System.ComponentModel.Container();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.chkSubDirectories = new System.Windows.Forms.CheckBox();
            this.btnReplicate = new System.Windows.Forms.Button();
            this.progBrar = new System.Windows.Forms.ProgressBar();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.ofdSource = new System.Windows.Forms.OpenFileDialog();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnViewLog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.fbdDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.errorpDestination = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorpDestination)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(87, 63);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(62, 20);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source";
            this.lblSource.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(55, 92);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(94, 20);
            this.lblDestination.TabIndex = 0;
            this.lblDestination.Text = "Destination";
            this.lblDestination.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkSubDirectories
            // 
            this.chkSubDirectories.AutoSize = true;
            this.chkSubDirectories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSubDirectories.Location = new System.Drawing.Point(181, 133);
            this.chkSubDirectories.Name = "chkSubDirectories";
            this.chkSubDirectories.Size = new System.Drawing.Size(203, 24);
            this.chkSubDirectories.TabIndex = 1;
            this.chkSubDirectories.Text = "Include Sub Directories";
            this.chkSubDirectories.UseVisualStyleBackColor = true;
            // 
            // btnReplicate
            // 
            this.btnReplicate.AccessibleName = "btnReplicate";
            this.btnReplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplicate.Location = new System.Drawing.Point(181, 167);
            this.btnReplicate.Name = "btnReplicate";
            this.btnReplicate.Size = new System.Drawing.Size(100, 30);
            this.btnReplicate.TabIndex = 2;
            this.btnReplicate.Text = "&Replicate";
            this.btnReplicate.UseVisualStyleBackColor = true;
            this.btnReplicate.Click += new System.EventHandler(this.btnReplicate_Click);
            // 
            // progBrar
            // 
            this.progBrar.Location = new System.Drawing.Point(181, 223);
            this.progBrar.Name = "progBrar";
            this.progBrar.Size = new System.Drawing.Size(441, 32);
            this.progBrar.TabIndex = 3;
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressBar.Location = new System.Drawing.Point(40, 235);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(109, 20);
            this.lblProgressBar.TabIndex = 0;
            this.lblProgressBar.Text = "Progress Bar";
            this.lblProgressBar.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(181, 60);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(328, 23);
            this.txtSource.TabIndex = 4;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(181, 92);
            this.txtDestination.Multiline = true;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(328, 23);
            this.txtDestination.TabIndex = 4;
            this.txtDestination.Validating += new System.ComponentModel.CancelEventHandler(this.errorDestination);
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(529, 60);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(93, 23);
            this.btnSource.TabIndex = 5;
            this.btnSource.Text = "Browse";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // ofdSource
            // 
            this.ofdSource.FileName = "openFileDialog1";
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(529, 92);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(93, 23);
            this.btnDestination.TabIndex = 6;
            this.btnDestination.Text = "Browse";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // btnViewLog
            // 
            this.btnViewLog.Location = new System.Drawing.Point(181, 280);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(100, 31);
            this.btnViewLog.TabIndex = 7;
            this.btnViewLog.Text = "View &Log";
            this.btnViewLog.UseVisualStyleBackColor = true;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(529, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 31);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // errorpDestination
            // 
            this.errorpDestination.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 340);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.progBrar);
            this.Controls.Add(this.btnReplicate);
            this.Controls.Add(this.chkSubDirectories);
            this.Controls.Add(this.lblProgressBar);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblSource);
            this.Name = "Form1";
            this.Text = "Replicate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorpDestination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.CheckBox chkSubDirectories;
        private System.Windows.Forms.Button btnReplicate;
        private System.Windows.Forms.ProgressBar progBrar;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.OpenFileDialog ofdSource;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.FolderBrowserDialog fbdDestination;
        private System.Windows.Forms.ErrorProvider errorpDestination;
    }
}

