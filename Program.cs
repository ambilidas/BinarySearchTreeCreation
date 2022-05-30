using System;

namespace BinarySearchTreeCreation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to Binary Search Tree Program");
            BinarySearchTree<int> obj1 = new BinarySearchTree<int>(56);
            Console.WriteLine("Added the elements 30&70");
            obj1.Add(30);
            obj1.Add(70);
            obj1.Display();
            Console.WriteLine("Add more elements and get the size");
            obj1.Add(22);
            obj1.Add(40);
            obj1.Add(60);
            obj1.Add(95);
            obj1.Add(11);
            obj1.Add(65);
            obj1.Add(3);
            obj1.Add(16);
            obj1.Add(63);
            obj1.Add(67);
            obj1.Display();
            obj1.Size();
            Console.WriteLine("Search for 63");
            bool result = obj1.Search(63, obj1);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
