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
            this.panelForm = new Panel();
            this.lblTitle = new Label();
            this.lblReportName = new Label();
            this.txtReportName = new TextBox();
            this.lblLocation = new Label();
            this.txtLocation = new TextBox();
            this.lblCategory = new Label();
            this.cmbCategory = new ComboBox();
            this.lblDescription = new Label();
            this.rtxtDescription = new RichTextBox();
            this.btnAttachMedia = new Button();
            this.lblStepIndicator = new Label();
            this.pbProgress = new ProgressBar();
            this.lblEngagementMessage = new Label();
            this.btnBack = new Button();
            this.btnSubmit = new Button();
            this.openFileDialog1 = new OpenFileDialog();

            this.panelBoard = new Panel();
            this.dgvReports = new DataGridView();
            this.colReportName = new DataGridViewTextBoxColumn();
            this.colLocation = new DataGridViewTextBoxColumn();
            this.colCategory = new DataGridViewTextBoxColumn();
            this.colDescription = new DataGridViewTextBoxColumn();
            this.colImage = new DataGridViewImageColumn();

            this.panelForm.SuspendLayout();
            this.panelBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();

            // ---------- Left Panel ----------
            this.panelForm.BackColor = Color.FromArgb(240, 245, 255);
            this.panelForm.Dock = DockStyle.Left;
            this.panelForm.Width = 600;
            this.panelForm.Padding = new Padding(20);
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

            // Title
            this.lblTitle.Text = "Report an Issue";
            this.lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(20, 60, 120);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.AutoSize = true;

            // Labels & Fields
            Font labelFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            Color labelColor = Color.FromArgb(30, 30, 30);

            this.lblReportName.Text = "Report Name:";
            this.lblReportName.Font = labelFont;
            this.lblReportName.ForeColor = labelColor;
            this.lblReportName.Location = new Point(20, 80);

            this.txtReportName.Location = new Point(20, 110);
            this.txtReportName.Width = 400;
            this.txtReportName.Font = new Font("Segoe UI", 12F);

            this.lblLocation.Text = "Location:";
            this.lblLocation.Font = labelFont;
            this.lblLocation.ForeColor = labelColor;
            this.lblLocation.Location = new Point(20, 150);

            this.txtLocation.Location = new Point(20, 180);
            this.txtLocation.Width = 400;
            this.txtLocation.Font = new Font("Segoe UI", 12F);

            this.lblCategory.Text = "Category:";
            this.lblCategory.Font = labelFont;
            this.lblCategory.ForeColor = labelColor;
            this.lblCategory.Location = new Point(20, 220);

            this.cmbCategory.Location = new Point(20, 250);
            this.cmbCategory.Width = 400;
            this.cmbCategory.Font = new Font("Segoe UI", 12F);
            this.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[] { "Sanitation", "Roads", "Utilities", "Public Safety", "Environmental", "Other" });

            this.lblDescription.Text = "Description:";
            this.lblDescription.Font = labelFont;
            this.lblDescription.ForeColor = labelColor;
            this.lblDescription.Location = new Point(20, 290);

            this.rtxtDescription.Location = new Point(20, 320);
            this.rtxtDescription.Size = new Size(400, 120);
            this.rtxtDescription.Font = new Font("Segoe UI", 12F);

            // Attach Media Button
            this.btnAttachMedia.Text = "Attach Media";
            this.btnAttachMedia.BackColor = Color.FromArgb(70, 105, 174);
            this.btnAttachMedia.ForeColor = Color.White;
            this.btnAttachMedia.FlatStyle = FlatStyle.Flat;
            this.btnAttachMedia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnAttachMedia.Location = new Point(20, 450);
            this.btnAttachMedia.Size = new Size(150, 40);

            // Progress & Step
            this.lblStepIndicator.Location = new Point(200, 460);
            this.lblStepIndicator.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblStepIndicator.ForeColor = Color.DarkBlue;

            this.pbProgress.Location = new Point(20, 500);
            this.pbProgress.Width = 400;
            this.pbProgress.Height = 20;

            this.lblEngagementMessage.Location = new Point(20, 530);
            this.lblEngagementMessage.Width = 400;
            this.lblEngagementMessage.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblEngagementMessage.ForeColor = Color.DarkGreen;

            // Back & Submit Buttons
            this.btnBack.Text = "Back";
            this.btnBack.Location = new Point(20, 580);
            this.btnBack.Size = new Size(120, 40);
            this.btnBack.BackColor = Color.Gray;
            this.btnBack.ForeColor = Color.White;
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Location = new Point(300, 580);
            this.btnSubmit.Size = new Size(120, 40);
            this.btnSubmit.BackColor = Color.Green;
            this.btnSubmit.ForeColor = Color.White;
            this.btnSubmit.FlatStyle = FlatStyle.Flat;
            this.btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            // ---------- Right Panel ----------
            this.panelBoard.Dock = DockStyle.Fill;
            this.panelBoard.BackColor = Color.FromArgb(230, 230, 230);
            this.panelBoard.Padding = new Padding(10);
            this.panelBoard.Controls.Add(this.dgvReports);

            this.dgvReports.Dock = DockStyle.Fill;
            this.dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.RowTemplate.Height = 60;
            this.dgvReports.Font = new Font("Segoe UI", 11F);
            this.dgvReports.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.dgvReports.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvReports.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 130, 180);
            this.dgvReports.EnableHeadersVisualStyles = false;

            this.dgvReports.Columns.AddRange(new DataGridViewColumn[] { this.colReportName, this.colLocation, this.colCategory, this.colDescription, this.colImage });

            // Columns
            this.colReportName.HeaderText = "Report Name";
            this.colLocation.HeaderText = "Location";
            this.colCategory.HeaderText = "Category";
            this.colDescription.HeaderText = "Description";
            this.colImage.HeaderText = "Attached Image";
            this.colImage.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // ---------- Form ----------
            this.ClientSize = new Size(1000, 700);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.panelForm);
            this.Text = "Municipal Services - Report an Issue";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelForm;
        private Panel panelBoard;
        private Label lblTitle;
        private Label lblReportName;
        private TextBox txtReportName;
        private Label lblLocation;
        private TextBox txtLocation;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblDescription;
        private RichTextBox rtxtDescription;
        private Button btnAttachMedia;
        private Button btnSubmit;
        private Button btnBack;
        private Label lblStepIndicator;
        private ProgressBar pbProgress;
        private Label lblEngagementMessage;
        private DataGridView dgvReports;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn colReportName;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewImageColumn colImage;
    }
}
