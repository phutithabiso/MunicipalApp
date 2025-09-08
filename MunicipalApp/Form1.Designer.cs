namespace MunicipalApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnServiceStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel mainLayout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.btnServiceStatus = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();

            // mainLayout
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.RowCount = 5;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainLayout.Padding = new System.Windows.Forms.Padding(50);

            // lblTitle
            this.lblTitle.Text = "Municipal Services Portal";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;

            // btnReportIssues
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.ForeColor = System.Drawing.Color.White;
            this.btnReportIssues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);

            // btnLocalEvents
            this.btnLocalEvents.Text = "Local Events and Announcements";
            this.btnLocalEvents.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLocalEvents.Enabled = false;
            this.btnLocalEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalEvents.ForeColor = System.Drawing.Color.White;
            this.btnLocalEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLocalEvents.Click += new System.EventHandler(this.btnLocalEvents_Click);

            // btnServiceStatus
            this.btnServiceStatus.Text = "Service Request Status";
            this.btnServiceStatus.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnServiceStatus.Enabled = false;
            this.btnServiceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceStatus.ForeColor = System.Drawing.Color.White;
            this.btnServiceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServiceStatus.Click += new System.EventHandler(this.btnServiceStatus_Click);

            // Add controls to mainLayout
            this.mainLayout.Controls.Add(this.lblTitle, 0, 0);
            this.mainLayout.Controls.Add(this.btnReportIssues, 0, 1);
            this.mainLayout.Controls.Add(this.btnLocalEvents, 0, 2);
            this.mainLayout.Controls.Add(this.btnServiceStatus, 0, 3);

            // Form1
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainLayout);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "Municipal Services Application - Main Menu";
        }
    }
}
