namespace BinaryTreeUnitTests
{
    [TestFixture]
    public class BinaryTreeIncludes_Test
    {
        [Test]
        public void BFSIncludesRootIsNullTest()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            bool result = SearchBT<int>.BFSIncludes(tree.Root, 1);
            Assert.That(result, Is.False);
        }

        [Test]
        public void BFSIncludesAssertTrueTest()
        {
            List<char> list = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            BinaryTree<char> tree1 = new BinaryTree<char>(list);
            BinaryTree<char> tree2 = new BinaryTree<char>(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' });
            bool result1 = SearchBT<char>.BFSIncludes(tree1.Root, 'e');
            bool result2 = SearchBT<char>.BFSIncludes(tree2.Root, 'e');
            Assert.Multiple(() =>
            {
                Assert.That(result1, Is.True);
                Assert.That(result2, Is.True);
            });
        }

        [Test]
        public void BFSIncludesAssertFalseTest()
        {
            List<char> list = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            BinaryTree<char> tree1 = new BinaryTree<char>(list);
            BinaryTree<char> tree2 = new BinaryTree<char>(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' });
            bool result1 = SearchBT<char>.BFSIncludes(tree1.Root, 'h');
            bool result2 = SearchBT<char>.BFSIncludes(tree2.Root, 'h');
            Assert.Multiple(() =>
            {
                Assert.That(result1, Is.False);
                Assert.That(result2, Is.False);
            });
        }

        [Test]
        public void DFSIncludesRootIsNullTest()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            bool result = SearchBT<int>.DFSIncludes(tree.Root, 1);
            Assert.That(result, Is.False);
        }

        [Test]
        public void DFSIncludesAssertTrueTest()
        {
            List<char> list = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            BinaryTree<char> tree1 = new BinaryTree<char>(list);
            BinaryTree<char> tree2 = new BinaryTree<char>(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' });
            bool result1 = SearchBT<char>.DFSIncludes(tree1.Root, 'e');
            bool result2 = SearchBT<char>.DFSIncludes(tree2.Root, 'e');
            Assert.Multiple(() =>
            {
                Assert.That(result1, Is.True);
                Assert.That(result2, Is.True);
            });
        }

        [Test]
        public void DFSIncludesAssertFalseTest()
        {
            List<char> list = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            BinaryTree<char> tree1 = new BinaryTree<char>(list);
            BinaryTree<char> tree2 = new BinaryTree<char>(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' });
            bool result1 = SearchBT<char>.DFSIncludes(tree1.Root, 'h');
            bool result2 = SearchBT<char>.DFSIncludes(tree2.Root, 'h');
            Assert.Multiple(() =>
            {
                Assert.That(result1, Is.False);
                Assert.That(result2, Is.False);
            });
        }
    }
}
