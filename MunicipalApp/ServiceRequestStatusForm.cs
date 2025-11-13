using MunicipalApp.Managers;
using MunicipalApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalApp
{
    public partial class ServiceRequestStatusForm : Form
    {
        private ServiceRequestManager manager = new ServiceRequestManager();
  

        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            LoadSampleData();
            DisplayAllRequests();
        }

        private void LoadSampleData()
        {
            manager.AddRequest(new ServiceRequest(101, "John", "Water leak", "Pending"));
            manager.AddRequest(new ServiceRequest(102, "Mary", "Pothole", "In Progress"));
            manager.AddRequest(new ServiceRequest(103, "Peter", "Broken light", "Completed"));
            manager.AddRequest(new ServiceRequest(104, "Alice", "Blocked drain", "Pending"));

            // Example relationships
            manager.AddRelation(101, 104);
            manager.AddRelation(102, 103);
            manager.AddRelation(103, 101);
        }

        private void DisplayAllRequests()
        {
            listBoxRequests.Items.Clear();
            foreach (var req in manager.GetAllRequests())
                listBoxRequests.Items.Add(req);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchId.Text, out int id))
            {
                var req = manager.FindRequest(id);
                if (req != null)
                {
                    var related = manager.GetRelatedRequests(id);
                    string relatedText = related.Count > 0 ? string.Join(", ", related) : "None";
                    txtDetails.Text =
                        $"ID: {req.RequestId}\r\nResident: {req.ResidentName}\r\nDescription: {req.Description}\r\n" +
                        $"Status: {req.Status}\r\nRelated Requests: {relatedText}";
                    DisplayGraphConnections(id);
                }
                else MessageBox.Show("Service request not found.");
            }
        }

        private void listBoxRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRequests.SelectedItem is ServiceRequest req)
            {
                txtDetails.Text =
                    $"ID: {req.RequestId}\r\nResident: {req.ResidentName}\r\nDescription: {req.Description}\r\nStatus: {req.Status}";
                DisplayGraphConnections(req.RequestId);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayGraphConnections(int id)
        {
            graphView.Nodes.Clear();
            var bfs = manager.TraverseGraphFrom(id);

            if (bfs.Count == 0)
            {
                graphView.Nodes.Add($"Request {id} has no linked requests.");
                return;
            }

            TreeNode root = new TreeNode($"Request {id}");
            foreach (var connected in bfs)
                if (connected != id)
                    root.Nodes.Add($"Connected to Request {connected}");
            graphView.Nodes.Add(root);
            graphView.ExpandAll();
        }

        private void txtDetails_TextChanged(object sender, EventArgs e) { }

        private void txtDetails_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
