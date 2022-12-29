using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_085
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Construcktor for the node class

        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }
    /* A node class consist of three things, the information, refrences to the right child, and refrences to the left child */
    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; /*Initializing ROOT to null*/
        }
        public void Insert(string element)/* Insert a node in the binary search tree */
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null)/* Check if the node to be inserted already inserted or not */
            {
                Console.WriteLine("Duplicate words not allowerd");
                return;
            }
            else /* if the specified node is not present */
            {
                tmp = new Node(element, null, null);
                if (parent == null) /*if the trees is empty */
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    if (string.Compare(element, parent.info) < 0)
                        parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            /*This function searchs the currentNode of the specified Node as well as the current node of its parent */
            currentNode = ROOT;
            parent = null;
            while((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
