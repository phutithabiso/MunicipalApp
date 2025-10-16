using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalApp
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private ComboBox cmbCategoryFilter;
        private DateTimePicker dtpDateFilter;
        private Button btnSearch;
        private ListBox lstEvents;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 600);
            this.Text = "Local Events and Announcements";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(this.LocalEventsForm_Load);

            // Title
            lblTitle = new Label();
            lblTitle.Text = "Local Events & Announcements";
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Size = new Size(760, 50);
            lblTitle.Location = new Point(20, 10);
            this.Controls.Add(lblTitle);

            // Category Filter
            cmbCategoryFilter = new ComboBox();
            cmbCategoryFilter.Location = new Point(20, 80);
            cmbCategoryFilter.Width = 200;
            cmbCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoryFilter.Items.Add("All");
            cmbCategoryFilter.SelectedIndex = 0;
            this.Controls.Add(cmbCategoryFilter);

            Label lblCat = new Label();
            lblCat.Text = "Filter by Category:";
            lblCat.Location = new Point(20, 60);
            lblCat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Controls.Add(lblCat);

            // Date Filter
            dtpDateFilter = new DateTimePicker();
            dtpDateFilter.Location = new Point(250, 80);
            dtpDateFilter.Width = 200;
            dtpDateFilter.Format = DateTimePickerFormat.Short;
            this.Controls.Add(dtpDateFilter);

            Label lblDate = new Label();
            lblDate.Text = "Filter by Date:";
            lblDate.Location = new Point(250, 60);
            lblDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Controls.Add(lblDate);

            // Search Button
            btnSearch = new Button();
            btnSearch.Text = "Search";
            btnSearch.Location = new Point(480, 80);
            btnSearch.Size = new Size(100, 30);
            btnSearch.BackColor = Color.MediumSeaGreen;
            btnSearch.ForeColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.Click += new EventHandler(this.BtnSearch_Click);
            this.Controls.Add(btnSearch);

            // Events List
            lstEvents = new ListBox();
            lstEvents.Location = new Point(20, 130);
            lstEvents.Size = new Size(760, 400);
            lstEvents.Font = new Font("Segoe UI", 11F);
            this.Controls.Add(lstEvents);

            // Back Button
            btnBack = new Button();
            btnBack.Text = "Back";
            btnBack.Location = new Point(20, 550);
            btnBack.Size = new Size(100, 35);
            btnBack.BackColor = Color.Gray;
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.Click += new EventHandler(this.BtnBack_Click);
            this.Controls.Add(btnBack);

            this.ResumeLayout(false);
        }

        #endregion
    }
}
