using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_HashTableBinaryTree
{
    public class TreeNode
    {
        internal int data;
        internal TreeNode leftNode;
        internal TreeNode rightNode;
        public TreeNode(int data)
        {
            this.data = data;
            leftNode = null;
            rightNode = null;
        }
        public void Insert(int data)
        {
            int rootData = this.data;
            if (data >= rootData)
            {
                if (rightNode == null)
                {
                    rightNode = new TreeNode(data);
                }
                else
                {
                    rightNode.Insert(data);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new TreeNode(data);
                }
                else
                {
                    leftNode.Insert(data);
                }
            }
        }
        //Displaying as leftNode -> rootNode -> rightNode
        public void InOrderTraversal()
        {
            if (leftNode != null)
            {
                leftNode.InOrderTraversal();
            }
            Console.Write(data + "\n");
            if (rightNode != null)
            {
                rightNode.InOrderTraversal();
            }
        }
    }
}
