using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // -----------------------------
        // BUTTON EVENT HANDLERS
        // -----------------------------

        // Open the Report Issues form
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportForm = new ReportIssuesForm();
            reportForm.Show();

            // Hide the Main Menu while the ReportIssuesForm is open
            this.Hide();

            // Show Main Menu again when ReportIssuesForm closes
            reportForm.FormClosed += (s, args) => this.Show();
        }

        // Placeholder for Local Events feature
        private void btnLocalEvents_Click(object sender, EventArgs e)
        {

            LocalEventsForm localEventsForm = new LocalEventsForm();
            localEventsForm.ShowDialog();
        }

        

        // Placeholder for Service Status feature
        private void btnServiceStatus_Click(object sender, EventArgs e)
        {
        
            var statusForm = new ServiceRequestStatusForm();
            statusForm.ShowDialog();
        }


        // Close the application when Main Menu form is closed
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
 