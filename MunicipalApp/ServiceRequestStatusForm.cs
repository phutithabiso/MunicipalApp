using MunicipalApp.Managers;
using MunicipalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalApp
{
    public partial class ServiceRequestStatusForm : Form
    {
        private ServiceRequestManager manager = new ServiceRequestManager();

        // Additional structures for demo
        private SortedDictionary<int, ServiceRequest> sortedDict = new SortedDictionary<int, ServiceRequest>();
        private HashSet<string> statusSet = new HashSet<string>();
        private Stack<string> actionHistory = new Stack<string>();
        private Queue<string> navigationQueue = new Queue<string>();

        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            LoadSampleData();
            DisplayAllRequests();
            UpdateAdditionalStructures();
        }

        private void LoadSampleData()
        {
            var r1 = new ServiceRequest(101, "John", "Water leak", "Pending");
            var r2 = new ServiceRequest(102, "Mary", "Pothole", "In Progress");
            var r3 = new ServiceRequest(103, "Peter", "Broken light", "Completed");
            var r4 = new ServiceRequest(104, "Alice", "Blocked drain", "Pending");

            manager.AddRequest(r1);
            manager.AddRequest(r2);
            manager.AddRequest(r3);
            manager.AddRequest(r4);

            manager.AddRelation(101, 104);
            manager.AddRelation(102, 103);
            manager.AddRelation(103, 101);

            // Fill SortedDictionary
            sortedDict[r1.RequestId] = r1;
            sortedDict[r2.RequestId] = r2;
            sortedDict[r3.RequestId] = r3;
            sortedDict[r4.RequestId] = r4;

            // Fill HashSet
            statusSet.Add(r1.Status);
            statusSet.Add(r2.Status);
            statusSet.Add(r3.Status);
            statusSet.Add(r4.Status);

            // Stack and Queue example
            actionHistory.Push("Loaded Sample Data");
            navigationQueue.Enqueue("Main Screen");
        }

        private void DisplayAllRequests()
        {
            listBoxRequests.Items.Clear();
            foreach (var req in manager.GetAllRequests())
            {
                listBoxRequests.Items.Add(req);
            }
        }

        private void UpdateAdditionalStructures()
        {
            // MinHeap
            listBoxHeap.Items.Clear();
            foreach (var req in manager.GetHeapRequests())
                listBoxHeap.Items.Add(req);

            // SortedDictionary
            listBoxSorted.Items.Clear();
            foreach (var kvp in sortedDict)
                listBoxSorted.Items.Add($"{kvp.Key}: {kvp.Value.Description}");

            // HashSet (Unique Statuses)
            listBoxCategories.Items.Clear();
            foreach (var status in statusSet)
                listBoxCategories.Items.Add(status);

            // Stack (Action History)
            listBoxHistory.Items.Clear();
            foreach (var action in actionHistory)
                listBoxHistory.Items.Add(action);

            // Queue (Navigation)
            listBoxNavigation.Items.Clear();
            foreach (var nav in navigationQueue)
                listBoxNavigation.Items.Add(nav);
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

                    // Update action history
                    actionHistory.Push($"Searched Request {id}");
                    navigationQueue.Enqueue($"Viewed Request {id}");
                    UpdateAdditionalStructures();
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

                actionHistory.Push($"Selected Request {req.RequestId}");
                navigationQueue.Enqueue($"Viewed Request {req.RequestId}");
                UpdateAdditionalStructures();
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

        private void txtDetails_TextChanged_1(object sender, EventArgs e)
        {
        }
    }
}
