using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
    class BinaryTree
    {
        public Node root;
        private int count;

        public BinaryTree()
        {
            root = null;
            count = 0;
        }
        public bool isEmpty()
        {
            return root == null;
        }

        public void insert(int d)
        {
            if (isEmpty())
            {
                root = new Node(d);
            }
            else
            {
                root.insertData(ref root, d);
            }

            count++;
        }

        public bool search(int s)
        {
            return root.search(root, s);
        }

        public bool isLeaf()
        {
            if (!isEmpty())
                return root.isLeaf(ref root);

            return true;
        }

        public void display()
        {
            if (!isEmpty())
                root.display(root);
        }

        public int Count()
        {
            return count;
        }

        public void ReverseTree(Node root)
        {
            Node tmp = root.leftLeaf;
            root.leftLeaf = root.rightLeaf;
            root.rightLeaf = tmp;

            if (root.leftLeaf != null) ReverseTree(root.leftLeaf);
            if (root.rightLeaf != null) ReverseTree(root.rightLeaf);
        }
    }
}
