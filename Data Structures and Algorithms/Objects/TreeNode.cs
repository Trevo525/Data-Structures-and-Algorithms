using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms.Objects
{
    class TreeNode
    {
        private int data;
        private TreeNode leftChild;
        private TreeNode rightChild;

        public TreeNode(int data)
        {
            this.data = data;
        }

        public void Insert(int value)
        {
            if (data == value)
            {
                return;
            }

            if (value < data)
            {
                if (leftChild == null)
                {
                    leftChild = new TreeNode(value);
                }
                else
                {
                    leftChild.Insert(value);
                }
            }
            else
            {
                if (rightChild == null)
                {
                    rightChild = new TreeNode(value);
                }
                else
                {
                    rightChild.Insert(value);
                }
            }
        }

        public override String ToString()
        {
            return "Data = " + data;
        }


        public TreeNode Get(int value)
        {
            if (data == value)
            {
                return this;
            }
            else if (value < data)
            {
                if (leftChild != null)
                {
                    return leftChild.Get(value);
                }
            }
            else
            {
                if (rightChild != null)
                {
                    return rightChild.Get(value);
                }
            }
            return null;
        }

        public int Min()
        {
            if (leftChild == null)
            {
                return data;
            }
            else
            {
                return leftChild.Min();
            }
        }

        public int Max()
        {
            if (rightChild == null)
            {
                return data;
            }
            else
            {
                return rightChild.Max();
            }
        }

        public void TraverseInOrder()
        {
            if (leftChild != null)
            {
                leftChild.TraverseInOrder();
            }
            Console.WriteLine("Data = " + data + ", ");
            if (rightChild != null)
            {
                rightChild.TraverseInOrder();
            }
        }

        public int GetData()
        {
            return this.data;
        }

        public void SetData(int data)
        {
            this.data = data;
        }

        public TreeNode GetLeftChild()
        {
            return this.leftChild;
        }

        public void SetLeftChild(TreeNode leftChild)
        {
            this.leftChild = leftChild;
        }

        public TreeNode GetRightChild()
        {
            return this.rightChild;
        }

        public void SetRightChild(TreeNode rightChild)
        {
            this.rightChild = rightChild;
        }
    }
}
