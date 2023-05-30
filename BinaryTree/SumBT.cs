using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class SumBT
    {
        public static int SumDFS(Node<int>? root)
        {
            if (root == null) return 0;
            return root.Value + SumDFS(root.Left) + SumDFS(root.Right);
        }

        public static int SumBFS(Node<int>? root)
        {
            if (root == null) return 0;
            int sum = 0;
            Queue<Node<int>> queue = new Queue<Node<int>>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                sum += current.Value;
                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
            return sum;
        }
    }
}
