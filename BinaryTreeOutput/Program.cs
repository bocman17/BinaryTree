using BinaryTree;

List<int> list = new List<int>() { 5,11,3,4,2,0,1 };
BinaryTree<int> tree = new BinaryTree<int>(list);

int result = MaxPathToLeafSum.DFSPathRecursive(tree.Root);
Console.WriteLine(result);  

/*         -2
 *         / \
 *        1   3
 *       / \ / \
 *      4  4 11
 */