
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

        //    [Test]
        //    public void GivenMaxNumIntPositionOne_WhenTestMax_ShouldReturnMaximum()
        //    {
        //        FindMaximum max = new FindMaximum();
        //        int actual = max.FindMaxInteger(3, 1, 2);
        //        Assert.AreEqual(actual, 3);
        //    }
        //    [Test]
        //    public void GivenMaxNumIntPositionTwo_WhenTestMax_ShouldReturnMaximum()
        //    {
        //        FindMaximum max = new FindMaximum();
        //        int actual = max.FindMaxInteger(1, 3, 2);
        //        Assert.AreEqual(actual, 3);
        //    }
        //    [Test]
        //    public void GivenFloatInput_WhenTestMax_ShouldReturnMaximum()
        //    {
        //        FindMaximum max = new FindMaximum();
        //        float actual = max.FindMaxFloat(1.2f, 3.6f, 6.7f);
        //        Assert.AreEqual(actual,6.7f);
        //    }
        //    [Test]
        //    public void GivenMaxNumfloatPositionOne_WhenTestMax_ShouldReturnMaximum()
        //    {
        //        FindMaximum max = new FindMaximum();
        //        float actual = max.FindMaxFloat(6.7f, 1.2f, 3.6f);
        //        Assert.AreEqual(actual, 6.7f);
        //    }
        //    [Test]
        //    public void GivenMaxNumfloatPositionTwo_WhenTestMax_ShouldReturnMaximum()
        //    {
        //        FindMaximum max = new FindMaximum();
        //        float actual = max.FindMaxFloat(1.2f,6.7f,3.6f);
        //        Assert.AreEqual(actual, 6.7f);
        //    }
        //    [Test]
        //    public void GivenStringInput_WhenTestMax_ShouldReturnMaximum()
        //    {
        //        FindMaximum max = new FindMaximum();
        //        string actual = max.FindMaxString("Apple","Peach","Banana");
        //        Assert.AreEqual(actual,"Banana");
        //    }
        //    [Test]
        //    public void GivenMaxStringPositionOne_WhenTestMax_ShouldReturnMaximum()
        //    {
        //        FindMaximum max = new FindMaximum();
        //        string actual = max.FindMaxString("Banana","Apple","Peach");
        //        Assert.AreEqual(actual,"Banana");
        //    }
        //    [Test]
        //    public void GivenMaxStringPositionTwo_WhenTestMax_ShouldReturnMaximum()
        //    {
        //        FindMaximum max = new FindMaximum();
        //        string actual = max.FindMaxString("Apple","Banana","Peac");
        //        Assert.AreEqual(actual,"Banana");
        //    }
        //}
    