using BinaryTree;

namespace BinaryTreeUnitTests
{
    [TestFixture]
    public class BinaryTreeTest
    {
        [Test]
        public void BinaryTreeRootIsNullTest()
        {
            BinaryTree<char> tree = new BinaryTree<char>();

            Assert.That(tree.Root, Is.Null);
        }

        [Test]
        public void BinaryTreeInsertTest()
        {
            BinaryTree<char> tree = new BinaryTree<char>();
            tree.Insert('a');

            Assert.That(tree.Root?.Value, Is.EqualTo('a'));
        }

        [Test]
        public void BinaryTreeInsertWithRootNotNullTest()
        {
            BinaryTree<char> tree = new BinaryTree<char>('a');
            tree.Insert('b');

            Assert.That(tree.Root?.Right?.Value, Is.EqualTo('b'));
        }

        [Test]
        public void BinaryTreeInsertArrayTest()
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            BinaryTree<int> tree1 = new BinaryTree<int>(array1);
            Assert.Multiple(() =>
            {
                Assert.That(tree1.Root?.Value, Is.EqualTo(1));
                Assert.That(tree1.Root?.Right?.Value, Is.EqualTo(2));
                Assert.That(tree1.Root?.Right?.Right?.Value, Is.EqualTo(3));
                Assert.That(tree1.Root?.Right?.Right?.Right?.Value, Is.EqualTo(4));
                Assert.That(tree1.Root?.Right?.Right?.Right?.Right?.Value, Is.EqualTo(5));
                Assert.That(tree1.Root?.Right?.Right?.Right?.Right?.Right?.Value, Is.EqualTo(6));
                Assert.That(tree1.Root?.Right?.Right?.Right?.Right?.Right?.Right?.Value, Is.EqualTo(7));
                Assert.That(tree1.Root?.Right?.Right?.Right?.Right?.Right?.Right?.Right?.Value, Is.EqualTo(8));
            });

            int[] array2 = { 5, 8, 2, 6, 1, 4, 7, 3 };
            BinaryTree<int> tree2 = new BinaryTree<int>(array2);
            Assert.Multiple(() =>
            {
                Assert.That(tree2.Root?.Value, Is.EqualTo(5));
                Assert.That(tree2.Root?.Left?.Value, Is.EqualTo(2));
                Assert.That(tree2.Root?.Left?.Left?.Value, Is.EqualTo(1));
                Assert.That(tree2.Root?.Left?.Right?.Value, Is.EqualTo(4));
                Assert.That(tree2.Root?.Left?.Right?.Left?.Value, Is.EqualTo(3));
                Assert.That(tree2.Root?.Right?.Value, Is.EqualTo(8));
                Assert.That(tree2.Root?.Right?.Left?.Value, Is.EqualTo(6));
                Assert.That(tree2.Root?.Right?.Left?.Right?.Value, Is.EqualTo(7));
            });
        }

        [Test]
        public void BinaryTreeSortTest()
        {
            int[] array = { 5, 8, 2, 6, 1, 4, 7, 3 };
            BinaryTree<int> tree = new BinaryTree<int>(array);

            tree.Sort();
            Assert.Multiple(() =>
            {
                Assert.That(tree.Root?.Value, Is.EqualTo(1));
                Assert.That(tree.Root?.Right?.Value, Is.EqualTo(2));
                Assert.That(tree.Root?.Right?.Right?.Value, Is.EqualTo(3));
                Assert.That(tree.Root?.Right?.Right?.Right?.Value, Is.EqualTo(4));
                Assert.That(tree.Root?.Right?.Right?.Right?.Right?.Value, Is.EqualTo(5));
                Assert.That(tree.Root?.Right?.Right?.Right?.Right?.Right?.Value, Is.EqualTo(6));
                Assert.That(tree.Root?.Right?.Right?.Right?.Right?.Right?.Right?.Value, Is.EqualTo(7));
                Assert.That(tree.Root?.Right?.Right?.Right?.Right?.Right?.Right?.Right?.Value, Is.EqualTo(8));
            });
        }

        [Test]
        public void BinaryTreeCreateFromSortedListToLevelSortTest()
        {
            List<int> sortedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            BinaryTree<int> tree = new BinaryTree<int>(sortedList);

            Assert.Multiple(() =>
            {
                Assert.That(tree.Root?.Value, Is.EqualTo(1));
                Assert.That(tree.Root?.Left?.Value, Is.EqualTo(2));
                Assert.That(tree.Root?.Right?.Value, Is.EqualTo(3));
                Assert.That(tree.Root?.Left?.Left?.Value, Is.EqualTo(4));
                Assert.That(tree.Root?.Left?.Right?.Value, Is.EqualTo(5));
                Assert.That(tree.Root?.Right?.Left?.Value, Is.EqualTo(6));
                Assert.That(tree.Root?.Right?.Right?.Value, Is.EqualTo(7));
                Assert.That(tree.Root?.Left?.Left?.Left?.Value, Is.EqualTo(8));
            });
        }

        [Test]
        public void DFSIterativeTest()
        {
            List<char> sortedList = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            List<char> expected = new List<char> { 'a', 'b', 'd', 'e', 'c', 'f', 'g' };
            BinaryTree<char> tree = new BinaryTree<char>(sortedList);

            List<char> result = new List<char>();
            Action<char> action = result.Add;
            tree.DFSIterative(action);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void DFSRecursiveTest()
        {
            List<char> sortedList = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            List<char> expected = new List<char> { 'a', 'b', 'd', 'e', 'c', 'f', 'g' };
            BinaryTree<char> tree = new BinaryTree<char>(sortedList);

            List<char> result = new List<char>();
            Action<char> action = result.Add;
            tree.DFSRecursive(tree.Root, action);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void BFSTraverseTest()
        {
            List<char> sortedList = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            List<char> expected = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            BinaryTree<char> tree = new BinaryTree<char>(sortedList);

            List<char> result = new List<char>();
            Action<char> action = result.Add;
            tree.BFS(tree.Root, action);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}