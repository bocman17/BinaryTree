using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T>? Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }
        public BinaryTree(T root)
        {
            Root = new Node<T>(root);
        }
        public BinaryTree(T[] array)
        {
            foreach (T item in array)
            {
                Insert(item);
            }
        }

        public BinaryTree(List<T> sortedList)
        {
            Root = CreateTreeFromSortedListToLevelSort(sortedList);
        }


        public void Insert(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                InsertRecursive(Root, newNode);
            }
        }

        private void InsertRecursive(Node<T> currentNode, Node<T> newNode)
        {
            if (newNode.Value.CompareTo(currentNode.Value) < 0)
            {
                if (currentNode.Left is null)
                {
                    currentNode.Left = newNode;
                }
                else
                {
                    InsertRecursive(currentNode.Left, newNode);
                }
            }
            else
            {
                if (currentNode.Right is null)
                {
                    currentNode.Right = newNode;
                }
                else
                {
                    InsertRecursive(currentNode.Right, newNode);
                }
            }
        }

        private Node<T>? CreateTreeFromSortedListToLevelSort(List<T> sortedList)
        {
            if(sortedList.Count == 0) return null;

            Queue<Node<T>> queue = new Queue<Node<T>>();
            Node<T> root = new Node<T>(sortedList[0]);
            queue.Enqueue(root);

            int index = 1;
            while (index < sortedList.Count)
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
                if (index < sortedList.Count)
                {
                    current.Right = new Node<T>(sortedList[index]);
                    queue.Enqueue(current.Right);
                    index++;
                }
            }
            return root;
        }
        public void Sort()
        {
            List<T> sortedList = new List<T>();
            InOrderTraversal(Root, sortedList);
            sortedList.Sort();

            Root = null;

            foreach (T value in sortedList)
            {
                Insert(value);
            }
        }

        private void InOrderTraversal(Node<T>? node, List<T> sortedList)
        {
            if (node is null)
            {
                return;
            }

            InOrderTraversal(node.Left, sortedList);
            sortedList.Add(node.Value);
            InOrderTraversal(node.Right, sortedList);
        }

        public void DFSIterative(Action<T> visit)
        {
            if (Root == null)
            {
                return;
            }

            Stack<Node<T>> stack = new Stack<Node<T>>();
            stack.Push(Root);

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

        public void DFSRecursive(Node<T>? node, Action<T> visit)
        {
            if (node == null)
            {
                return;
            }
            visit(node.Value);

            DFSRecursive(node.Left, visit);
            DFSRecursive(node.Right, visit);
        }

        public void BFS(Node<T>? node, Action<T> visit)
        {
            if (node == null)
            {
                return;
            }
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                Node<T> current = queue.Dequeue();
                visit(current.Value);
                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
        }
    }
}
