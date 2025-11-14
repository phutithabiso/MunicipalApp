using MunicipalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalApp.DataStructures
{
    public class RedBlackTree
    {
        private enum Color { Red, Black }

        private class Node
        {
            public ServiceRequest Data;
            public Node Left, Right, Parent;
            public Color NodeColor;

            public Node(ServiceRequest data)
            {
                Data = data;
                NodeColor = Color.Red;
            }
        }

        private Node root;

        public void Insert(ServiceRequest req)
        {
            Node newNode = new Node(req);
            root = InsertRec(root, newNode);
            FixViolation(newNode);
        }

        private Node InsertRec(Node root, Node newNode)
        {
            if (root == null)
                return newNode;

            if (newNode.Data.RequestId < root.Data.RequestId)
            {
                root.Left = InsertRec(root.Left, newNode);
                root.Left.Parent = root;
            }
            else
            {
                root.Right = InsertRec(root.Right, newNode);
                root.Right.Parent = root;
            }
            return root;
        }

        private void RotateLeft(Node x)
        {
            Node y = x.Right;
            x.Right = y.Left;

            if (y.Left != null) y.Left.Parent = x;
            y.Parent = x.Parent;

            if (x.Parent == null) root = y;
            else if (x == x.Parent.Left) x.Parent.Left = y;
            else x.Parent.Right = y;

            y.Left = x;
            x.Parent = y;
        }

        private void RotateRight(Node y)
        {
            Node x = y.Left;
            y.Left = x.Right;

            if (x.Right != null) x.Right.Parent = y;
            x.Parent = y.Parent;

            if (y.Parent == null) root = x;
            else if (y == y.Parent.Left) y.Parent.Left = x;
            else y.Parent.Right = x;

            x.Right = y;
            y.Parent = x;
        }

        private void FixViolation(Node node)
        {
            while (node != root && node.Parent.NodeColor == Color.Red)
            {
                var parent = node.Parent;
                var grandparent = node.Parent.Parent;

                if (parent == grandparent.Left)
                {
                    var uncle = grandparent.Right;

                    if (uncle != null && uncle.NodeColor == Color.Red)
                    {
                        grandparent.NodeColor = Color.Red;
                        parent.NodeColor = Color.Black;
                        uncle.NodeColor = Color.Black;
                        node = grandparent;
                    }
                    else
                    {
                        if (node == parent.Right)
                        {
                            RotateLeft(parent);
                            node = parent;
                            parent = node.Parent;
                        }
                        RotateRight(grandparent);
                        parent.NodeColor = Color.Black;
                        grandparent.NodeColor = Color.Red;
                    }
                }
                else
                {
                    var uncle = grandparent.Left;

                    if (uncle != null && uncle.NodeColor == Color.Red)
                    {
                        grandparent.NodeColor = Color.Red;
                        parent.NodeColor = Color.Black;
                        uncle.NodeColor = Color.Black;
                        node = grandparent;
                    }
                    else
                    {
                        if (node == parent.Left)
                        {
                            RotateRight(parent);
                            node = parent;
                            parent = node.Parent;
                        }
                        RotateLeft(grandparent);
                        parent.NodeColor = Color.Black;
                        grandparent.NodeColor = Color.Red;
                    }
                }
            }
            root.NodeColor = Color.Black;
        }
    }
}
