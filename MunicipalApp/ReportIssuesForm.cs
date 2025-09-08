using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalApp
{
    public partial class ReportIssuesForm : Form
    {
        private string attachedFilePath = string.Empty;
        private string reportsFile = Path.Combine(Application.StartupPath, "Reports.csv");

        public ReportIssuesForm()
        {
            InitializeComponent();

            // Button events
            btnAttachMedia.Click += BtnAttachMedia_Click;
            btnSubmit.Click += BtnSubmit_Click;
            btnBack.Click += BtnBack_Click;

            // Field events for progress tracking
            txtReportName.TextChanged += FieldChanged;
            txtLocation.TextChanged += FieldChanged;
            cmbCategory.SelectedIndexChanged += FieldChanged;
            rtxtDescription.TextChanged += FieldChanged;

            pbProgress.Value = 0;
            btnSubmit.Enabled = false;
            lblStepIndicator.Text = "Step 0 of 4";
            lblEngagementMessage.Text = "Fill in the form to start.";

            LoadReports();
        }

        // ---------- PROGRESS TRACKING ----------
        private async void FieldChanged(object sender, EventArgs e)
        {
            int progress = 0;
            int step = 0;

            if (!string.IsNullOrWhiteSpace(txtReportName.Text)) { step = 1; progress += 25; lblStepIndicator.Text = $"Step {step} of 4"; lblEngagementMessage.Text = "Report Name entered"; }
            else { ResetProgress("Please enter a report name."); return; }

            if (!string.IsNullOrWhiteSpace(txtLocation.Text)) { step = 2; progress += 25; lblStepIndicator.Text = $"Step {step} of 4"; lblEngagementMessage.Text = "Location entered"; }
            else { ResetProgress("Please enter the location."); return; }

            if (cmbCategory.SelectedIndex != -1) { step = 3; progress += 25; lblStepIndicator.Text = $"Step {step} of 4"; lblEngagementMessage.Text = "Category selected"; }
            else { ResetProgress("Please select a category."); return; }

            if (!string.IsNullOrWhiteSpace(rtxtDescription.Text)) { step = 4; progress += 25; lblStepIndicator.Text = $"Step {step} of 4"; lblEngagementMessage.Text = "Description entered"; }
            else { ResetProgress("Please enter a description."); return; }

            await UpdateProgress(progress);
            lblStepIndicator.Text = $"Step {step} of 4: Complete";
            lblEngagementMessage.Text = "✅ All details completed. You can now submit.";
            btnSubmit.Enabled = true;
        }

        private async Task UpdateProgress(int targetValue)
        {
            while (pbProgress.Value < targetValue)
            {
                pbProgress.Value++;
                await Task.Delay(10);
            }
        }

        private void ResetProgress(string message)
        {
            pbProgress.Value = 0;
            lblStepIndicator.Text = "Step 0 of 4";
            lblEngagementMessage.Text = message;
            btnSubmit.Enabled = false;
        }

        // ---------- BUTTON EVENTS ----------
        private void BtnAttachMedia_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a file or image";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                attachedFilePath = openFileDialog1.FileName;
                lblEngagementMessage.Text = "📎 File attached successfully!";
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // ---------- VALIDATION ----------
                if (string.IsNullOrWhiteSpace(txtReportName.Text))
                {
                    MessageBox.Show("Please enter the Report Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReportName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtLocation.Text))
                {
                    MessageBox.Show("Please enter the Location.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLocation.Focus();
                    return;
                }

                if (cmbCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Category.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbCategory.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(rtxtDescription.Text))
                {
                    MessageBox.Show("Please enter the Description.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtxtDescription.Focus();
                    return;
                }

                // ---------- SAVE REPORT ----------
                string category = cmbCategory.SelectedItem.ToString();
                string line = $"\"{txtReportName.Text}\",\"{txtLocation.Text}\",\"{category}\",\"{rtxtDescription.Text}\",\"{attachedFilePath}\",{DateTime.Now}";
                File.AppendAllText(reportsFile, line + Environment.NewLine);

                // Load image if attached
                Image img = null;
                if (!string.IsNullOrWhiteSpace(attachedFilePath) && File.Exists(attachedFilePath))
                {
                    using (var fs = new FileStream(attachedFilePath, FileMode.Open, FileAccess.Read))
                        img = new Bitmap(fs);
                }

                // Add to DataGridView
                dgvReports.Rows.Add(txtReportName.Text, txtLocation.Text, category, rtxtDescription.Text, img);

                MessageBox.Show("Report submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form
                txtReportName.Clear();
                txtLocation.Clear();
                cmbCategory.SelectedIndex = -1;
                rtxtDescription.Clear();
                attachedFilePath = string.Empty;
                pbProgress.Value = 0;
                btnSubmit.Enabled = false;
                lblStepIndicator.Text = "Step 0 of 4";
                lblEngagementMessage.Text = "Ready for a new report.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnBack_Click(object sender, EventArgs e) => Close();

        // ---------- LOAD REPORTS ----------
        private void LoadReports()
        {
            if (!File.Exists(reportsFile)) return;

            dgvReports.Rows.Clear();

            foreach (var line in File.ReadAllLines(reportsFile))
            {
                var parts = line.Split(',');
                if (parts.Length < 5) continue;

                string reportName = parts[0].Trim('"');
                string location = parts[1].Trim('"');
                string category = parts[2].Trim('"');
                string description = parts[3].Trim('"');
                string imagePath = parts[4].Trim('"');

                Image img = null;
                if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
                {
                    using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        img = new Bitmap(fs);
                }

                dgvReports.Rows.Add(reportName, location, category, description, img);
            }
        }
    }
}
