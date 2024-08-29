using System.Reflection;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class MaxIntTests
    {
        [Test]
        public void Max_WhenListOfSeveralIntsPassed_ReturnsMaxInt(
            [Values(-99, 0, 44, 1066)] int a,
            [Values(-6666, 34, 1, 678932)] int b)
        {
            List<int> nums = new List<int>() {99, 0, a, -45, 3, 22, -1106, b};
            var expectedMax = nums.Max();
            var result = Operations.Max(nums);
            Assert.That(result == expectedMax);
        }
        
        [Test]
        public void Max_WhenListOfOneIntPassed_ReturnsMaxInt()
        {
            List<int> nums = new List<int>() {-45};
            var expectedMax = nums.Max();
            var result = Operations.Max(nums);
            Assert.That(result == expectedMax);
        }

        [Test]
        public void Max_WhenEmptyListIsPassed_Returns0()
        {
            List<int> nums = new List<int>();
            var result = Operations.Max(nums);
            Assert.That(result == 0);
        }

        [Test]
        public void Max_WhenNullIsPassed_Returns0()
        {
            var result = Operations.Max(null);
            Assert.That(result == 0);
        }
    }
}