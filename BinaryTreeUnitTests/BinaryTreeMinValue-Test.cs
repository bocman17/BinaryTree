namespace BinaryTreeUnitTests
{
    [TestFixture]
    public class BinaryTreeMinValue_Test
    {
        [Test]
        public void BinaryTreeMinValueRootIsNullDFSTest()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            int result = MinValueBT.MinValueDFS(tree.Root);
            Assert.That(result, Is.EqualTo(int.MaxValue));
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void BinaryTreeMinValueLevelTreeDFSTest(List<int> nums, int expected)
        {
            BinaryTree<int> tree = new BinaryTree<int>(nums);
            int result = MinValueBT.MinValueDFS(tree.Root);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 1, 2, 3 }, 1)]
        [TestCase(new int[] { -20, 150, 44, 56, -300 }, -300)]
        [TestCase(new int[] { 5, 8, 11, 12, 0, 3 }, 0)]
        public void BinaryTreeMinValueInsertTreeDFSTest(int[] nums, int expected)
        {
            BinaryTree<int> tree = new BinaryTree<int>(nums);
            int result = MinValueBT.MinValueDFS(tree.Root);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void BinaryTreeMinValueRootIsNullBFSTest()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            int result = MinValueBT.MinValueBFS(tree.Root);
            Assert.That(result, Is.EqualTo(int.MaxValue));
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void BinaryTreeMinValueLevelTreeBFSTest(List<int> nums, int expected)
        {
            BinaryTree<int> tree = new BinaryTree<int>(nums);
            int result = MinValueBT.MinValueBFS(tree.Root);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 1, 2, 3 }, 1)]
        [TestCase(new int[] { -20, 150, 44, 56, -300 }, -300)]
        [TestCase(new int[] { 5, 8, 11, 12, 0, 3 }, 0)]
        public void BinaryTreeMinValueInsertTreeBFSTest(int[] nums, int expected)
        {
            BinaryTree<int> tree = new BinaryTree<int>(nums);
            int result = MinValueBT.MinValueBFS(tree.Root);
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> MyTestCases()
        {
            yield return new TestCaseData(new List<int> { 1, 2, 3 }, 1);
            yield return new TestCaseData(new List<int> { -20, 150, 44, 56, -300 }, -300);
            yield return new TestCaseData(new List<int> { 5, 8, 11, 12, 0, 3 }, 0);
        }
    }
}
