using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class SortBT<T> where T : IComparable<T>
    {
        public static void LevelSort(BinaryTree<T> tree)
        {
            List<T> sortedList = new List<T>();
            Action<T> addAction = sortedList.Add;
            DFS(tree, addAction);
            sortedList.Sort();

            tree.Root = CreateTreeFromSortedListToLevelSort(sortedList);
        }

        private static Node<T> CreateTreeFromSortedListToLevelSort(List<T> sortedList)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            Node<T> root = new Node<T>(sortedList[0]);
            queue.Enqueue(root);

            int index = 1;
            while(index < sortedList.Count)
            {
                Node<T> current = queue.Dequeue();

                // Create left child
                if (index < sortedList.Count)
                {
                    current.Left = new Node<T>(sortedList[index]);
                    queue.Enqueue(current.Left);
                    index++;
                }

                // Create right child
                if(index < sortedList.Count)
                {
                    current.Right = new Node<T>(sortedList[index]);
                    queue.Enqueue(current.Right);
                    index++;
                }
            }
            return root;
        }

        private static void DFS(BinaryTree<T> tree, Action<T> visit)
        {
            if (tree.Root == null)
            {
                return;
            }

            Stack<Node<T>> stack = new Stack<Node<T>>();
            stack.Push(tree.Root);

            while (stack.Count > 0)
            {
                Node<T> current = stack.Pop();

                visit(current.Value);

                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }

                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }
            }
        }
    }
}
