using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MunicipalApp.Models;


namespace MunicipalApp.DataStructures
{
    public class BinarySearchTree
    {
        public TreeNode<ServiceRequest> Root { get; private set; }

        public void Insert(ServiceRequest req)
        {
            Root = InsertRec(Root, req);
        }

        private TreeNode<ServiceRequest> InsertRec(TreeNode<ServiceRequest> root, ServiceRequest req)
        {
            if (root == null)
                return new TreeNode<ServiceRequest>(req);

            if (req.RequestId < root.Data.RequestId)
                root.Left = InsertRec(root.Left, req);
            else if (req.RequestId > root.Data.RequestId)
                root.Right = InsertRec(root.Right, req);

            return root;
        }

        public ServiceRequest Search(int id)
        {
            return SearchRec(Root, id);
        }

        private ServiceRequest SearchRec(TreeNode<ServiceRequest> root, int id)
        {
            if (root == null)
                return null;
            if (root.Data.RequestId == id)
                return root.Data;
            return id < root.Data.RequestId ? SearchRec(root.Left, id) : SearchRec(root.Right, id);
        }

        // Optional: In-order traversal (sorted list)
        public List<ServiceRequest> InOrderTraversal()
        {
            var list = new List<ServiceRequest>();
            InOrderRec(Root, list);
            return list;
        }

        private void InOrderRec(TreeNode<ServiceRequest> root, List<ServiceRequest> list)
        {
            if (root != null)
            {
                InOrderRec(root.Left, list);
                list.Add(root.Data);
                InOrderRec(root.Right, list);
            }
        }
    }
}