using System;
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

            // Hook events
            btnAttachMedia.Click += BtnAttachMedia_Click;
            btnSubmit.Click += BtnSubmit_Click;
            btnBack.Click += BtnBack_Click;

            // Hook fields for progress tracking
            txtReportName.TextChanged += FieldChanged;
            txtLocation.TextChanged += FieldChanged;
            cmbCategory.SelectedIndexChanged += FieldChanged;
            rtxtDescription.TextChanged += FieldChanged;

            pbProgress.Value = 0;
            btnSubmit.Enabled = false;
            lblStepIndicator.Text = "Step 0 of 4";
            lblEngagementMessage.Text = "Fill in the form to start the process.";

            // Load existing reports
            LoadReports();
        }

        // ---------- PROGRESS TRACKING ----------
        private async void FieldChanged(object sender, EventArgs e)
        {
            try
            {
                int progress = 0;
                int step = 0;

                if (!string.IsNullOrWhiteSpace(txtReportName.Text))
                {
                    step = 1; progress += 25;
                    lblStepIndicator.Text = $"Step {step} of 4: Report Name entered";
                    lblEngagementMessage.Text = "📌 Collecting report details...";
                    await UpdateProgress(progress);
                }
                else { ResetProgress("Please enter a report name."); return; }

                if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                {
                    step = 2; progress += 25;
                    lblStepIndicator.Text = $"Step {step} of 4: Location entered";
                    lblEngagementMessage.Text = "🔎 Validating location...";
                    await UpdateProgress(progress);
                }
                else { ResetProgress("Please enter the location."); return; }

                if (cmbCategory.SelectedIndex != -1)
                {
                    step = 3; progress += 25;
                    lblStepIndicator.Text = $"Step {step} of 4: Category selected";
                    lblEngagementMessage.Text = "📂 Confirming category selection...";
                    await UpdateProgress(progress);
                }
                else { ResetProgress("Please select a category."); return; }

                if (!string.IsNullOrWhiteSpace(rtxtDescription.Text))
                {
                    step = 4; progress += 25;
                    lblStepIndicator.Text = $"Step {step} of 4: Description entered";
                    lblEngagementMessage.Text = "📤 Description validated...";
                    await UpdateProgress(progress);
                }
                else { ResetProgress("Please enter a description."); return; }

                lblStepIndicator.Text = $"Step {step} of 4: All details completed!";
                lblEngagementMessage.Text = "✅ All details completed! You can now submit.";
                btnSubmit.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating progress: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UpdateProgress(int targetValue)
        {
            while (pbProgress.Value < targetValue)
            {
                pbProgress.Value += 1;
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
            try
            {
                openFileDialog1.Title = "Select a file or image";
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    attachedFilePath = openFileDialog1.FileName;
                    lblEngagementMessage.Text = "📎 File attached successfully!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error attaching file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string category = cmbCategory.SelectedItem?.ToString() ?? "Unspecified";

                // Save to CSV
                string line = $"\"{txtReportName.Text}\",\"{txtLocation.Text}\",\"{category}\",\"{rtxtDescription.Text}\",\"{attachedFilePath}\",{DateTime.Now}";
                File.AppendAllText(reportsFile, line + Environment.NewLine);

                // Add to ListBox
                string display = $"{txtReportName.Text} | {txtLocation.Text} | {category} | {DateTime.Now}";
                lstReports.Items.Add(display);

                // Confirmation
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ---------- LOAD SAVED REPORTS ----------
        private void LoadReports()
        {
            try
            {
                if (!File.Exists(reportsFile)) return;

                var lines = File.ReadAllLines(reportsFile);
                foreach (var line in lines)
                {
                    try
                    {
                        var parts = line.Split(',');
                        if (parts.Length >= 3)
                            lstReports.Items.Add($"{parts[0].Trim('\"')} | {parts[1].Trim('\"')} | {parts[2].Trim('\"')} | {parts[1]}");
                    }
                    catch
                    {
                        // skip corrupted line
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstReports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
