using System.Reflection;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class MaxIntTests
    {
        private List<int> nums;
        [SetUp]
        public void SetUp()
        {
            nums = new List<int>();
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            int result = Operations.Max(nums);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Max_SingleElementList_ReturnsElement()
        {
            List<int> nums = new List<int> { 5 };
            int result = Operations.Max(nums);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Max_MultipleElementsList_ReturnsMax()
        {
            List<int> nums = new List<int> { 1, 3, 7, 2, 5 };
            int result = Operations.Max(nums);
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Max_NegativeNumbersList_ReturnsMax()
        {
            List<int> nums = new List<int> { -1, -3, -7, -2, -5 };
            int result = Operations.Max(nums);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Max_DuplicateMaxValuesList_ReturnsMax()
        {
            List<int> nums = new List<int> { 1, 3, 7, 7, 5 };
            int result = Operations.Max(nums);
            Assert.That(result, Is.EqualTo(7));
        }
    }
}