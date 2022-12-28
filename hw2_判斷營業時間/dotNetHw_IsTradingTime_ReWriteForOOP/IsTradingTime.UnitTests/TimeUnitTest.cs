using IsTradingTime.ClassLibrary;
using Newtonsoft.Json.Linq;

namespace IsTradingTime.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("2022/12/23 8:59:59")]
        [TestCase("2022/12/23 13:30:01")]
        public void IsTrading_�O���骺�𮧮ɶ��nReturnFalse(string testTime)
        {
            bool expect = false;
            bool actual = StockLibrary.IsTrading(Convert.ToDateTime(testTime));
            Assert.That(expect, Is.EqualTo(actual));
        }

        [TestCase("2022/12/24 8:59:59")]
        [TestCase("2022/12/24 13:30:01")]
        public void IsTrading_�O���骺�𮧮ɶ��nReturnFalse(string testTime)
        {
            bool expect = false;
            bool actual = StockLibrary.IsTrading(Convert.ToDateTime(testTime));
            Assert.That(expect, Is.EqualTo(actual));
        }
        [TestCase("2022/12/24 12:59:59")]
        [TestCase("2022/12/24 9:30:01")]
        public void IsTrading_�O���骺��~�ɶ��nReturnFalse(string testTime)
        {
            bool expect = false;
            bool actual = StockLibrary.IsTrading(Convert.ToDateTime(testTime));
            Assert.That(expect, Is.EqualTo(actual));
        }
        [TestCase("2022/12/23 12:59:59")]
        [TestCase("2022/12/23 9:30:01")]
        public void IsTrading_�O���骺��~�ɶ��nReturnTrue(string testTime)
        {
            bool expect = true;
            bool actual = StockLibrary.IsTrading(Convert.ToDateTime(testTime));
            // Assert.That(expect, Is.EqualTo(actual));
            Assert.AreEqual(actual,expect);
        }
    }

}