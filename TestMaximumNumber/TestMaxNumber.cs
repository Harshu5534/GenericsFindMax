
using FindMaximumNumber;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaxNumber
    {
        [Test]
        public void GivenGenericsIntInput_WhenTestMax_ShouldReturnMaximum()
        {
            int[] arr = { 112, 344, 432, 555, 678 };
            FindMaximum<int> max = new FindMaximum<int>(arr);
            int actual = max.PrintMaxMethod();
            Assert.AreEqual(actual, 678);
        }
        [Test]
        public void GivenGenericsfloatInput_WhenTestMax_ShouldReturnMaximum()
        {
            float[] arr = { 2.3f, 5.6f, 1.3f, 4.5f, 6.7f };
            FindMaximum<float> max = new FindMaximum<float>(arr);
            float actual = max.PrintMaxMethod();
            Assert.AreEqual(actual, 6.7f);
        }
        [Test]
        public void GivenGenericsstringInput_WhenTestMax_ShouldReturnMaximum()
        {
            string[] arr = { "Apple", "Peach", "Banana", "Greaps", "WaterMellon" };
            FindMaximum<string> max = new FindMaximum<string>(arr);
            string actual = max.PrintMaxMethod();
            Assert.AreEqual(actual, "WaterMellon");
        }
    }
}
