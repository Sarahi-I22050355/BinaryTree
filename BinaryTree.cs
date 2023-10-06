using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            root = InsertRecursive(root, value);
        }

        private Node InsertRecursive(Node currentNode, int value)
        {
            if (currentNode == null)
            {
                return new Node(value);
            }

            if (value < currentNode.Value)
            {
                currentNode.Left = InsertRecursive(currentNode.Left, value);
            }
            else if (value > currentNode.Value)
            {
                currentNode.Right = InsertRecursive(currentNode.Right, value);
            }

            return currentNode;
        }

        public void Delete(int value)
        {
            root = DeleteRecursive(root, value);
        }

        private Node DeleteRecursive(Node currentNode, int value)
        {
            if (currentNode == null)
            {
                return currentNode;
            }

            if (value < currentNode.Value)
            {
                currentNode.Left = DeleteRecursive(currentNode.Left, value);
            }
            else if (value > currentNode.Value)
            {
                currentNode.Right = DeleteRecursive(currentNode.Right, value);
            }
            else
            {
                if (currentNode.Left == null)
                {
                    return currentNode.Right;
                }
                else if (currentNode.Right == null)
                {
                    return currentNode.Left;
                }

                currentNode.Value = FindMinValue(currentNode.Right);

                currentNode.Right = DeleteRecursive(currentNode.Right, currentNode.Value);
            }

            return currentNode;
        }

        private int FindMinValue(Node currentNode)
        {
            int minValue = currentNode.Value;
            while (currentNode.Left != null)
            {
                minValue = currentNode.Left.Value;
                currentNode = currentNode.Left;
            }
            return minValue;
        }

        public bool Search(int value)
        {
            return SearchRecursive(root, value);
        }

        private bool SearchRecursive(Node currentNode, int value)
        {
            if (currentNode == null)
            {
                return false;
            }

            if (value == currentNode.Value)
            {
                return true;
            }

            if (value < currentNode.Value)
            {
                return SearchRecursive(currentNode.Left, value);
            }

            return SearchRecursive(currentNode.Right, value);
        }
    }

}

