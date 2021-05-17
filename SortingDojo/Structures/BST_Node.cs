using System;

namespace SortingDojo.Structures
{
    public class BST_Node<T> where T : IComparable
    {
        public BST_Node(T data)
        {
            this.data = data;
        }

        public T data { get; set; }
        public BST_Node<T> Left { get; set; }
        public BST_Node<T> Right { get; set; }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append(this.data);
            if (this.Left != null) sb.Append("(L:" + this.Left.ToString() + ")");
            if (this.Right != null) sb.Append("(R:" + this.Right.ToString() + ")");
           
            return sb.ToString();
        }
    }
}
