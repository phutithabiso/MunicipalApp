using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalApp
{
    partial class ReportIssuesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblAttachedFiles = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReportName = new System.Windows.Forms.Label();
            this.txtReportName = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.lblStepIndicator = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblEngagementMessage = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.lstReports = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelForm.Controls.Add(this.lblAttachedFiles);
            this.panelForm.Controls.Add(this.pictureBox1);
            this.panelForm.Controls.Add(this.lblTitle);
            this.panelForm.Controls.Add(this.lblReportName);
            this.panelForm.Controls.Add(this.txtReportName);
            this.panelForm.Controls.Add(this.lblLocation);
            this.panelForm.Controls.Add(this.txtLocation);
            this.panelForm.Controls.Add(this.lblCategory);
            this.panelForm.Controls.Add(this.cmbCategory);
            this.panelForm.Controls.Add(this.lblDescription);
            this.panelForm.Controls.Add(this.rtxtDescription);
            this.panelForm.Controls.Add(this.btnAttachMedia);
            this.panelForm.Controls.Add(this.lblStepIndicator);
            this.panelForm.Controls.Add(this.pbProgress);
            this.panelForm.Controls.Add(this.lblEngagementMessage);
            this.panelForm.Controls.Add(this.btnBack);
            this.panelForm.Controls.Add(this.btnSubmit);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panelForm.Size = new System.Drawing.Size(867, 937);
            this.panelForm.TabIndex = 0;
            // 
            // lblAttachedFiles
            // 
            this.lblAttachedFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblAttachedFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.lblAttachedFiles.Location = new System.Drawing.Point(240, 572);
            this.lblAttachedFiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttachedFiles.Name = "lblAttachedFiles";
            this.lblAttachedFiles.Size = new System.Drawing.Size(267, 31);
            this.lblAttachedFiles.TabIndex = 16;
            this.lblAttachedFiles.Text = "No files attached";
            this.lblAttachedFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.lblTitle.Location = new System.Drawing.Point(27, 86);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Report an Issue";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReportName
            // 
            this.lblReportName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReportName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.lblReportName.Location = new System.Drawing.Point(27, 185);
            this.lblReportName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Size = new System.Drawing.Size(160, 31);
            this.lblReportName.TabIndex = 1;
            this.lblReportName.Text = "Report Name:";
            this.lblReportName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReportName
            // 
            this.txtReportName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReportName.Location = new System.Drawing.Point(200, 185);
            this.txtReportName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReportName.Name = "txtReportName";
            this.txtReportName.Size = new System.Drawing.Size(599, 30);
            this.txtReportName.TabIndex = 2;
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.lblLocation.Location = new System.Drawing.Point(27, 240);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(160, 31);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLocation
            // 
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLocation.Location = new System.Drawing.Point(200, 240);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(599, 30);
            this.txtLocation.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.lblCategory.Location = new System.Drawing.Point(27, 295);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(160, 31);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities (Water/Electricity)",
            "Public Safety",
            "Environmental",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(200, 295);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(599, 31);
            this.cmbCategory.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.lblDescription.Location = new System.Drawing.Point(27, 351);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(160, 31);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtxtDescription.Location = new System.Drawing.Point(200, 351);
            this.rtxtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(599, 184);
            this.rtxtDescription.TabIndex = 8;
            this.rtxtDescription.Text = "";
            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(105)))), ((int)(((byte)(174)))));
            this.btnAttachMedia.FlatAppearance.BorderSize = 0;
            this.btnAttachMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachMedia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAttachMedia.ForeColor = System.Drawing.Color.White;
            this.btnAttachMedia.Location = new System.Drawing.Point(27, 566);
            this.btnAttachMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(200, 43);
            this.btnAttachMedia.TabIndex = 9;
            this.btnAttachMedia.Text = "Attach Media";
            this.btnAttachMedia.UseVisualStyleBackColor = false;
            // 
            // lblStepIndicator
            // 
            this.lblStepIndicator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStepIndicator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.lblStepIndicator.Location = new System.Drawing.Point(267, 572);
            this.lblStepIndicator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepIndicator.Name = "lblStepIndicator";
            this.lblStepIndicator.Size = new System.Drawing.Size(533, 31);
            this.lblStepIndicator.TabIndex = 13;
            this.lblStepIndicator.Text = "Step 1 of 4";
            this.lblStepIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(27, 634);
            this.pbProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(773, 25);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgress.TabIndex = 14;
            this.pbProgress.Value = 25;
            // 
            // lblEngagementMessage
            // 
            this.lblEngagementMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblEngagementMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.lblEngagementMessage.Location = new System.Drawing.Point(27, 671);
            this.lblEngagementMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEngagementMessage.Name = "lblEngagementMessage";
            this.lblEngagementMessage.Size = new System.Drawing.Size(773, 31);
            this.lblEngagementMessage.TabIndex = 12;
            this.lblEngagementMessage.Text = "Complete the form to report your issue.";
            this.lblEngagementMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(27, 726);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 49);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(600, 726);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 49);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit Report";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // panelBoard
            // 
            this.panelBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBoard.Controls.Add(this.lstReports);
            this.panelBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBoard.Location = new System.Drawing.Point(867, 0);
            this.panelBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panelBoard.Size = new System.Drawing.Size(712, 937);
            this.panelBoard.TabIndex = 1;
            // 
            // lstReports
            // 
            this.lstReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstReports.FormattingEnabled = true;
            this.lstReports.ItemHeight = 23;
            this.lstReports.Location = new System.Drawing.Point(13, 12);
            this.lstReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstReports.Name = "lstReports";
            this.lstReports.Size = new System.Drawing.Size(686, 913);
            this.lstReports.TabIndex = 0;
            this.lstReports.SelectedIndexChanged += new System.EventHandler(this.lstReports_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 937);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.panelForm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1327, 728);
            this.Name = "ReportIssuesForm";
            this.Text = "Municipal Services - Report an Issue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.TextBox txtReportName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Button btnAttachMedia;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEngagementMessage;
        private System.Windows.Forms.Label lblStepIndicator;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.ListBox lstReports;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAttachedFiles;
    }
}