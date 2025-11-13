using MunicipalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalApp.DataStructures
{
    public class AVLTree
    {
        private class Node
        {
            public ServiceRequest Data;
            public Node Left, Right;
            public int Height;
            public Node(ServiceRequest data) { Data = data; Height = 1; }
        }

        private Node root;

        private int Height(Node n) => n?.Height ?? 0;
        private int Balance(Node n) => n == null ? 0 : Height(n.Left) - Height(n.Right);

        private Node RotateRight(Node y)
        {
            Node x = y.Left;
            Node T2 = x.Right;
            x.Right = y;
            y.Left = T2;
            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;
            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
            return x;
        }

        private Node RotateLeft(Node x)
        {
            Node y = x.Right;
            Node T2 = y.Left;
            y.Left = x;
            x.Right = T2;
            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;
            return y;
        }

        public void Insert(ServiceRequest data) => root = Insert(root, data);

        private Node Insert(Node node, ServiceRequest data)
        {
            if (node == null) return new Node(data);

            if (data.RequestId < node.Data.RequestId)
                node.Left = Insert(node.Left, data);
            else if (data.RequestId > node.Data.RequestId)
                node.Right = Insert(node.Right, data);
            else
                return node;

            node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
            int balance = Balance(node);

            if (balance > 1 && data.RequestId < node.Left.Data.RequestId)
                return RotateRight(node);
            if (balance < -1 && data.RequestId > node.Right.Data.RequestId)
                return RotateLeft(node);
            if (balance > 1 && data.RequestId > node.Left.Data.RequestId)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }
            if (balance < -1 && data.RequestId < node.Right.Data.RequestId)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }
    }
}
