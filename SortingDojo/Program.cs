using SortingDojo.Structures;
using System;
using System.Collections.Generic;

namespace SortingDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 9, 18, -23, 17, 0, 6, -19, 9, 2, -6, 8, 19, -3, 4, 7, -1 };
            
            BinarySearchTree<int> binaryTree = new BinarySearchTree<int>();
            foreach (var item in numbers)
            {
                binaryTree.Insert(item);
            }

            Console.WriteLine(binaryTree.Contain(numbers[3]));
            Console.WriteLine(binaryTree);
        }
    }
}
