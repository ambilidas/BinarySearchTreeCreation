using System;

namespace BinarySearchTreeCreation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to Binary Search Tree Program");
            BinarySearchTree<int> obj1 = new BinarySearchTree<int>(56);
            obj1.Add(30);
            obj1.Add(70);
            obj1.Display();
            Console.ReadKey();
        }
    }
}
