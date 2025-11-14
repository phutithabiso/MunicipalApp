using MunicipalApp.DataStructures;
using MunicipalApp.Models;
using System;
using System.Collections.Generic;

namespace MunicipalApp.Managers
{
    public class ServiceRequestManager
    {
        private BinarySearchTree bst = new BinarySearchTree();
        private MinHeap heap = new MinHeap();
        private Graph graph = new Graph();
        private RedBlackTree rbt = new RedBlackTree();
        private RequestHashTable hash = new RequestHashTable();
        private HistoryManager history = new HistoryManager();
        private SortedRequestDirectory sortedDir = new SortedRequestDirectory();
        private CategorySet categorySet = new CategorySet();
        private MST mst = new MST();

        // Add a new request
        public void AddRequest(ServiceRequest req)
        {
            bst.Insert(req);
            heap.Insert(req);
            graph.AddNode(req.RequestId);
            rbt.Insert(req);
            hash.Add(req);
            sortedDir.Add(req);
            categorySet.Add(req.Status);
        }

        // Find request by ID
        public ServiceRequest FindRequest(int id)
        {
            return bst.Search(id);
        }

        // Get all requests in sorted order
        public List<ServiceRequest> GetAllRequests()
        {
            return bst.InOrderTraversal();
        }

        // Add a relation between two requests
        public void AddRelation(int id1, int id2)
        {
            graph.AddNode(id1);
            graph.AddNode(id2);
            graph.AddEdge(id1, id2);
        }

        // Get related requests
        public List<int> GetRelatedRequests(int id)
        {
            return graph.GetConnections(id);
        }

        // Graph traversal from a request
        public List<int> TraverseGraphFrom(int id)
        {
            return graph.BreadthFirstSearch(id);
        }

        // Record an action in history
        public void RecordAction(string action)
        {
            history.AddAction(action);
        }

        // Undo last action
        public string UndoLastAction()
        {
            return history.Undo();
        }

        // Add page to navigation queue
        public void AddPage(string page)
        {
            history.AddPage(page);
        }

        // Get next page in navigation
        public string NextPage()
        {
            return history.NextPage();
        }

        // Get all requests in hash table
        public List<ServiceRequest> GetAllRequestsHash()
        {
            return hash.GetAll();
        }

        // Get sorted requests by resident name
        public SortedDictionary<string, List<ServiceRequest>> GetSortedRequests()
        {
            return sortedDir.GetAll();
        }

        // Get all unique categories/statuses
        public List<string> GetUniqueCategories()
        {
            return categorySet.GetUnique();
        }

        // Example MST usage (requires weighted adjacency matrix)
        public int CalculateMST(int[,] graphMatrix)
        {
            return mst.FindMST(graphMatrix);
        }
        public List<ServiceRequest> GetHeapRequests()
        {
            return heap.GetAll(); 
        }

    }
}
