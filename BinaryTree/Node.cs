namespace BinaryTree
{
    public class Node<T> : IEquatable<Node<T>>
    {
        public T Value { get; set; }
        public Node<T>? Right { get; set; }
        public Node<T>? Left { get; set; }

        public Node(T value)
        {
            Value = value;
            Right = null;
            Left = null;
        }

        public bool Equals(Node<T>? other)
        {
            if(other is null)
            {
                return false;
            }

            return EqualityComparer<T>.Default.Equals(Value, other.Value);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Node<T>);
        }
    }
}