namespace Jofroop_s_DLP_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openExe = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.helpButton = new System.Windows.Forms.Button();
            this.linkInputLabel = new System.Windows.Forms.Label();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.dlpPathLabel = new System.Windows.Forms.Label();
            this.outputPathSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkInput
            // 
            this.linkInput.AcceptsTab = true;
            this.linkInput.ForeColor = System.Drawing.Color.Black;
            this.linkInput.HideSelection = false;
            this.linkInput.Location = new System.Drawing.Point(12, 28);
            this.linkInput.Multiline = true;
            this.linkInput.Name = "linkInput";
            this.linkInput.Size = new System.Drawing.Size(386, 79);
            this.linkInput.TabIndex = 0;
            this.linkInput.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.Location = new System.Drawing.Point(404, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 79);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openExe
            // 
            this.openExe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openExe.BackgroundImage")));
            this.openExe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openExe.Location = new System.Drawing.Point(489, 28);
            this.openExe.Name = "openExe";
            this.openExe.Size = new System.Drawing.Size(79, 79);
            this.openExe.TabIndex = 3;
            this.openExe.UseVisualStyleBackColor = true;
            this.openExe.Click += new System.EventHandler(this.openExe_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpButton.BackgroundImage")));
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.Location = new System.Drawing.Point(741, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(40, 40);
            this.helpButton.TabIndex = 4;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // linkInputLabel
            // 
            this.linkInputLabel.AutoSize = true;
            this.linkInputLabel.Location = new System.Drawing.Point(12, 9);
            this.linkInputLabel.Name = "linkInputLabel";
            this.linkInputLabel.Size = new System.Drawing.Size(86, 13);
            this.linkInputLabel.TabIndex = 5;
            this.linkInputLabel.Text = "Link goes here...";
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.Location = new System.Drawing.Point(401, 9);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(55, 13);
            this.downloadLabel.TabIndex = 6;
            this.downloadLabel.Text = "Download";
            // 
            // dlpPathLabel
            // 
            this.dlpPathLabel.AutoSize = true;
            this.dlpPathLabel.Location = new System.Drawing.Point(486, 9);
            this.dlpPathLabel.Name = "dlpPathLabel";
            this.dlpPathLabel.Size = new System.Drawing.Size(69, 13);
            this.dlpPathLabel.TabIndex = 7;
            this.dlpPathLabel.Text = "YT-DLP path";
            // 
            // outputPathSet
            // 
            this.outputPathSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("outputPathSet.BackgroundImage")));
            this.outputPathSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.outputPathSet.Location = new System.Drawing.Point(574, 28);
            this.outputPathSet.Name = "outputPathSet";
            this.outputPathSet.Size = new System.Drawing.Size(79, 79);
            this.outputPathSet.TabIndex = 8;
            this.outputPathSet.UseVisualStyleBackColor = true;
            this.outputPathSet.Click += new System.EventHandler(this.outputPathSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Output path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 119);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputPathSet);
            this.Controls.Add(this.dlpPathLabel);
            this.Controls.Add(this.downloadLabel);
            this.Controls.Add(this.linkInputLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.openExe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jofroop\'s DLP GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox linkInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button openExe;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label linkInputLabel;
        private System.Windows.Forms.Label downloadLabel;
        private System.Windows.Forms.Label dlpPathLabel;
        private System.Windows.Forms.Button outputPathSet;
        private System.Windows.Forms.Label label1;
    }
}

