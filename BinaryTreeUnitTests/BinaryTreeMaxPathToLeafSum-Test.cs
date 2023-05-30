using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeUnitTests
{
    [TestFixture]
    public class BinaryTreeMaxPathToLeafSum_Test
    {
        [Test]
        public void MaxPathToLeafSumRootIsNullTest()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            int result = MaxPathToLeafSum.DFSPathRecursive(tree.Root);
            Assert.That(result, Is.EqualTo(int.MinValue));
        }

        [Test]
        public void MaxPathToLeafSumRootHasNoChildrenTest()
        {
            BinaryTree<int> tree = new BinaryTree<int>(20);
            int result = MaxPathToLeafSum.DFSPathRecursive(tree.Root);
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void MaxPathToLeafSumLevelSortChildrenTest(List<int> nums, int expected)
        {
            BinaryTree<int> tree = new BinaryTree<int>(nums);
            int result = MaxPathToLeafSum.DFSPathRecursive(tree.Root);
            Assert.That(result, Is.EqualTo(expected));
        }

        private static IEnumerable<TestCaseData> MyTestCases()
        {
            yield return new TestCaseData(new List<int> { 1, 2, 3 }, 4);
            yield return new TestCaseData(new List<int> { -300, -20, 44, 56, 150 }, -170);
            yield return new TestCaseData(new List<int> { 0, 3, 5, 8, 11, 12 }, 17);
        }
    }
}
