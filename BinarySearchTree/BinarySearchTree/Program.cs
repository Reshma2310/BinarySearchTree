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
            binary.AddNode(22);
            binary.AddNode(40);
            binary.AddNode(60);
            binary.AddNode(95);
            binary.AddNode(11);
            binary.AddNode(65);
            binary.AddNode(3);
            binary.AddNode(16);
            binary.AddNode(63);
            binary.AddNode(67);
            Console.WriteLine("\n*------Binary Tree Output is------*");
            binary.Display();
            Console.WriteLine("Enter node to search:");
            int element = Convert.ToInt32(Console.ReadLine());
            binary.search(element, binary);            
        }
    }
}