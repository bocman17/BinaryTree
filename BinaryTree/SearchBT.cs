using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class SearchBT<T> where T : IComparable<T>
    {
        public static bool BFSIncludes(Node<T>? root, T target)
        {
            if (root is null)
            {
                return false;
            }
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current.Value.CompareTo(target) == 0)
                {
                    return true;
                }
                if (current.Left is not null)
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right is not null)
                {
                    queue.Enqueue(current.Right);
                }
            }
            return false;
        }

        public static bool DFSIncludes(Node<T>? root, T target)
        {
            if (root is null)
            {
                return false;
            }

            if (root.Value.CompareTo(target) == 0)
            {
                return true;
            }

            return DFSIncludes(root.Left, target) || DFSIncludes(root.Right, target);
        }
    }

}
