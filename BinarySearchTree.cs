using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeCreation
{
    public class BinarySearchTree<T> where T : IComparable
    {
        public T nodeData;
        public BinarySearchTree<T> leftc;
        public BinarySearchTree<T> rightc;

        public BinarySearchTree(T data)
        {
            this.nodeData = data;
            this.leftc = null;
            this.rightc = null; 
        }
        int leftcount=0; int rightcount=0;
        bool result = false;

        //method for inserting elements
        public void Add(T item)
        {
            T currentNodeValue = this.nodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if(this.leftc == null)
                {
                    this.leftc = new BinarySearchTree<T>(item);
                }
                else
                {
                    this.leftc.Add(item);   
                }
            }
            else
            {
                if(this.rightc == null)
                {
                    this.rightc = new BinarySearchTree<T>(item);
                }
                else
                {
                    this.rightc.Add(item);
                }
            }
        }
        //method for displaying elements
        public void Display()
        {
            if (this.leftc != null)
            {
                this.leftcount++;
                this.leftc.Display();
            }
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightc != null)
            {
                this.rightcount++;
                this.rightc.Display();
            }
        }
        //method to get the size
        public void Size()
        {
            Console.WriteLine("Size = " + (1+ this.rightcount + this.leftcount));
        }
        public bool Search(T element, BinarySearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.nodeData.Equals(element))
            {
                Console.WriteLine("Element is present in BST");
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0}", node.nodeData);
            }
            if (element.CompareTo(node.nodeData) < 0)
            {
                Search(element, node.leftc);
            }
            if (element.CompareTo(node.nodeData) > 0)
            {
                Search(element, node.rightc);
            }
            return result;
        }
    }
}
