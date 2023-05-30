using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class MinValueBT
    {
        public static int MinValueDFS(Node<int>? root)
        {
            if (root == null) return int.MaxValue;
            return Math.Min(root.Value, Math.Min(MinValueDFS(root.Left), MinValueDFS(root.Right)));
        }
        public static int MinValueBFS(Node<int>? root)
        {
            if(root is null) return int.MaxValue;
            int minVal = int.MaxValue;
            Queue<Node<int>> queue = new Queue<Node<int>>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                minVal = current.Value < minVal ? current.Value : minVal;
                if(current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if(current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
            return minVal;
        }
    }
}
