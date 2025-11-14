using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalApp
{
    partial class ServiceRequestStatusForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private ListBox listBoxRequests;
        private Label lblSearch;
        private TextBox txtSearchId;
        private Button btnSearch;
        private Button btnBack;
        private Label lblDetails;
        private TextBox txtDetails;
        private TreeView graphView;

        private FlowLayoutPanel dsFlowPanel;
        private Panel panelHeap, panelSorted, panelCategories, panelHistory, panelNavigation;
        private ListBox listBoxHeap, listBoxSorted, listBoxCategories, listBoxHistory, listBoxNavigation;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Title
            lblTitle = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = Color.DarkSlateBlue,
                Location = new Point(20, 15),
                Text = "Service Request Status Tracker",
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            // Requests ListBox
            listBoxRequests = new ListBox
            {
                Location = new Point(20, 70),
                Size = new Size(300, 300),
                BackColor = Color.LightSteelBlue,
                Font = new Font("Segoe UI", 10F),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom
            };
            listBoxRequests.SelectedIndexChanged += listBoxRequests_SelectedIndexChanged;

            // Request Details
            lblDetails = new Label
            {
                Location = new Point(340, 15),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.DarkGreen,
                Text = "Request Details:",
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            txtDetails = new TextBox
            {
                Location = new Point(340, 50),
               
               Size = new Size(400, 120),
                Multiline = true,
                ReadOnly = true,
                BackColor = Color.AliceBlue,
                ForeColor = Color.DarkBlue,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Segoe UI", 10F),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            // Graph view
            graphView = new TreeView
            {
                Location = new Point(340, 260),
                Size = new Size(400, 120),
                BackColor = Color.WhiteSmoke,
                Font = new Font("Segoe UI", 10F),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            // Search controls
            lblSearch = new Label
            {
                Location = new Point(20, 380),
                Text = "Enter Request ID:",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.MidnightBlue,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };

            txtSearchId = new TextBox
            {
                Location = new Point(150, 380),
                Size = new Size(120, 22),
                Font = new Font("Segoe UI", 10F),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };

            btnSearch = new Button
            {
                Location = new Point(280, 380),
                Size = new Size(80, 28),
                Text = "Search",
                BackColor = Color.MediumSlateBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Click += btnSearch_Click;

            btnBack = new Button
            {
                Location = new Point(370, 380),
                Size = new Size(80, 28),
                Text = "Back",
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Click += btnBack_Click;

            // ----------------------------
            // FlowLayoutPanel for DS panels
            // ----------------------------
            dsFlowPanel = new FlowLayoutPanel
            {
                Location = new Point(20, 420),
                Size = new Size(860, 250),
                AutoScroll = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            // Panels for DS visualization
            panelHeap = CreateDSPanel("MinHeap (Priority)", out listBoxHeap, Color.LavenderBlush);
            panelSorted = CreateDSPanel("Sorted Dictionary", out listBoxSorted, Color.Lavender);
            panelCategories = CreateDSPanel("Unique Statuses (Set)", out listBoxCategories, Color.Honeydew);
            panelHistory = CreateDSPanel("Action History (Stack)", out listBoxHistory, Color.MistyRose);
            panelNavigation = CreateDSPanel("Navigation Queue", out listBoxNavigation, Color.LemonChiffon);

            dsFlowPanel.Controls.Add(panelHeap);
            dsFlowPanel.Controls.Add(panelSorted);
            dsFlowPanel.Controls.Add(panelCategories);
            dsFlowPanel.Controls.Add(panelHistory);
            dsFlowPanel.Controls.Add(panelNavigation);

            // Form properties
            this.ClientSize = new Size(900, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Service Request Status";

            // Add controls
            this.Controls.Add(lblTitle);
            this.Controls.Add(listBoxRequests);
            this.Controls.Add(lblDetails);
            this.Controls.Add(txtDetails);
            this.Controls.Add(graphView);
            this.Controls.Add(lblSearch);
            this.Controls.Add(txtSearchId);
            this.Controls.Add(btnSearch);
            this.Controls.Add(btnBack);
            this.Controls.Add(dsFlowPanel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Panel CreateDSPanel(string title, out ListBox listBox, Color backColor)
        {
            Panel panel = new Panel
            {
                Size = new Size(250, 120),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Margin = new Padding(10)
            };

            Label lbl = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(5, 5),
                AutoSize = true
            };

            listBox = new ListBox
            {
                Location = new Point(5, 25),
                Size = new Size(240, 90),
                BackColor = backColor,
                Font = new Font("Segoe UI", 9F)
            };

            panel.Controls.Add(lbl);
            panel.Controls.Add(listBox);
            return panel;
        }
    }
}
