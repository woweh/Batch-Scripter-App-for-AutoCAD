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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowseDrawings
            // 
            this.btnBrowseDrawings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDrawings.Location = new System.Drawing.Point(701, 250);
            this.btnBrowseDrawings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnRemoveDrawings.Location = new System.Drawing.Point(869, 250);
            this.btnRemoveDrawings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnBrowseScript.Location = new System.Drawing.Point(701, 527);
            this.btnBrowseScript.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnRunScript.Location = new System.Drawing.Point(869, 527);
            this.btnRunScript.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.listBoxDrawings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxDrawings.Name = "listBoxDrawings";
            this.listBoxDrawings.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDrawings.Size = new System.Drawing.Size(1012, 212);
            this.listBoxDrawings.TabIndex = 3;
            // 
            // textBoxContents
            // 
            this.textBoxContents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContents.Location = new System.Drawing.Point(16, 306);
            this.textBoxContents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxContents.Multiline = true;
            this.textBoxContents.Name = "textBoxContents";
            this.textBoxContents.Size = new System.Drawing.Size(1012, 212);
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
            this.chkSaveDrawings.Location = new System.Drawing.Point(574, 533);
            this.chkSaveDrawings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.linkLblFootnote.Location = new System.Drawing.Point(77, 533);
            this.linkLblFootnote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLblFootnote.Name = "linkLblFootnote";
            this.linkLblFootnote.Size = new System.Drawing.Size(235, 16);
            this.linkLblFootnote.TabIndex = 11;
            this.linkLblFootnote.TabStop = true;
            this.linkLblFootnote.Text = "Created by Oliver Wackenreuther, v1.0";
            this.linkLblFootnote.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.linkLblFootnote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblFootnote_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::Batch_Scripter.Properties.Resources.Logo_BW_NOBG;
            this.pictureBox1.Location = new System.Drawing.Point(16, 527);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1061, 605);
            this.Name = "MainForm";
            this.Text = "Batch Scripter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.LinkLabel linkLblFootnote;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
