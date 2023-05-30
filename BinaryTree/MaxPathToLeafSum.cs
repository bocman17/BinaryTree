using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class MaxPathToLeafSum
    {
        public static int DFSPathRecursive(Node<int>? root)
        {
            if (root == null) return int.MinValue;
            if (root.Left is null && root.Right is null) return root.Value;
            return root.Value + Math.Max(DFSPathRecursive(root.Left),
                DFSPathRecursive(root.Right));
        }
    }
}
