namespace BinaryTreeUnitTests
{
    [TestFixture]
    public class BinaryTreeSum_Test
    {
        [Test]
        public void SumDFSRootIsNullTest()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            int result = SumBT.SumDFS(tree.Root);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void SumDFSLevelTreeTest(List<int> nums, int expected)
        {
            BinaryTree<int> tree = new BinaryTree<int>(nums);
            int result = SumBT.SumDFS(tree.Root);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new int[] {1,2,3}, 6)]
        [TestCase(new int[] {-20,150,44,56,-300}, -70)]
        [TestCase(new int[] {5,8,11,-12,0,3}, 15)]
        public void SumDFSInsertTreeTest(int[] nums, int expected)
        {
            BinaryTree<int> tree = new BinaryTree<int>(nums);
            int result = SumBT.SumDFS(tree.Root);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SumBFSRootIsNullTest()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            int result = SumBT.SumBFS(tree.Root);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void SumBFSLevelTreeTest(List<int> nums, int expected)
        {
            BinaryTree<int> tree = new BinaryTree<int>(nums);
            int result = SumBT.SumBFS(tree.Root);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 1, 2, 3 }, 6)]
        [TestCase(new int[] { -20, 150, 44, 56, -300 }, -70)]
        [TestCase(new int[] { 5, 8, 11, -12, 0, 3 }, 15)]
        public void SumBFSInsertTreeTest(int[] nums, int expected)
        {
            BinaryTree<int> tree = new BinaryTree<int>(nums);
            int result = SumBT.SumBFS(tree.Root);
            Assert.That(result, Is.EqualTo(expected));
        }

        private static IEnumerable<TestCaseData> MyTestCases()
        {
            yield return new TestCaseData(new List<int> { 1, 2, 3 }, 6);
            yield return new TestCaseData(new List<int> { -20, 150, 44, 56, -300 }, -70);
            yield return new TestCaseData(new List<int> { 5, 8, 11, -12, 0, 3 }, 15);
        }
    }
}
