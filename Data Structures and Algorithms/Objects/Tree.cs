using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms.Objects
{
    class Tree
    {
        private TreeNode root;

        public TreeNode Get(int value)
        {
            if (root != null)
            {
                return root.Get(value);
            }
            return null;
        }

        public void Delete(int value)
        {
            root = Delete(root, value);
        }

        private TreeNode Delete(TreeNode subtreeRoot, int value)
        {
            if (subtreeRoot == null)
            {
                return subtreeRoot;
            }
            if (value < subtreeRoot.GetData())
            {
                subtreeRoot.SetLeftChild(Delete(subtreeRoot.GetLeftChild(), value));
            }
            else if (value > subtreeRoot.GetData())
            {
                subtreeRoot.SetRightChild(Delete(subtreeRoot.GetRightChild(), value));
            }
            else
            {
                // if it is a leaf or has only one child
                if (subtreeRoot.GetLeftChild() == null)
                {
                    return subtreeRoot.GetRightChild();
                }
                else if (subtreeRoot.GetRightChild() == null)
                {
                    return subtreeRoot.GetLeftChild();
                }

                // Node has 2 children
                // Replace the alue int he subtreeRoot node with the smallest value
                // from the right subtree
                subtreeRoot.SetData(subtreeRoot.GetRightChild().Min());

                // Delete the node that has the smallest value in the right subtree
                subtreeRoot.SetRightChild(Delete(subtreeRoot.GetRightChild(), subtreeRoot.GetData()));
            }
            return subtreeRoot;
        }

        public void Insert(int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
            }
            else
            {
                root.Insert(value);
            }
        }

        public int Min()
        {
            if (root == null)
            {
                return Int32.MinValue;
            }
            else
            {
                return root.Min();
            }
        }

        public int Max()
        {
            if (root == null)
            {
                return Int32.MaxValue;
            }
            else
            {
                return root.Max();
            }
        }

        public void TraverseInOrder()
        {
            if (root != null)
            {
                root.TraverseInOrder();
            }
        }
    }
}
