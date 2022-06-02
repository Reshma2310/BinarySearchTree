using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinaryTree
    {
        internal class BinarySearchTree<T> where T : IComparable<T>
        {
            public T NodeData;
            public BinarySearchTree<T> left;
            public BinarySearchTree<T> right;
            public BinarySearchTree(T data)
            {
                this.NodeData = data;
                this.left = null;
                this.right = null;
            }
            int leftSide = 0, rightSide = 0;
            public void AddNode(T value)
            {
                T nodeValue = this.NodeData;
                if (nodeValue.CompareTo(value) > 0)
                {
                    if (this.left == null)
                        this.left = new BinarySearchTree<T>(value);
                    else
                        this.left.AddNode(value);
                    Console.WriteLine("{0} Node added to Left", value);
                }
                else
                {
                    if (this.right == null)
                        this.right = new BinarySearchTree<T>(value);
                    else
                        this.right.AddNode(value);
                    Console.WriteLine("{0} Node added to Right", value);
                }
            }
            public void Display()
            {
                if (this.left != null)
                {
                    this.leftSide++;
                    this.left.Display();
                }
                Console.WriteLine(this.NodeData);
                if (this.right != null)
                {
                    this.rightSide++;
                    this.right.Display();
                }
            }
        }
    }
}
