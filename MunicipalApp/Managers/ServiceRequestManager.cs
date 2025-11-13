using MunicipalApp.DataStructures;
using MunicipalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalApp.Managers
{
    public class ServiceRequestManager
    {
        private BinarySearchTree bst = new BinarySearchTree();
        private MinHeap heap = new MinHeap();
        private Graph graph = new Graph();
        // ✅ Add a graph to represent relationships between service requests

        public void AddRequest(ServiceRequest req)
        {
            bst.Insert(req);
            heap.Insert(req);
            graph.AddNode(req.RequestId); 
        }

        public ServiceRequest FindRequest(int id)
        {
            return bst.Search(id);
        }

        public List<ServiceRequest> GetAllRequests()
        {
            return bst.InOrderTraversal(); // Sorted order display
        }

        // ✅ Add relationships between service requests
        public void AddRelation(int id1, int id2)
        {
            graph.AddNode(id1);
            graph.AddNode(id2);
            graph.AddEdge(id1, id2);
        }

        public List<int> GetRelatedRequests(int id)
        {
            return graph.GetConnections(id);
        }

        public List<int> TraverseGraphFrom(int id)
        {
            return graph.BreadthFirstSearch(id); 
        }
    }
}
