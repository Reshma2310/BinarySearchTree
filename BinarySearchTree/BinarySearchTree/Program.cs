using System;
namespace BinarySearchTree
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree started");
            BinaryTree.BinarySearchTree<int> binary = new BinaryTree.BinarySearchTree<int>(56);
            binary.AddNode(30);
            binary.AddNode(70);
            binary.Display();
        }
    }
}