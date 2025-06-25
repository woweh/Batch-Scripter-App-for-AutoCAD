namespace Batch_Scripter
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnBrowseDrawings;
        private System.Windows.Forms.Button btnRemoveDrawings;
        private System.Windows.Forms.Button btnBrowseScript;
        private System.Windows.Forms.Button btnRunScript;
        private System.Windows.Forms.ListBox listBoxDrawings;
        private System.Windows.Forms.TextBox textBoxContents;
        private System.Windows.Forms.Label lblDrawingList;
        private System.Windows.Forms.Label lblScriptContent;
        private System.Windows.Forms.CheckBox chkSaveDrawings;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBrowseDrawings = new System.Windows.Forms.Button();
            this.btnRemoveDrawings = new System.Windows.Forms.Button();
            this.btnBrowseScript = new System.Windows.Forms.Button();
            this.btnRunScript = new System.Windows.Forms.Button();
            this.listBoxDrawings = new System.Windows.Forms.ListBox();
            this.textBoxContents = new System.Windows.Forms.TextBox();
            this.lblDrawingList = new System.Windows.Forms.Label();
            this.lblScriptContent = new System.Windows.Forms.Label();
            this.chkSaveDrawings = new System.Windows.Forms.CheckBox();
            this.linkLblFootnote = new System.Windows.Forms.LinkLabel();
            this.LinkedIn = new System.Windows.Forms.PictureBox();
            this.GitHub = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.linkLblLicense = new System.Windows.Forms.LinkLabel();
            this.linkLblHelp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LinkedIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowseDrawings
            // 
            this.btnBrowseDrawings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDrawings.Location = new System.Drawing.Point(738, 250);
            this.btnBrowseDrawings.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseDrawings.Name = "btnBrowseDrawings";
            this.btnBrowseDrawings.Size = new System.Drawing.Size(160, 28);
            this.btnBrowseDrawings.TabIndex = 0;
            this.btnBrowseDrawings.Text = "Browse Drawings";
            this.btnBrowseDrawings.UseVisualStyleBackColor = true;
            this.btnBrowseDrawings.Click += new System.EventHandler(this.btnBrowseDrawings_Click);
            // 
            // btnRemoveDrawings
            // 
            this.btnRemoveDrawings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveDrawings.Location = new System.Drawing.Point(906, 250);
            this.btnRemoveDrawings.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveDrawings.Name = "btnRemoveDrawings";
            this.btnRemoveDrawings.Size = new System.Drawing.Size(160, 28);
            this.btnRemoveDrawings.TabIndex = 1;
            this.btnRemoveDrawings.Text = "Remove Drawings";
            this.btnRemoveDrawings.UseVisualStyleBackColor = true;
            this.btnRemoveDrawings.Click += new System.EventHandler(this.btnRemoveDrawings_Click);
            // 
            // btnBrowseScript
            // 
            this.btnBrowseScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseScript.Location = new System.Drawing.Point(738, 527);
            this.btnBrowseScript.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseScript.Name = "btnBrowseScript";
            this.btnBrowseScript.Size = new System.Drawing.Size(160, 28);
            this.btnBrowseScript.TabIndex = 2;
            this.btnBrowseScript.Text = "Browse Scripts";
            this.btnBrowseScript.UseVisualStyleBackColor = true;
            this.btnBrowseScript.Click += new System.EventHandler(this.btnBrowseScript_Click);
            // 
            // btnRunScript
            // 
            this.btnRunScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunScript.Location = new System.Drawing.Point(906, 527);
            this.btnRunScript.Margin = new System.Windows.Forms.Padding(4);
            this.btnRunScript.Name = "btnRunScript";
            this.btnRunScript.Size = new System.Drawing.Size(160, 28);
            this.btnRunScript.TabIndex = 7;
            this.btnRunScript.Text = "Run Script";
            this.btnRunScript.UseVisualStyleBackColor = true;
            this.btnRunScript.Click += new System.EventHandler(this.btnRunScript_Click);
            // 
            // listBoxDrawings
            // 
            this.listBoxDrawings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDrawings.FormattingEnabled = true;
            this.listBoxDrawings.ItemHeight = 16;
            this.listBoxDrawings.Location = new System.Drawing.Point(16, 30);
            this.listBoxDrawings.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDrawings.Name = "listBoxDrawings";
            this.listBoxDrawings.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDrawings.Size = new System.Drawing.Size(1049, 212);
            this.listBoxDrawings.TabIndex = 3;
            // 
            // textBoxContents
            // 
            this.textBoxContents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContents.Location = new System.Drawing.Point(16, 306);
            this.textBoxContents.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContents.Multiline = true;
            this.textBoxContents.Name = "textBoxContents";
            this.textBoxContents.Size = new System.Drawing.Size(1049, 212);
            this.textBoxContents.TabIndex = 4;
            // 
            // lblDrawingList
            // 
            this.lblDrawingList.AutoSize = true;
            this.lblDrawingList.Location = new System.Drawing.Point(16, 9);
            this.lblDrawingList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrawingList.Name = "lblDrawingList";
            this.lblDrawingList.Size = new System.Drawing.Size(79, 16);
            this.lblDrawingList.TabIndex = 5;
            this.lblDrawingList.Text = "Drawing List";
            // 
            // lblScriptContent
            // 
            this.lblScriptContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblScriptContent.AutoSize = true;
            this.lblScriptContent.Location = new System.Drawing.Point(16, 286);
            this.lblScriptContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScriptContent.Name = "lblScriptContent";
            this.lblScriptContent.Size = new System.Drawing.Size(89, 16);
            this.lblScriptContent.TabIndex = 6;
            this.lblScriptContent.Text = "Script Content";
            // 
            // chkSaveDrawings
            // 
            this.chkSaveDrawings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSaveDrawings.AutoSize = true;
            this.chkSaveDrawings.Checked = true;
            this.chkSaveDrawings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveDrawings.Location = new System.Drawing.Point(611, 533);
            this.chkSaveDrawings.Margin = new System.Windows.Forms.Padding(4);
            this.chkSaveDrawings.Name = "chkSaveDrawings";
            this.chkSaveDrawings.Size = new System.Drawing.Size(120, 20);
            this.chkSaveDrawings.TabIndex = 8;
            this.chkSaveDrawings.Text = "Save Drawings";
            this.chkSaveDrawings.UseVisualStyleBackColor = true;
            // 
            // linkLblFootnote
            // 
            this.linkLblFootnote.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(174)))), ((int)(((byte)(16)))));
            this.linkLblFootnote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLblFootnote.AutoSize = true;
            this.linkLblFootnote.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLblFootnote.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.linkLblFootnote.Location = new System.Drawing.Point(158, 541);
            this.linkLblFootnote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLblFootnote.Name = "linkLblFootnote";
            this.linkLblFootnote.Size = new System.Drawing.Size(235, 16);
            this.linkLblFootnote.TabIndex = 11;
            this.linkLblFootnote.TabStop = true;
            this.linkLblFootnote.Text = "Created by Oliver Wackenreuther, v1.0";
            this.linkLblFootnote.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.linkLblFootnote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblFootnote_LinkClicked);
            // 
            // LinkedIn
            // 
            this.LinkedIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LinkedIn.Image = global::Batch_Scripter.Properties.Resources.LI_In_Bug;
            this.LinkedIn.Location = new System.Drawing.Point(115, 526);
            this.LinkedIn.Margin = new System.Windows.Forms.Padding(4);
            this.LinkedIn.Name = "LinkedIn";
            this.LinkedIn.Size = new System.Drawing.Size(35, 30);
            this.LinkedIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LinkedIn.TabIndex = 14;
            this.LinkedIn.TabStop = false;
            this.LinkedIn.Click += new System.EventHandler(this.LinkedIn_Click);
            // 
            // GitHub
            // 
            this.GitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GitHub.Image = global::Batch_Scripter.Properties.Resources.github_mark_white;
            this.GitHub.Location = new System.Drawing.Point(77, 526);
            this.GitHub.Margin = new System.Windows.Forms.Padding(4);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(30, 30);
            this.GitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GitHub.TabIndex = 13;
            this.GitHub.TabStop = false;
            this.GitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Logo.Image = global::Batch_Scripter.Properties.Resources.Logo_BW_NOBG;
            this.Logo.Location = new System.Drawing.Point(16, 525);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(53, 30);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 12;
            this.Logo.TabStop = false;
            // 
            // linkLblLicense
            // 
            this.linkLblLicense.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(174)))), ((int)(((byte)(16)))));
            this.linkLblLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLblLicense.AutoSize = true;
            this.linkLblLicense.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLblLicense.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.linkLblLicense.Location = new System.Drawing.Point(411, 541);
            this.linkLblLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLblLicense.Name = "linkLblLicense";
            this.linkLblLicense.Size = new System.Drawing.Size(91, 16);
            this.linkLblLicense.TabIndex = 15;
            this.linkLblLicense.TabStop = true;
            this.linkLblLicense.Text = "MIT License ©";
            this.linkLblLicense.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.linkLblLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblLicense_LinkClicked);
            // 
            // linkLblHelp
            // 
            this.linkLblHelp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(174)))), ((int)(((byte)(16)))));
            this.linkLblHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLblHelp.AutoSize = true;
            this.linkLblHelp.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLblHelp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.linkLblHelp.Location = new System.Drawing.Point(510, 541);
            this.linkLblHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLblHelp.Name = "linkLblHelp";
            this.linkLblHelp.Size = new System.Drawing.Size(36, 16);
            this.linkLblHelp.TabIndex = 16;
            this.linkLblHelp.TabStop = true;
            this.linkLblHelp.Text = "Help";
            this.linkLblHelp.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.linkLblHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblHelp_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1082, 567);
            this.Controls.Add(this.linkLblHelp);
            this.Controls.Add(this.linkLblLicense);
            this.Controls.Add(this.LinkedIn);
            this.Controls.Add(this.GitHub);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.linkLblFootnote);
            this.Controls.Add(this.chkSaveDrawings);
            this.Controls.Add(this.btnRunScript);
            this.Controls.Add(this.lblScriptContent);
            this.Controls.Add(this.lblDrawingList);
            this.Controls.Add(this.textBoxContents);
            this.Controls.Add(this.listBoxDrawings);
            this.Controls.Add(this.btnBrowseScript);
            this.Controls.Add(this.btnRemoveDrawings);
            this.Controls.Add(this.btnBrowseDrawings);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 605);
            this.Name = "MainForm";
            this.Text = "Batch Scripter";
            ((System.ComponentModel.ISupportInitialize)(this.LinkedIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.LinkLabel linkLblFootnote;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox GitHub;
        private System.Windows.Forms.PictureBox LinkedIn;
        private System.Windows.Forms.LinkLabel linkLblLicense;
        private System.Windows.Forms.LinkLabel linkLblHelp;
    }
}
