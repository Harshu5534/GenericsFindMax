
using FindMaximumNumber;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaxNumber
    {
        [Test]
        public void GivenIntInput_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInteger(1, 2, 3);
            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void GivenMaxNumInPositionOne_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInteger(3, 1, 2);
            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void GivenMaxNumInPositionTwo_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInteger(1, 3, 2);
            Assert.AreEqual(actual, 3);
        }

    }
}