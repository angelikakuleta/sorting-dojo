using System;
using System.Collections.Generic;

namespace SortingDojo.Structures
{
    // Average insertion complecity: O(log(n))
    // Worst insertion complecity: O(n)
    // Average searching complecity: O(log(n))
    // Worst searching complecity: O(n)
    // Memory complexity: log(n) in the recursive method
    public class BinarySearchTree<T> where T : IComparable
    {
        private BST_Node<T> _root;

        public BinarySearchTree()
        {
            _root = null;
        }

        public void Insert(T data)
        {
            BST_Node<T> node = new BST_Node<T>(data);
            if (_root == null)
            {
                _root = node;
                return;
            }

            Queue<BST_Node<T>> queue = new Queue<BST_Node<T>>();
            queue.Enqueue(_root);

            while (queue.Count > 0)
            {
                BST_Node<T> currentNode = queue.Dequeue();

                if (data.CompareTo(currentNode.data) < 0)
                {
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = node;
                        break;
                    }

                    queue.Enqueue(currentNode.Left);
                }
                else
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = node;
                        break;
                    }
                        
                    queue.Enqueue(currentNode.Right);
                }
            }
        }

        public void Remove(T data)
        {
            throw new NotImplementedException();
        }

        public bool Contain(T data)
        {
            Queue<BST_Node<T>> queue = new Queue<BST_Node<T>>();
            queue.Enqueue(_root);
            
            while (queue.Count > 0)
            {
                BST_Node<T> currentNode = queue.Dequeue();
                if (currentNode.data.Equals(data)) return true;
                
                if (currentNode.Left != null)
                    queue.Enqueue(currentNode.Left);
                if (currentNode.Right != null)
                    queue.Enqueue(currentNode.Right);
            }

            return false;
        }

        public override string ToString()
        {
            return _root.ToString();
        }
    }
}
